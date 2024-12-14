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
    public class Contact
    {
        public static List<Contact> contacts = new List<Contact>();

        public int ContactID { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Constructor
        public Contact() { }

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
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
        }

        // Method to map data from a SqlDataReader to Contact object
        public static Contact FromDataRow(DataRow row)
        {
            return new Contact
            {
                ContactID = Convert.ToInt32(row["ContactID"]),
                UserID = Convert.ToInt32(row["UserID"]),
                FullName = row["FullName"].ToString(),
                PhoneNumber = row["PhoneNumber"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString(),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                UpdatedAt = Convert.ToDateTime(row["UpdatedAt"])
            };
        }

        // Edited To Make it more simplified
        // Method had using statements every removed it because it is not necesary here
        public static List<Contact> GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
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
            return contacts;
        }


        // Method to insert a new contacts
        // Maade the method boolean so that it can return true or false
        // Used try Catch
        // Removed using statents
        public static bool InsertContacts(Contact contact)
        {
            bool isSuccessful = false;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
                string query = @"
                INSERT INTO Contacts (UserID, FullName, PhoneNumber, Email, Address, CreatedAt, UpdatedAt)
                VALUES (@UserID, @FullName, @PhoneNumber, @Email, @Address, GETDATE(), GETDATE());
                SELECT SCOPE_IDENTITY();";
                SqlConnection connection = new SqlConnection(connectionString);
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
                throw new Exception(ex.Message);
            }
            return isSuccessful;
        }


        // Method to update a contact
        // Give me the update Contact Method that updates the contacts-------------Prompt
        // Was using Using Statement
        // Connection was given as the parameter  [[Changes the parameter to Contact contact]]
        public static bool UpdateContact(Contact contact)
        {
            bool isSuccessful = false;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
                string query = @"
                UPDATE Contacts 
                SET FullName = @FullName, 
                    PhoneNumber = @PhoneNumber, 
                    Email = @Email, 
                    Address = @Address, 
                    UpdatedAt = GETDATE()
                WHERE ContactID = @ContactID";
                SqlConnection connection = new SqlConnection(connectionString);
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
                throw new Exception(ex.Message);
            }

        }

        // Method to delete a contact
        public static bool DeleteContact(int contactID)
        {
            bool isSuccessful = false;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
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
                throw new Exception(ex.Message);
            }
            
        }
        public static List <Contact> FillContact(int contactID)
        {
            List<Contact> contacts = new List<Contact>();
            
            SqlConnection connection = null;
            string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;
            try
            {
                // Create a new SqlConnection
                connection = new SqlConnection(connectionString);

                // Open the connection
                connection.Open();

                // Create the command
                SqlCommand cmd = new SqlCommand("SELECT ContactID, FullName, PhoneNumber, Email, Address, UserID, CreatedAt, UpdatedAt " +
                                                "FROM Contacts WHERE ContactID = @ContactID", connection);
                // Add parameter to the command
                cmd.Parameters.AddWithValue("@ContactID", contactID);

                // Execute the reader
                SqlDataReader reader = cmd.ExecuteReader();

                // Check if we have a record
                if (reader.Read())
                {
                    Contact c = new Contact();


                    c.FullName = reader["FullName"] != DBNull.Value ? reader["FullName"].ToString() : string.Empty;
                    c.PhoneNumber = reader["PhoneNumber"] != DBNull.Value ? reader["PhoneNumber"].ToString() : string.Empty;
                    c.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                    c.Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
                    c.UserID = reader["UserID"] != DBNull.Value ? (int)reader["UserID"] : 0;
                    c.CreatedAt = reader["CreatedAt"] != DBNull.Value ? (DateTime)reader["CreatedAt"] : DateTime.MinValue;
                    c.UpdatedAt = reader["UpdatedAt"] != DBNull.Value ? (DateTime)reader["UpdatedAt"] : DateTime.MinValue;
                        contacts.Add(c);
                    
                }

                // Close the reader
                reader.Close();

            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw new Exception($"Error loading contact: {ex.Message}", ex);
            }
            finally
            {
                // Ensure the connection is closed
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return contacts;
        }


        public static Contact GetContactByID(int contactID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ContactManager"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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
        }
    }

}
