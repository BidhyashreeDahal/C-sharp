/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-10
 * Static class that provide the necessary element for the program
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
    public static class Tools
    {
        /// <summary>
        /// Retrieves the connection string from the configuration.
        /// </summary>
        /// <returns>Connection string for the database.</returns>
        public static string GetConnectionString()
        {
            try
            {
                return ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving the connection string.", ex);
            }
        }
        /* Genreated Method ::: Added fulllength.Length <= 50
         */
        /// <summary>
        /// Validates whether a given full name meets the required format and length constraints.
        /// </summary>
        /// <param name="fullName">The full name to validate. It should contain only alphabetic characters and spaces, with a maximum length of 50 characters.</param>
        /// <returns>
        /// <c>true</c> if the full name is valid (only contains letters and spaces, does not start or end with spaces, and is no longer than 50 characters); 
        /// otherwise, <c>false</c>.
        /// </returns>
        public static bool IsValidFullName(string fullName)
        {
            try
            {
                return Regex.IsMatch(fullName, @"^[A-Za-z]+([ ][A-Za-z]+)*$") && fullName.Length <= 50;
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating the full name.", ex);
            }
        }      
        /*
         * Generated Method
         */
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
                    SqlConnection connection = new SqlConnection(GetConnectionString());     
                    string query = "SELECT COUNT(*) FROM Contacts WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; 
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /*
         * Generated Method 
         */
        /// <summary>
        /// Checks if the phonenumber is valid or not
        /// </summary>
        /// <param name="phoneNumber">Takes the Phone number of the </param>
        /// <returns>/// <c>true</c> if the phone number is valid according to the international phone number format; 
        /// otherwise, <c>false</c>.</returns>
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            try
            {
                string pattern = @"^\+?[1-9]\d{1,14}$";
                return Regex.IsMatch(phoneNumber, pattern);
            }
            catch (Exception ex)
            {
                throw new Exception("Error validating the phone number.", ex);
            }
        }
        /*
         * Prompt ::: Generate the method that check's if the phone number exist or not
         * Generated Method :: Removed unnecessary using statements and simplified the method
         */

        /// <summary>
        /// Checks if the provided phone number already exists in the database.
        /// </summary>
        /// <param name="phoneNumber">The phone number to check.</param>
        /// <returns>True if the phone number exists, otherwise false.</returns>
        public static bool PhoneNumberExists(string phoneNumber)
        {
            try
            {
                SqlConnection connection = new SqlConnection(GetConnectionString());
                string query = "SELECT COUNT(*) FROM Contacts WHERE PhoneNumber = @PhoneNumber";
                SqlCommand cmd = new SqlCommand(query, connection);       
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;      
                
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while checking phone number existence.", ex);
            }
        }
    }
}
    


