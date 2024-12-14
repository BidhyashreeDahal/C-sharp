using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Classes
{
    internal class Planning
    {
        /*
         * 
         * public static List<Contact> GetAllContacts(SqlConnection connection)
          {
            var contacts = new List<Contact>();
            string query = "SELECT * FROM Contacts";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    Contact contact = new Contact
                    {
                    ContactID = reader.GetInt32(reader.GetOrdinal("ContactID")),
                    FullName = reader.GetString(reader.GetOrdinal("FullName")),
                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address"))
                };

                contacts.Add(contact);
            }
        }
     }

    return contacts;
    }

     

         * 
         *  public static int AddContact(SqlConnection connection, int userID, string fullName, string phoneNumber, string email, string address)
            {
                string query = @"
                INSERT INTO Contacts (UserID, FullName, PhoneNumber, Email, Address, CreatedAt, UpdatedAt)
                VALUES (@UserID, @FullName, @PhoneNumber, @Email, @Address, GETDATE(), GETDATE());
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
         * 
         */






    }
}
