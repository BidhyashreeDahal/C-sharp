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
using Final_Project;

using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Final_Project.DBAL
{
   
    internal class Tools
    {
        // <summary>
        /// Retrieves the connection string from the configuration.
        /// </summary>
        /// <returns>Connection string for the database.</returns>
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
        }
        // <summary>
        /// Validates the passkey to ensure it is a 4-digit numeric value.
        /// </summary>
        /// <param name="passkey">The passkey to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>

        /// Validates the first name to ensure it contains only letters and is up to 50 characters long.
        /// </summary>
        /// <param name="firstName">The first name to be validated.</param>
        /// <returns>True if valid, otherwise false.</returns>
        //------ Coundn't include space before 
        public static bool IsValidFullName(string fullName)
        {
            if (Regex.IsMatch(fullName, @"^[A-Za-z]+([ ][A-Za-z]+)*$") && fullName.Length <= 50)
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
                    string query = "SELECT COUNT(*) FROM Contacts WHERE Email = @Email";
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
        
        // <summary>
        /// Checks if a review already exists for a specific game and user.
        /// </summary>
        /// <param name="gameId">The GameID to check.</param>
        /// <param name="userId">The UserID to check.</param>
        /// <returns>True if the review exists, otherwise false.</returns>

        
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression to match valid phone numbers
            string pattern = @"^\+?[1-9]\d{1,14}$"; // E.164 international format (e.g., +123456789)
                                                    // OR
                                                    // string pattern = @"^\d{10}$"; // Simple 10-digit format (e.g., 1234567890)

            return Regex.IsMatch(phoneNumber, pattern);
        }
    }

}
