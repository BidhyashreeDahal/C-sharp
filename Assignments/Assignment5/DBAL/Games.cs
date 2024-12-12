/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-6
 * Class that provides the properties and methods of the Game
 */

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
    /// <summary>
    /// Internal Class Games
    /// </summary>
    internal class Games
    {

        public static string connectionString = Tools.GetConnectionString();
        public static List<Games> Game = new List<Games> ();
        // // Properties of the Game class
        public int GameID {  get; set; }
        public string Title {  get; set; }
        public string Genre {  get; set; }
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Games() { }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="gameID"></param>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="releaseDate"></param>
       public Games(int gameID, string title, string genre, DateTime releaseDate)
       {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseDate = releaseDate;
       }
        /// <summary>
        /// Fills the list of games by retrieving all records from the Games table.
        /// </summary>
        /// <returns>A list of games.</returns>
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
        // <summary>
        /// Retrieves a game by its ID.
        /// </summary>
        /// <param name="gameID">The ID of the game to retrieve.</param>
        /// <returns>A game object if found, otherwise null.</returns>
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
        /// <summary>
        /// Updates the details of a game.
        /// </summary>
        /// <returns>True if the update was successful, otherwise false.</returns>
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
        /// <summary>
        /// Inserts a new game into the database.
        /// </summary>
        /// <returns>True if the insertion was successful, otherwise false.</returns>
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
        /// <summary>
        /// Deletes a game from the database by its ID.
        /// </summary>
        /// <param name="gameID">The ID of the game to delete.</param>
        /// <returns>True if the deletion was successful, otherwise false.</returns>
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
