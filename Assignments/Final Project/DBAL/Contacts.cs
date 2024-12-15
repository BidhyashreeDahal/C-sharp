/*
 * Bidhyashree Dahal 
 * 100952513
 * 2024-12-10
 * Instantiable class contact that contains the 
 * properties of the contact Table and methods 
 * like instet, update and delete contact.
 * 
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Data.Common;
namespace Final_Project.DBAL
{
    /// <summary>
    /// Public Class Contact
    /// </summary>
    public class Contact
    {

        #region Properties
        public static List<Contact> contacts = new List<Contact>();
        public int ContactID { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion
        #region Constructors

        /// <summary>
        /// Default Constructor 
        /// </summary>
        public Contact() { }
        /// <summary>
        /// Paramaterized Constructor of the contact class 
        /// </summary>
        /// <param name="contactID">The unique identifier of the contact.</param>
        /// <param name="userID">User associated with it either 1 or 2. 1 is adimn and 2 is regular user</param>
        /// <param name="fullName">The full name of the contact</param>
        /// <param name="phoneNumber">The phone number of the contact</param>
        /// <param name="email">The email address of the contact.</param>
        /// <param name="address">The physical address of the contact.</param>
        /// <param name="createdAt">The date and time when the contact was created.</param>
        /// <param name="updatedAt">The date and time when the contact was last updated.</param>
        public Contact(int contactID, int userID, string fullName, string phoneNumber, string email, string address, DateTime createdAt, DateTime updatedAt)
        {
            ContactID = contactID;
            UserID = userID;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion
        #region Methods

        /*
         * Generated method: Retrieves all contacts from the database.
         * Changed to return a List<Contact> and added exception handling.
         */

        /// <summary>
        /// Retrieves all contacts from the database.
        /// </summary>
        /// <returns>A list of Contact objects populated with data from the Contacts table in the database.</returns>
        public static List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                SqlConnection connection = new SqlConnection(Tools.GetConnectionString()); // Removed using statements
                SqlCommand cmd;
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM Contacts", connection);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact();
                    contact.ContactID = (int)reader["ContactID"];
                    contact.FullName = (string)reader["FullName"];
                    contact.PhoneNumber = (string)reader["PhoneNumber"];
                    contact.Email = (string)reader["Email"];
                    contact.Address = (string)reader["Address"];
                    contact.UserID = (int)reader["UserID"];
                    contact.CreatedAt = (DateTime)reader["CreatedAt"];// Added Created At
                    contact.UpdatedAt = (DateTime)reader["UpdatedAt"]; // Added Updated At
                    contacts.Add(contact);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("An error occurred while retrieving contacts: " + ex.Message);
            }

            return contacts;
        }


          /*
           * Generated method: Inserts a new contact into the Contacts table.
           * Changed to boolean return, simplified, and added exception handling.
           */
        /// <summary>
        /// Inserts a new contact into the Contacts table in the database.
        /// </summary>
        /// <param name="contact">A Contact object containing the details of the contact to be inserted.</param>
        /// <returns><c>true</c> if the contact is successfully inserted into the database; 
        /// otherwise, returns <c>false</c></returns>
        /// <exception cref="Exception">Thrown when an error occurs while attempting to insert the contact.</exception>
        public static bool InsertContacts(Contact contact)
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection connection = new SqlConnection(Tools.GetConnectionString());
                // Removed using statemnts
                string query = @"
                INSERT INTO Contacts (UserID, FullName, PhoneNumber, Email, Address, CreatedAt, UpdatedAt)
                VALUES (@UserID, @FullName, @PhoneNumber, @Email, @Address, GETDATE(), GETDATE());
                SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserID", 1);
                cmd.Parameters.AddWithValue("@FullName", contact.FullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.Parameters.AddWithValue("@Address", contact.Address);
                cmd.Parameters.AddWithValue("@CreatedAt", contact.CreatedAt);
                cmd.Parameters.AddWithValue("@UpdatedAt", contact.UpdatedAt);
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isSuccessful = true;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting the contact: " + ex.Message, ex); // Added 
            }
            return isSuccessful;
        }




        /*
           * Generated method: Updates an existing contact in the database.
           * Changed to return boolean, simplified removing using statements,added exception handling, 
           * changed the parameter to revieve contacts
           */

        /// <summary>
        /// Updates an existing contact in the database with the provided details.
        /// </summary>
        /// <param name="contact">A Contact object containing the updated details of the contact.</param>
        /// <returns>Returns <c>true</c> if the contact is successfully updated; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">Throw when any error occurs</exception>
        /// 
        public static bool UpdateContact(Contact contact)
        {
            bool isSuccessful = false;
            try
            {
               SqlConnection connection = new SqlConnection(Tools.GetConnectionString());
                string query = @"
                UPDATE Contacts 
                SET FullName = @FullName, 
                    PhoneNumber = @PhoneNumber, 
                    Email = @Email, 
                    Address = @Address, 
                    UpdatedAt = GETDATE()
                WHERE ContactID = @ContactID";
                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ContactID", contact.ContactID);
                cmd.Parameters.AddWithValue("@FullName", contact.FullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.Parameters.AddWithValue("@Address", contact.Address);
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                connection.Close();
                return isSuccessful;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the contact: " + ex.Message, ex);
            }

        }
        /*
         * Generated Method :: Simplified the method by removing the unnecessary using statements, made the method boolean
         * Added exception Handling
         */
        /// <summary>
        ///Deletes a contact from the database by its ContactID.
        /// </summary>
        /// <param name="contactID">The ID of the contact to be deleted.</param>
        /// <returns>
        /// Returns <c>true</c> if the contact is successfully deleted; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="Exception">Thrown when any other error occurs.</exception>
        public static bool DeleteContact(int contactID)
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(Tools.GetConnectionString());
                string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ContactID", contactID);
                cmd.CommandType = CommandType.Text;
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                connection.Close();
                return isSuccessful;
            }
            catch(Exception ex) {
                throw new Exception("An error occurred while deleting the contact: " + ex.Message);
            }
            
        }
        /// <summary>
        /// Retrieves a contact from the database by its ContactID.
        /// </summary>
        /// <param name="contactID">The ID of the contact to retrieve.</param>
        /// <returns>
        /// A <see cref="Contact"/> object representing the contact if found; otherwise, throws an exception.
        /// </returns>
        /// <exception cref="Exception">Thrown when no contact is found or any other error occurs.</exception>
        public static Contact GetContactByID(int contactID)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Tools.GetConnectionString());
                string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ContactID", contactID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Contact
                    {
                        ContactID = Convert.ToInt32(reader["ContactID"]),
                        FullName = reader["FullName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Address = reader["Address"].ToString(),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                        UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
                    };
                }
                else
                {
                    throw new Exception("Contact not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the contact: " + ex.Message, ex);
            }
        }
        #endregion
    }


}
