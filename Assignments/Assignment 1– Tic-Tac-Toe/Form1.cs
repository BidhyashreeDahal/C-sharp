/* Title : Form1.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to define the logic and behavior of the Tic-Tac-Toe game,
 * including the game's interface, player interactions, and win/draw conditions.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Assignment_1__Tic_Tac_Toe
{
    /// <summary>
    /// Main Form for Tic-Tac-Toe Game
    /// </summary>
    public partial class frmTicTocGame : Form
    {
        #region Initialization
        // Game variables
        private bool isPlayer1Turn;
        private Label[,] gameBoard;
        private string player1Symbol;
        private string player2Symbol;
        private int player1Score;
        private int player2Score;
        /// <summary>
        /// Constructor : Initializes form and game board
        /// </summary>
        public frmTicTocGame()
        {
            InitializeComponent();
            InitializeGameBoard();
        }
        /// <summary>
        /// Resets the player scores to 0, update the game summary text,
        /// initializes a 3x3 array of Label controls for the Tic-Tac-Toe board, 
        /// and attaches a click event handler to each label for player interactions.
        /// </summary>
        private void InitializeGameBoard()
        {
            player1Score = 0;
            player2Score = 0;
            lblGameSummeryDiscription.Text = "Player 1:0 || Player 2: 0";
            gameBoard = new Label[3, 3] // Game Board Setup
            {
               { lblFirstBox, lblSecondBox,lblThirdBox},
               { lblFourthBox,lblFifthBox,lblSixthBox},
               {lblSeventhBox,lblEighthBox,lblNinthBox}
            };
            // Attach click event handlers for each label
            foreach (Label label in gameBoard)
            {
                label.Click += Label_Click;
            }

        }

        #endregion

        # region Game Logic
        /// <summary>
        /// Sets the player name and determine who is going first with what symbol
        /// </summary>
        private void StartGame()
        {
            string playerOne = txtFirstPlayerName.Text;
            string playerTwo = txtSecondPlayerName.Text;
            if(string.IsNullOrEmpty(playerOne) || string.IsNullOrEmpty(playerTwo) )
            {
                MessageBox.Show("Please enter names for both players.");
                return;
            }
  
            // Randomly decide who goes first
            Random rand = new Random();
            isPlayer1Turn = rand.Next(0,2) == 1;

            // Update the UI to correctly show the starting player's turn
            TurnDecider();

            // Inform players who is going first with which symbol
            MessageBox.Show($"{(isPlayer1Turn ? playerOne : playerTwo)} will start first!");

        }
        /// <summary>
        /// Update the turn indicator label to reflect the current player turn
        /// </summary>
        private void TurnDecider()
        {
            if (isPlayer1Turn)
            {
                lblTurnIndicator.Text = $"Turn: { txtFirstPlayerName.Text} :: {player1Symbol}"; // Show player 1's turn  
            }
            else
            {
                lblTurnIndicator.Text = $"Turn: {txtSecondPlayerName.Text}:: {player2Symbol}"; // Show player 2's turn  
            }
        }
        /// <summary>
        /// Checks for win conditions and draw conditions by evaluating rows, columns, and diagonals,
        /// and handles the end of the game by updating scores and displaying messages.
        /// </summary>
        private void CheckForWin()
        {
            string winner = null;

            // Check Rows For Winners
            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2]))
                {
                    winner = gameBoard[i, 0].Text;
                    break;
                }

            }
            // Check Column For Winners

            for (int i = 0; i < 3; i++)
            {
                if (CheckLine(gameBoard[0, i], gameBoard[1, i], gameBoard[2, i]))
                {
                    winner = gameBoard[0, i].Text;
                    break;
                }
            }
            // Check diagonals for a winner
            if (CheckLine(gameBoard[0, 0], gameBoard[1, 1], gameBoard[2, 2]) ||
                CheckLine(gameBoard[0, 2], gameBoard[1, 1], gameBoard[2, 0]))
            {
                winner = gameBoard[1, 1].Text;
            }
            // If there is a winner Update game score
            if(winner != null)
            {
                if(winner == player1Symbol) player1Score++;
                else player2Score++;
                UpdateGameSummary();
                MessageBox.Show($"{(winner == player1Symbol ? txtFirstPlayerName.Text : txtSecondPlayerName.Text)} wins!");
                ResetGame();
            }
            else
            {
                // Check for draw
                bool isDraw = true;
                foreach (Label label in gameBoard)
                {
                    if (string.IsNullOrEmpty(label.Text))
                    {
                        isDraw = false;
                        break; // Exit loop early if an empty label is found
                    }
                }
                if (isDraw)
                {
                    MessageBox.Show("It's a draw!");
                    ResetGame();
                }

            }
        }
        /// <summary>
        /// Check if three labels in a line contains the same symbol i.e either X or O
        /// </summary>
        /// <param name="a">The first label to check </param>
        /// <param name="b">The second label to check </param>
        /// <param name="c">The third label to check </param>
        /// <returns>True if all the labels match and are not empty otherwise false</returns>
        private bool CheckLine(Label a, Label b, Label c)
        {
            return a.Text == b.Text && b.Text == c.Text && !string.IsNullOrEmpty(a.Text);
        }
        /// <summary>
        /// Update the game summery label to display the current scores of both players
        /// </summary>
        private void UpdateGameSummary()
        {
            // Player 1 and Player 2 should have their respective symbols
            lblGameSummeryDiscription.Text = $"{txtFirstPlayerName.Text} ({player1Symbol}): {player1Score} | {txtSecondPlayerName.Text} ({player2Symbol}): {player2Score}";
        }
        #endregion

        #region Additional Feature
        /// <summary>
        /// Method to play the click sound
        /// </summary>
        private void PlaySound()
        {
            using (SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.A))
            {
                soundPlayer.Play();
            }
            
        }
        #endregion

        #region UI Click Event Handlers
        /// <summary>
        /// Handles the selection of symbols for Player 1 and ensures that both player names are provided.
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The event data.</param>
        private void radPlayer1X_CheckedChanged(object sender, EventArgs e)
        {
            string playerOne = txtFirstPlayerName.Text;
            string playerTwo = txtSecondPlayerName.Text;
            if (string.IsNullOrWhiteSpace(playerOne) || string.IsNullOrWhiteSpace(playerTwo))
            {
                // Reset radio buttons without triggering their checked changed events again
                radPlayer1X.CheckedChanged -= radPlayer1X_CheckedChanged;
                radPlayer1O.CheckedChanged -= radPlayer1X_CheckedChanged;

                radPlayer1O.Checked = false;
                radPlayer1X.Checked = false;

                // Re-attach event handlers
                radPlayer1X.CheckedChanged += radPlayer1X_CheckedChanged;
                radPlayer1O.CheckedChanged += radPlayer1X_CheckedChanged;
                
                MessageBox.Show("Please enter names for both players.");
                return;
            }
            if (!radPlayer1X.Checked && !radPlayer1O.Checked) return;

            // Player 1 chooses the symbol
            if (isPlayer1Turn)
            {
                if (radPlayer1X.Checked)
                {
                    player1Symbol = "X";
                    player2Symbol = "O";
                }
                else if (radPlayer1O.Checked)
                {
                    player1Symbol = "O";
                    player2Symbol = "X";
                }
            }
            // Player 2 chooses the symbol
            else
            {
                if (radPlayer1X.Checked)
                {
                    player2Symbol = "X";
                    player1Symbol = "O";
                }
                else if (radPlayer1O.Checked)
                {
                    player2Symbol = "O";
                    player1Symbol = "X";
                }
            }

            // Disable radio buttons after selection
            radPlayer1X.Enabled = false;
            radPlayer1O.Enabled = false; 
            TurnDecider();
           
        }
        /// <summary>
        /// Starts the game when the turn button is clicked, triggering the game setup.
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The event data</param>
        private void btnTurn_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        /// <summary>
        /// Handles click on the game board labels, 
        /// setting the label text to the current players symbol and checking for win conditions.
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The event data</param>
        private void Label_Click(object sender , EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (clickedLabel.Text != "") return;
            // Set the text based on the current player's turn  
            clickedLabel.Text = isPlayer1Turn ? player1Symbol : player2Symbol;
            isPlayer1Turn = !isPlayer1Turn;
            TurnDecider();
            CheckForWin();   
            PlaySound();
        }
        /// <summary>
        /// Confirm if user really wants to exit and Exits the application if user hit ok button
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The event data</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Conformation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        /// <summary>
        /// Resets the game and clears player inputs when the reset button is clicked.
        /// </summary>
        /// <param name="sender">The source of event</param>
        /// <param name="e">The event data</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
          ResetGame();
          lblGameSummeryDiscription.Text = "";
          txtFirstPlayerName.Text = string.Empty;
          txtSecondPlayerName.Text = string.Empty;
        }
        #endregion

        #region Game State Management
        /// <summary>
        /// Clear users input and update the game summery
        /// </summary>
        private void ResetGame()
        {
            {
                foreach (Label label in gameBoard)
                {
                    label.Text = "";
                }
                // Reset player symbols
                player1Symbol = "";
                player2Symbol = "";
                isPlayer1Turn = false;
                lblTurnIndicator.Text = "";
                radPlayer1X.Checked = false;
                radPlayer1O.Checked = false;
                radPlayer1O.Enabled = true;
                radPlayer1X.Enabled = true;
            }
          
        }

        #endregion
    }
}
          