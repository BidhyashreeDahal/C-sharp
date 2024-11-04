/*
 * Title:PartialBS.cs
 * Name: Bidhyashree Dahal
 * 100952513
 * Form.cs that handles the User Interface of battleship game.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_2_BattelmanShip.BS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_2_BattelmanShip
{
    public partial class BattelShip : Form
    {
        public BattelShip()
        {
            InitializeComponent();
            
        }
        #region Initialization
        /// <summary>
        /// Initializes the game board by setting up a 10x10 grid, configuring column and row sizes, 
        /// and disabling user interactions like adding or resizing rows/columns.
        /// </summary>
        private void Initialized_Board()
        {
            // Setting the DataGridView to be 10x10
            dgv1.RowCount = BS.MAX_BOARD_SIZE +1 ;
            dgv1.ColumnCount = BS.MAX_BOARD_SIZE +1;

            // setting the size for each column and column to make it look like a grid
            foreach (DataGridViewColumn col in dgv1.Columns)
            {
                col.Width = 35; 
            }

            foreach (DataGridViewRow row in dgv1.Rows)
            {
                row.Height = 33; 
            }
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
            dgv1.RowHeadersVisible = false;
            dgv1.ColumnHeadersVisible = false;
        }

        /// <summary>
        /// Initializes combo boxes for selecting X and Y coordinates, populating them with numbers 1-10.
        /// </summary>
        private void InitializedComboBoxes()
        {
            comboBoxX.Items.AddRange(Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray());
            comboBoxY.Items.AddRange(Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray());
        }

        /// <summary>
        /// Sets up DataGridView cells with initial styles and values for the game grid.
        /// </summary>
        private void InitializeDataGridViews()
        {
           
                dgv1.ColumnCount = BS.MAX_BOARD_SIZE+1 ; 
                dgv1.RowCount = BS.MAX_BOARD_SIZE+1 ;    

                for (int i = 0; i < BS.MAX_BOARD_SIZE+1; i++)
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE + 1; j++)
                    {
                        // Creating and applying cell style  
                        DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
                        {
                            BackColor = Color.LightBlue,
                            Alignment = DataGridViewContentAlignment.MiddleLeft,
                        };

                        // Ensure the row and column exist before accessing them  
                        dgv1.Rows[i].Cells[j].Style = cellStyle; // Apply style  
                        dgv1.Rows[i].Cells[j].Value = ""; // Set initial cell value  
                    }
                }
        }
        /// <summary>
        /// Loads and initializes game components such as the board, 
        /// random boat placements, and combo boxes when the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BattelShip_Load(object sender, EventArgs e)
        {
            Initialized_Board(); // Set up the grid first
            BS.RandomizeBoats(); // Randomize boat placements
            InitializeDataGridViews(); // Initialize the grid's data and styles
            InitializedComboBoxes(); // Initialize combo boxes or any other UI elements
            dgv1.CellClick += dataGridView1_CellContentClick;
        }
        #endregion

        #region Click Event
        /// <summary>
        /// Handles the 'Attack' button click. Checks selected coordinates, fires a missile, 
        /// and updates the game board and turn labels based on the result (hit or miss).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (comboBoxX.SelectedItem != null && comboBoxY.SelectedItem != null)
            {
                if (int.TryParse(comboBoxX.SelectedItem.ToString(), out int x) &&
                    int.TryParse(comboBoxY.SelectedItem.ToString(), out int y))
                {
                    // Adjust for 0-indexing
                    int adjustedX = x - 1; // Column index
                    int adjustedY = y - 1; // Row index

                    // Check if the adjusted coordinates are valid
                    if (adjustedX >= 0 && adjustedX < BS.MAX_BOARD_SIZE+1&& adjustedY >= 0 && adjustedY < BS.MAX_BOARD_SIZE + 1)
                    {
                        // Fire a missile at the selected coordinates
                        bool hit = BS.FireMissile(adjustedX, adjustedY);
                        UpdateBoardVisuals(dgv1, adjustedX, adjustedY, hit);
                        UpdateTurnTakenLabel();
                        UpdateSunkBoat();
                    }
                    else
                    {
                        MessageBox.Show($"Invalid attack coordinates: x = {adjustedX + 1}, y = {adjustedY + 1}. Please select valid coordinates.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select valid coordinates!");
            }
        }
        /// <summary>
        /// Resets the game when the 'New Game' button is clicked 
        /// by resetting the board and updating labels and progress bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGame_Click_1(object sender, EventArgs e)

        {
            BS.ResetGame();
            InitializeDataGridViews();
            ResetDataGridViews();
            UpdateTurnTakenLabel();
            UpdateProgressBar();
        }
        /// <summary>
        /// Handles cell click events on the grid. If the cell hasn't been attacked yet, 
        /// fires a missile and updates the visuals for hit/miss, turn count, and sunk boats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the grid that was clicked
            DataGridView clickedGrid = sender as DataGridView;//Sender refers to an object that was triggered.


            if (clickedGrid != null && e.RowIndex >= 0 && e.RowIndex < BS.MAX_BOARD_SIZE + 1 &&
                e.ColumnIndex >= 0 && e.ColumnIndex < BS.MAX_BOARD_SIZE+1)
            {
                DataGridViewCell cell = clickedGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int x = e.RowIndex;
                int y = e.ColumnIndex;
                if (BS.board[x, y] == BoardStatus.Hit || BS.board[x, y] == BoardStatus.Miss)
                {
                    return; 
                }
               
                // Fire missile and update the clicked grid
                bool hit = BS.FireMissile(x, y);
                UpdateBoardVisuals(clickedGrid, x, y, hit); 
                UpdateTurnTakenLabel();
                UpdateSunkBoat();
                UpdateProgressBar();
            }
        }
        /// <summary>
        /// Displays the positions of all boats on the grid, coloring cells and setting values 
        /// to indicate the presence of different boats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnShowBoat_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < BS.MAX_BOARD_SIZE + 1; i++)
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE+1; j++)
                    {
                        if (boatPositions[i, j] == Boats.Submarine)// Check if there's a boat
                        {
                            dgv1.Rows[i].Cells[j].Style.BackColor = Color.Purple; // Color for boat
                            dgv1.Rows[i].Cells[j].Value = "S"; // Show 'B' for boat
                        }
                        if(boatPositions[i, j] == Boats.Battleship)
                        {
                            dgv1.Rows[i].Cells[j].Style.BackColor= Color.Yellow;
                            dgv1.Rows[i].Cells[j].Value = "BS";
                        }
                       if (boatPositions[i, j] == Boats.Carrier)
                       {
                           dgv1.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                           dgv1.Rows[i].Cells[j].Value = "Car";
                       }
                       if (boatPositions[i, j] == Boats.Cruiser)
                       {
                           dgv1.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                           dgv1.Rows[i].Cells[j].Value = "Cau";
                       }
                       if(boatPositions[i, j] == Boats.Destroyer){
                           dgv1.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                           dgv1.Rows[i].Cells[j].Value = "D";
                       }
                    }
                }
            }
        /// <summary>
        /// Prompts the user for confirmation before exiting the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Conformation?", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        #endregion

        #region Update Methods
        /// <summary>
        /// Updates the visual appearance of the board based on whether a hit or miss occurred at the specified coordinates.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="hit"></param>
        private void UpdateBoardVisuals(DataGridView grid, int x, int y, bool hit)
        {
            {
                if (x >= 0 && x < BS.MAX_BOARD_SIZE + 1 && y >= 0 && y < BS.MAX_BOARD_SIZE+1) 
                {
                    DataGridViewCell cell = grid.Rows[x].Cells[y]; 
                    cell.Style.BackColor = hit ? Color.Red : Color.Green;
                    cell.Value = hit ? "Hit" : "Miss"; // Update cell value to show Hit or Miss
                }
                else
                {
                    MessageBox.Show("Invalid coordinates for updating board visuals.");
                }
            }
        }
        /// <summary>
        /// Updates the label showing the total number of turns taken (shots fired).
        /// </summary>
        private void UpdateTurnTakenLabel()
        {
            lblTruncount.Text = $" {BS.GetShortsFired()}";
           
        }
        /// <summary>
        ///  Updates the label showing the count of boats that have been sunk.
        /// </summary>
        private void UpdateSunkBoat()
        {
            
            lblSunkBoatCount.Text =$"{BS.GetSunkBoatsCount()}";
        }
        /// <summary>
        /// Updates the progress bar based on the number of boats sunk out of the total boats.
        /// </summary>
        private void UpdateProgressBar()
        {

            // Get the current count of sunk boats
            int sunkBoatsCount = BS.GetSunkBoatsCount();

            // Total number of boats
            int totalBoats = 5;

            // Calculate the progress percentage
            int progressPercentage = (sunkBoatsCount * 100) / totalBoats;

            // Update the progress bar value
            ProgressBarBoats.Value = progressPercentage; // Update the progress bar
        }
        /// <summary>
        /// Resets the appearance of the game grid for a new game.
        /// </summary>
        private void ResetDataGridViews()
        {
            
                for (int i = 0; i < BS.MAX_BOARD_SIZE + 1; i++)
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE+1; j++)
                    {
                        dgv1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue; // Reset color  
                        dgv1.Rows[i].Cells[j].Value = ""; // Reset cell value  
                    }
                }
            
        }

        #endregion
    }
    }

    

