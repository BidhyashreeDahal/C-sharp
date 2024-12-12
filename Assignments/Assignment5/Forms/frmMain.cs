/// <summary>
/// Bidhyashree Dahal
/// 100952513
/// 2024-12-06
/// Main form that displays and manages game reviews.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment5.Properties;
using DBAL;

namespace Assignment5
{
    public partial class frmMain : Form
    {
        private User currentUser;  // The currently logged-in user
        public static string connectionString = Tools.GetConnectionString();
        /// <summary>
        /// Initializes a new instance of the frmMain class.
        /// </summary>
        /// <param name="user">The currently logged-in user.</param>
        public frmMain(User user)
        {
            currentUser = user;
            InitializeComponent();
            InitializeForm();
        }
        /// <summary>
        /// Handles the form load event.
        /// Sets up the grid views and other form properties.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvReviews.RowHeadersVisible = false;
            dvgGames.RowHeadersVisible = false;
            dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        /// <summary>
        /// Initializes the main form with necessary settings.
        /// </summary>

        private void InitializeForm()
        {
            this.Text = "Video Game Reviews";
            this.StartPosition = FormStartPosition.CenterScreen;
            toolStripStatusLabel1.Text = $"Logged in as: {currentUser.ToString()}";
            LoadGames();
        }
        /// <summary>
        /// Loads the games from the database and binds them to the data grid view.
        /// </summary>
        private void LoadGames()
        {
            try
            {
                List<Games> games = Games.FillGames();
                dvgGames.DataSource = games;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading games: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Loads the reviews for the selected game and binds them to the data grid view.
        /// </summary>
        /// <param name="gameID">The ID of the selected game.</param>
        private void LoadReviews(int gameID)
        {
            try
            {
                List<Reviews> reviews = Reviews.FillReviews(gameID);
                dgvReviews.DataSource = reviews;
                dgvReviews.ClearSelection();
                textReview.Text = string.Empty;
                nudRating.Value = nudRating.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the selection change event for the games data grid view.
        /// Loads the reviews for the selected game.
        /// </summary>
        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgGames.CurrentRow != null && dvgGames.CurrentRow.Cells["GameID"] != null)
            {
                int gameId = Convert.ToInt32(dvgGames.CurrentRow.Cells["GameID"].Value);
                dvgGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
                LoadReviews(gameId);
            }
        }
        /// <summary>
        /// Handles the click event of the Add Review button.
        /// Adds a review for the selected game.
        /// </summary>
        private void btnAddReview_Click(object sender, EventArgs e)
        {

            int gameId = Convert.ToInt32(dvgGames.CurrentRow.Cells["GameID"].Value);

            string reviewText = textReview.Text.Trim();

            if (string.IsNullOrEmpty(reviewText))
            {
                MessageBox.Show("Review text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Tools.CheckIfReviewExists(gameId, currentUser.UserID))
            {
                MessageBox.Show("You have already reviewed this game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                var review = new Reviews
                {

                    GameID = gameId,
                    ReviewerID = Settings.Default.CurrentUserID,
                    ReviewText = reviewText,
                    Rating = (int)nudRating.Value,
                    ReviewDate = DateTime.Now
                };
                Reviews.InsertReview(review);
                LoadReviews(review.GameID);
                MessageBox.Show("Review added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReviews.FirstDisplayedScrollingRowIndex = dgvReviews.RowCount - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the value changed event of the rating control.
        /// Ensures the rating value is between 0 and 10.
        /// </summary>
        private void nudRating_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(nudRating.Value.ToString(), out decimal ratingValue))
            {
                if (ratingValue > 10 || ratingValue < 0)
                {
                    throw new ArgumentException("The nudRating value must be between 0 and 10.");
                }
            }
            else
            {
               
                throw new ArgumentException("The nudRating value must be a number between 0 and 10.");
            }
        }
        /// <summary>
        /// Handles the selection change event of the reviews data grid view.
        /// Loads the selected review into the text box and rating control.
        /// </summary>
        private void dgvReviews_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReviews.CurrentRow == null) return;
            dgvReviews.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var selectedReview = dgvReviews.CurrentRow.DataBoundItem as Reviews;
            if (selectedReview == null) return;
            textReview.Text = selectedReview.ReviewText;
            nudRating.Value = selectedReview.Rating;
        }
        /// <summary>
        /// Handles the click event of the Edit Review button.
        /// Updates the selected review with new data.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReviews.CurrentRow == null)
            {
                MessageBox.Show("Please select a review to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedReview = dgvReviews.CurrentRow.DataBoundItem as Reviews;
            

            if (selectedReview.ReviewerID != currentUser.UserID)
            {
                MessageBox.Show("You can only edit your own reviews.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textReview.Text))
            {
                MessageBox.Show("Review text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedReview.ReviewText = textReview.Text.Trim();
            selectedReview.Rating = (int)nudRating.Value;

            try
            {
                if (Reviews.UpdateReviews(selectedReview)) 
                {
                    MessageBox.Show("Review updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReviews(selectedReview.GameID); 
                }
                else
                {
                    MessageBox.Show("Failed to update the review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the click event of the Delete Review button.
        /// Deletes the selected review.
        /// </summary>
        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
             if (dgvReviews.CurrentRow == null || dgvReviews.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a review to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedReview = dgvReviews.CurrentRow.DataBoundItem as Reviews;
            if (selectedReview == null)
            {
                MessageBox.Show("Error retrieving the selected review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedReview.ReviewerID != currentUser.UserID)
            {
                MessageBox.Show("You can only delete your own reviews.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this review?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = Reviews.deleteReviews(selectedReview.ReviewID); 
                    if (isDeleted)
                    {
                        MessageBox.Show("Review deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int gameId = Convert.ToInt32(dvgGames.CurrentRow.Cells["GameID"].Value);
                        LoadReviews(gameId);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Event handler for logging out the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.deleteUser(currentUser.UserID);
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}
