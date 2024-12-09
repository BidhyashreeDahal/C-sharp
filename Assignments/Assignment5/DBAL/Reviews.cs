using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5;

namespace DBAL
{
    internal class Reviews
    {
        public static List<Reviews> reviews = new List<Reviews>();
        public static string connectionString = Tools.GetConnectionString();
        public int ReviewID {  get; set; }
        public int GameID {  get; set; }
        
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText {  get; set; }
        public DateTime ReviewDate { get; set; }

        public Reviews() { }
        public Reviews(int reviewID, int gameID, int reviewerID, int rating, string reviewText,DateTime reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }
        public static List<Reviews> FillReviews(int gameID)
        {
            List<Reviews> reviews = new List<Reviews>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT ReviewID, GameID, ReviewerID, Rating, ReviewText, ReviewDate FROM Reviews WHERE GameID = @gameID", connection))
                    {
                        cmd.Parameters.AddWithValue("@gameID", gameID);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Reviews r = new Reviews
                                {
                                    ReviewID = reader["ReviewID"] != DBNull.Value ? (int)reader["ReviewID"] : 0,
                                    GameID = reader["GameID"] != DBNull.Value ? (int)reader["GameID"] : 0,
                                    ReviewerID = reader["ReviewerID"] != DBNull.Value ? (int)reader["ReviewerID"] : 0,
                                    Rating = reader["Rating"] != DBNull.Value ? (int)reader["Rating"] : 0,
                                    ReviewText = reader["ReviewText"] != DBNull.Value ? reader["ReviewText"].ToString() : string.Empty,
                                    ReviewDate = reader["ReviewDate"] != DBNull.Value ? (DateTime)reader["ReviewDate"] : DateTime.MinValue
                                };
                                reviews.Add(r);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading reviews: {ex.Message}", ex);
            }

            return reviews;
        }

        public static Reviews GetReviewByID(int reviewID)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select ReviewID, GameID, ReviewerID, Rating, ReviewText, ReviewDate From Reviews WHERE ReviewID = @reviewID", connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@reviewID", reviewID);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Reviews r = new Reviews();
                    {
                        r.ReviewID = (int)reader["ReviewID"];
                        r.GameID = (int)reader["GameID"];
                        r.ReviewerID = (int)reader["ReviewerID"];
                        r.Rating = (int)reader["Rating"];
                        r.ReviewText = (string)reader["ReviewText"];
                        r.ReviewDate = (DateTime)reader["DateTime"];
                    };return r;
                    

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); };
        }
        public bool UpdateReviews()
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spUpdateReview", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
                cmd.Parameters.AddWithValue("@GameID",GameID);
                cmd.Parameters.AddWithValue("@ReviewerID",ReviewerID);
                cmd.Parameters.AddWithValue("@Rating",Rating);
                cmd.Parameters.AddWithValue("ReviewText", ReviewText);
                cmd.Parameters.AddWithValue("ReviewDate", ReviewDate);
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
        public static bool insertReviews(Reviews review)
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spInsertNewReview", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GameID", review.GameID);
                cmd.Parameters.AddWithValue("@UserID", review.ReviewerID);
                cmd.Parameters.AddWithValue("@Rating", review.Rating);
                cmd.Parameters.AddWithValue("@ReviewText", review.ReviewText);
                cmd.Parameters.AddWithValue("@ReviewDate", review.ReviewDate.Date);
               
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccessful;
        }


        public static bool deleteReviews(int ReviewID)
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spDeleteReview", connection);
                cmd.Parameters.AddWithValue("@ReviewID", ReviewID);
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
