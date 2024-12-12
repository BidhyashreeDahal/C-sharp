/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-6
 * Class that provides the properties and methods of the Tools
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Assignment5;
using System.Data.SqlClient;

namespace DBAL
{
    internal class Tools
    {
        // <summary>
        /// Retrieves the connection string from the configuration.
        /// </summary>
        /// <returns>Connection string for the database.</returns>
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["VideoGameReviewDB"].ConnectionString;
        }
        // <summary>
        /// Validates the passkey to ensure it is a 4-digit numeric value.
        /// </summary>
        /// <param name="passkey">The passkey to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidPasskey(string passkey)
        {
            return int.TryParse(passkey, out int numericPassKey) && passkey.Length == 4 && (numericPassKey >= 1000 && numericPassKey <= 9999);
        }
        /// <summary>
        /// Validates the first name to ensure it contains only letters and is up to 50 characters long.
        /// </summary>
        /// <param name="firstName">The first name to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidFirstName(string firstName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(firstName, @"^[A-Za-z]+$") && firstName.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Validates the last name to ensure it contains only letters and is up to 50 characters long.
        /// </summary>
        /// <param name="lastName">The last name to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidLastName(string lastName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(lastName, @"^[A-Za-z]+$") && lastName.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Validates the email format.
        /// </summary>
        /// <param name="email">The email to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the provided email already exists in the database.
        /// </summary>
        /// <param name="email">The email to be checked.</param>
        /// <returns>True if the email exists, otherwise false.</returns>

        public static bool EmailExists(string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Return true if email exists, false otherwise
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Retrieves the maximum UserID from the Users table.
        /// </summary>
        /// <returns>The maximum UserID from the database.</returns>
        public static int GetMaxUserIDFromDatabase()
        {
            int maxUserID = 0; // Default value in case no users exist in the database
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "SELECT MAX(UserID) FROM Users";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxUserID = Convert.ToInt32(result);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving max UserID: " + ex.Message);
            }

            return maxUserID;
        }
        // <summary>
        /// Checks if a review already exists for a specific game and user.
        /// </summary>
        /// <param name="gameId">The GameID to check.</param>
        /// <param name="userId">The UserID to check.</param>
        /// <returns>True if the review exists, otherwise false.</returns>

        public static bool CheckIfReviewExists(int gameId, int userId)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Reviews WHERE GameID = @GameID AND ReviewerID = @ReviewerID", connection);
                cmd.Parameters.AddWithValue("@GameID", gameId);
                cmd.Parameters.AddWithValue("@ReviewerID", userId);
                connection.Open();
                int reviewCount = (int)cmd.ExecuteScalar();
                connection.Close();
                return reviewCount > 0; // If count is greater than 0, it means the user has already reviewed the game.
            }
        }
    }

}
