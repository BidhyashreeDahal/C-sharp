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
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["VideoGameReviewDB"].ConnectionString;
        }
        public static bool IsValidPasskey(string passkey)
        {
            return int.TryParse(passkey, out int numericPassKey) && passkey.Length == 4 && (numericPassKey >= 1000 && numericPassKey <= 9999);
        }

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
        public static int GetMaxUserIDFromDatabase()
        {
            int maxUserID = 0; // Default value in case no users exist in the database
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    // Query to get the maximum UserID from the database
                    string query = "SELECT MAX(UserID) FROM Users";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();

                    // Execute the query and retrieve the result
                    object result = cmd.ExecuteScalar();

                    // If there are users in the database, result will be a valid integer
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

        public static int GetMaxReviewIDFromDatabase()
        {
            int maxReviewID = 0; // Default value in case no users exist in the database
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    // Query to get the maximum UserID from the database
                    string query = "SELECT MAX(ReviewID) FROM Reviews";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();

                    // Execute the query and retrieve the result
                    object result = cmd.ExecuteScalar();

                    // If there are users in the database, result will be a valid integer
                    if (result != DBNull.Value)
                    {
                        maxReviewID = Convert.ToInt32(result);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving max UserID: " + ex.Message);
            }

            return maxReviewID;
        }

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
