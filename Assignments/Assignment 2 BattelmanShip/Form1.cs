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
        private DataGridView[] dataGrids;
        // Declare an instance of the BS class  

        public BattelShip()
        {
            InitializeComponent();
            // Initialize the BS instance  

            // Initialize your DataGridView array  
        }

        private void Initialized_Board()
        {
            // Set the DataGridView to be 10x10
            dgv1.RowCount = 10;
            dgv1.ColumnCount = 10;

            // Optionally, set the size for each column to make it look like a grid
            foreach (DataGridViewColumn col in dgv1.Columns)
            {
                col.Width = 30; // Adjust the cell size to your liking
            }

            foreach (DataGridViewRow row in dgv1.Rows)
            {
                row.Height = 25; // Adjust the row size as well
            }

            // Set any additional properties, like disabling editing
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToResizeColumns = false;
            dgv1.AllowUserToResizeRows = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Conformation?", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void BattelShip_Load(object sender, EventArgs e)
        {
            BS.DisplayBoard();
            BS.ResetGame();
            BS.RandomizeBoats();
            InitializedComboBoxes();
            Initialized_Board();

            
                dgv1.CellClick += dataGridView1_CellContentClick;
            


        }

        private void InitializedComboBoxes()
        {
            comboBoxX.Items.AddRange(Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray());
            comboBoxY.Items.AddRange(Enumerable.Range(1, 10).Select(i => i.ToString()).ToArray());
        }

        private void InitializeDataGridViews()
        {
           
                dgv1.ColumnCount = BS.MAX_BOARD_SIZE; // Set the number of columns  
                dgv1.RowCount = BS.MAX_BOARD_SIZE;    // Set the number of rows  

                for (int i = 0; i < BS.MAX_BOARD_SIZE; i++)
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE; j++)
                    {
                        // Create and apply cell style  
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

        private void btnAttack_Click(object sender, EventArgs e)
        {
                if (comboBoxX.SelectedItem != null && comboBoxY.SelectedItem != null)
                {
                    if (int.TryParse(comboBoxX.SelectedItem.ToString(), out int x) &&
                        int.TryParse(comboBoxY.SelectedItem.ToString(), out int y))
                    {
                        // Adjust for 0-indexing
                        int adjustedX = x - 1;
                        int adjustedY = y - 1;

                        // Fire a missile at the selected coordinates
                        bool hit = BS.FireMissile(adjustedX, adjustedY);

                        // Call UpdateBoardVisuals and pass the grid you're updating (e.g., dataGridView1)
                        UpdateBoardVisuals(dgv1, adjustedX, adjustedY, hit);

                        // Update the turn label
                        UpdateTurnTakenLabel();
                    }
                }
                else
                {
                    MessageBox.Show("Please select valid coordinates!");
                }
            }

        


        private void UpdateBoardVisuals(DataGridView grid, int x, int y, bool hit)
        {
            // Ensure valid coordinates for updating the grid
            if (x >= 0 && x < BS.MAX_BOARD_SIZE && y >= 0 && y < BS.MAX_BOARD_SIZE)
            {
                // Adjust indices for 0-based DataGridView access
                DataGridViewCell cell = grid.Rows[y].Cells[x]; // Ensure you're using the correct mapping
                cell.Style.BackColor = hit ? Color.Red : Color.White; // Red for hit, White for miss  
                cell.Value = hit ? "Hit" : "Miss"; // Update cell value
            }
            else
            {
                MessageBox.Show("Invalid coordinates for updating board visuals.");
            }
        }

        private void UpdateTurnTakenLabel()
        {
            lblTruncount.Text = $" {BS.GetShortsFired()}";
        }

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

        private void ResetDataGridViews()
        {
            
                for (int i = 0; i < BS.MAX_BOARD_SIZE; i++)
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE; j++)
                    {
                        dgv1.Rows[i].Cells[j].Style.BackColor = Color.LightBlue; // Reset color  
                        dgv1.Rows[i].Cells[j].Value = ""; // Reset cell value  
                    }
                }
            
        }




        private void btnNewGame_Click_1(object sender, EventArgs e)

        {
            BS.ResetGame();
            InitializeDataGridViews();
            ResetDataGridViews();
            UpdateTurnTakenLabel();
            UpdateProgressBar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the grid that was clicked
            DataGridView clickedGrid = sender as DataGridView;

            if (clickedGrid != null && e.RowIndex >= 0 && e.RowIndex < BS.MAX_BOARD_SIZE &&
                e.ColumnIndex >= 0 && e.ColumnIndex < BS.MAX_BOARD_SIZE)
            {
                int x = e.RowIndex;
                int y = e.ColumnIndex;

                // Fire missile and update the clicked grid
                bool hit = BS.FireMissile(x, y);
                UpdateBoardVisuals(clickedGrid, x, y, hit); // Pass the clicked grid
                UpdateTurnTakenLabel();
            }
        }

        private void btnShowBoat_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < BS.MAX_BOARD_SIZE; i++) // Use MAX_BOARD_SIZE instead of a hard-coded 10
                {
                    for (int j = 0; j < BS.MAX_BOARD_SIZE; j++)
                    {
                        if (boatPositions[i, j] != Boats.NoBoat)
                        {
                            // Ensure you are accessing valid row and column indices
                            if (i >= 0 && i < dgv1.RowCount && j >= 0 && j < dgv1.ColumnCount)
                            {
                                dgv1.Rows[i].Cells[j].Style.BackColor = Color.Purple; // Or any color that represents a boat
                                dgv1.Rows[i].Cells[j].Value = "B"; // Display 'B' for boat
                            }
                        }
                    }
                }
            }
        }

        private void ProgressBarBoats_Click(object sender, EventArgs e)
        {

        }
    }
    }

    

