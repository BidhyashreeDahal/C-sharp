using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5;
using Assignment5.Properties;

namespace DBAL
{
    public class User
    {
        public static List<User> users = new List<User>();
        public static string connectionString = Tools.GetConnectionString();

        // Properties of the Users
      
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passkey { get; set; }

        // Default Constructor
        public User() { }

        // Parameterized Constructor
        public User(int userID, string firstName, string lastName, string email, string passkey)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Passkey = passkey;
        }

        public static void PopulateUser()
        {
            try
            {
               
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd;
                conn.Open();
                cmd = new SqlCommand("Select * From Users");
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User();
                    u.UserID = (int)reader["UserID"];
                    u.FirstName = reader["FirstName"].ToString();
                    u.LastName = reader["LastName"].ToString();
                    u.Email = reader["Email"].ToString();
                    u.Passkey = (string)reader["Password"];
                    users.Add(u);


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public static User ReturnSingleUser(int userID)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select UserID, FirstName, LastName, Email, PassKey From Users Where UserID = @UserID", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User u = new User
                    {
                        UserID = (int)reader["UserID"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Passkey = (string)reader["Password"]
                    };
                    return u;

                }
                else
                {
                    return null;
                }
                


            }
            catch (Exception ex) { throw new Exception(ex.Message); };    
        }

        public bool UpdateUser()
        {
            bool isSuccessful = false;
            try
            {
              
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spUpdateUser",connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", UserID);
                cmd.Parameters.AddWithValue("@firstName",FirstName);
                cmd.Parameters.AddWithValue("@lastName" ,LastName);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@PassKey", Passkey);
                

                connection.Open();
                if(cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                };
                connection.Close();
                return isSuccessful;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool insertUser(User user)
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spInsertNewUser", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", user.UserID);
                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@PassKey", user.Passkey);
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
                throw new Exception (ex.Message + "Sorry");
            }
             
        }

        public static bool deleteUser(int UserID) { 
            bool isSuccessful = false;
            try
            {
               
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spDeleteUser", connection);
                cmd.Parameters.AddWithValue("@userID", UserID);
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                }
                connection.Close();
                return isSuccessful;
            }
            catch (Exception ex) 
            {
                throw new Exception (ex.Message);
            }
        }
        public static User GetUser(string Email,string PassKey)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select UserID, FirstName, LastName, Email, PassKey " +
                                            "From Users Where Email = @email and PassKey = @passKey",connection);
            cmd.Parameters.AddWithValue ("@email", Email);
            cmd.Parameters.AddWithValue("@passKey", PassKey);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                User u = new User
                {
                    UserID = (int)reader["UserID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Passkey = reader["PassKey"].ToString(),
                }; 
                return u;

            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"{FirstName}{LastName}({Email})";
        }


    }
}
