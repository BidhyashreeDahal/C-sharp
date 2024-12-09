using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment5;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBAL
{
    internal class Games
    {
        public static string connectionString = Tools.GetConnectionString();
        public static List<Games> Game = new List<Games> ();
        public int GameID {  get; set; }
        public string Title {  get; set; }
        public string Genre {  get; set; }
        public DateTime ReleaseDate { get; set; }
        public Games() { }

       public Games(int gameID, string title, string genre, DateTime releaseDate)
       {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
       }
       public static List<Games>  FillGames()
       {
           
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd;
                connection.Open();
                cmd = new SqlCommand("Select GameID,Title,Genre,ReleaseDate From Games", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Games g = new Games();
                    g.GameID = (int)reader["GameID"];
                    g.Title = (string)reader["Title"];
                    g.Genre = (string)reader["Genre"];
                    g.ReleaseDate = (DateTime)reader["ReleaseDate"];
                    Game.Add(g);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return Game;

       }
        public static Games GetGameByID(int gameID)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select GameID,Title,Genre,ReleaseDate From Games Where GameID = @gameID", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@gameID", gameID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Games g = new Games
                    {
                        GameID = (int)reader["GameID"],
                        Title = reader["Title"].ToString(),
                        Genre = reader["Genre"].ToString(),
                        ReleaseDate =(DateTime) reader["ReleaseDate"]
                       
                    };
                    return g;

                }
                else
                {
                    return null;
                }
            }catch (Exception ex) { throw new Exception(ex.Message); };
        }
        public bool UpdateGames()
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spUpdateGame", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
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
        public bool insertGames()
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spInsertNewGame", connection);
                cmd.Parameters.AddWithValue("@GameID", GameID);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Genre", Genre);
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
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

        public static bool deleteGames(int GameID)
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spDeleteGame", connection);
                cmd.Parameters.AddWithValue("@GameID", GameID);
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
                throw new Exception(ex.Message);
            }
        }
    }   
}
