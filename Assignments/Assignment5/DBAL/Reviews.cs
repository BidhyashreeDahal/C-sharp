/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-6
 * Class that provides the properties and methods of the reviews 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Assignment5;

namespace DBAL
{
    /// <summary>
    /// Internal Class Reviews
    /// </summary>
    internal class Reviews
    {
        // List of reviews
        public static List<Reviews> reviews = new List<Reviews>();
        public static string connectionString = Tools.GetConnectionString();
        // Properties of Reviews 
        public int ReviewID {  get; set; }
        public int GameID {  get; set; }
        
        public int ReviewerID { get; set; }
        public int Rating { get; set; }
        public string ReviewText {  get; set; }
        public DateTime ReviewDate { get; set; }

        public Reviews() { }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="reviewID"></param>
        /// <param name="gameID"></param>
        /// <param name="reviewerID"></param>
        /// <param name="rating"></param>
        /// <param name="reviewText"></param>
        /// <param name="reviewDate"></param>
        public Reviews(int reviewID, int gameID, int reviewerID, int rating, string reviewText,DateTime reviewDate)
        {
            ReviewID = reviewID;
            GameID = gameID;
            ReviewerID = reviewerID;
            Rating = rating;
            ReviewText = reviewText;
            ReviewDate = reviewDate;
        }
        /// <summary>
        /// Fills the list of reviews for a given game ID.
        /// </summary>
        /// <param name="gameID">The GameID for which reviews are to be fetched.</param>
        /// <returns>A list of reviews.</returns>
        public static List<Reviews> FillReviews(int gameID)
        {
            List<Reviews> reviews = new List<Reviews>();

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("SELECT ReviewID, GameID, ReviewerID, Rating, ReviewText, ReviewDate FROM Reviews WHERE GameID = @gameID", connection);
                    
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
            catch (Exception ex)
            {
                throw new Exception($"Error loading reviews: {ex.Message}", ex);
            }

            return reviews;
        }
        /// <summary>
        /// Retrieves a review by its ID.
        /// </summary>
        /// <param name="reviewID">The ID of the review to retrieve.</param>
        /// <returns>A review object if found, otherwise null.</returns>
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
        /// <summary>
        /// Updates an existing review in the database.
        /// </summary>
        /// <param name="review">The review object with updated values.</param>
        /// <returns>True if the update is successful, otherwise false.</returns>
        public static bool UpdateReviews(Reviews review)
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spUpdateReview", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReviewID", review.ReviewID);
                cmd.Parameters.AddWithValue("@GameID",review.GameID);
                cmd.Parameters.AddWithValue("@ReviewerID",review.ReviewerID);
                cmd.Parameters.AddWithValue("@Rating",review.Rating);
                cmd.Parameters.AddWithValue("ReviewText", review.ReviewText);
                cmd.Parameters.AddWithValue("ReviewDate", review.ReviewDate);
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
        /// Inserts a new review into the database.
        /// </summary>
        /// <param name="review">The review object to be inserted.</param>
        /// <returns>True if the insertion is successful, otherwise false.</returns>
        public static bool InsertReview(Reviews review)
        {
            bool isSuccessful = false;
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spInsertNewReview", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter reviewIdParam = new SqlParameter("@ReviewID", SqlDbType.Int);
                reviewIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(reviewIdParam);

                cmd.Parameters.AddWithValue("@GameID", review.GameID);
                cmd.Parameters.AddWithValue("@UserID", review.ReviewerID);
                cmd.Parameters.AddWithValue("@Rating", review.Rating);
                cmd.Parameters.AddWithValue("@ReviewText", review.ReviewText);
                cmd.Parameters.AddWithValue("@ReviewDate", review.ReviewDate.Date);

                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    review.ReviewID = (int)cmd.Parameters["@ReviewID"].Value;
                    isSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccessful;
        }
        /// <summary>
        /// Deletes a review from the database based on its ID.
        /// </summary>
        /// <param name="reviewID">The ID of the review to be deleted.</param>
        /// <returns>True if deletion is successful, otherwise false.</returns>
        public static bool deleteReviews(int ReviewID)
        {
            bool isSuccessful = false;
            try
            {

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("spDeleteReview", connection);
                cmd.Parameters.Add(new SqlParameter("@ReviewID", SqlDbType.Int) { Value = ReviewID });
                cmd.CommandType = CommandType.StoredProcedure;  
                
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
