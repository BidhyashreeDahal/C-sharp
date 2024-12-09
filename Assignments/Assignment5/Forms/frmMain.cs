using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAL;

namespace Assignment5
{
    public partial class frmMain : Form
    {
        private User currentUser;
        public static string connectionString = Tools.GetConnectionString();

        public frmMain(User loggedInUser)
        {
            InitializeComponent();
            currentUser = loggedInUser;
            InitializeForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvReviews.RowHeadersVisible = false;
            dvgGames.RowHeadersVisible = false;
            dgvReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvgGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void InitializeForm()
        {
            this.Text = "Video Game Reviews";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display current user in the status strip
            toolStripStatusLabel1.Text = $"Logged in as: {currentUser.ToString()}";

            // Load games and reviews
            LoadGames();
        }

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
        private void LoadReviews(int gameID)
        {
            try
            {
                List<Reviews> reviews = Reviews.FillReviews(gameID);
                dgvReviews.DataSource = reviews;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reviews: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgGames.CurrentRow != null && dvgGames.CurrentRow.Cells["GameID"] != null)
            {
                int gameId = Convert.ToInt32(dvgGames.CurrentRow.Cells["GameID"].Value);
                dvgGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
                dgvReviews.SelectionMode = DataGridViewSelectionMode.CellSelect;
                LoadReviews(gameId);
            }
        }

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
                        ReviewerID = currentUser.UserID,
                        ReviewText = reviewText,
                        Rating = (int)nudRating.Value,
                        ReviewDate = DateTime.Now
                    };

                    // Step 3: Insert the review into the database
                    if (Reviews.insertReviews(review))
                    {
                        LoadReviews(gameId);
                        textReview.Clear();
                        MessageBox.Show("Review added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add review.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding review: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        


    }
    
}
