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
namespace Assignment_1__Tic_Tac_Toe
{
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

        public frmTicTocGame()
        {
            InitializeComponent();
            InitializeGameBoard();
        }
        private void InitializeGameBoard()
        {
            player1Score = 0;
            player2Score = 0;
            lblGameSummeryDiscription.Text = "Player 1:0 | Player 2: 0";
            gameBoard = new Label[3, 3]
            {
               { lblFirstBox, lblSecondBox,lblThirdBox},
               { lblFourthBox,lblFifthBox,lblSixthBox},
               {lblSeventhBox,lblEighthBox,lblNinthBox}
            };

            foreach (Label label in gameBoard)
            {
                label.Click += Label_Click;
            }

        }

        #endregion

        # region Game Logic
        private void StartGame()
        {

            string playerOne = txtFirstPlayerName.Text;
            string playerTwo = txtSecondPlayerName.Text;
  
            // Randomly decide who goes first
            Random rand = new Random();
            isPlayer1Turn = rand.Next(0,2) == 1;

            // Update the UI to correctly show the starting player's turn
            TurnDecider();

            // Inform players who is going first with which symbol
            MessageBox.Show($"{(isPlayer1Turn ? playerOne : playerTwo)} will start first!");

        }
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

            if(winner != null)
            {
                if(winner ==player1Symbol) player1Score++;
                else player2Score++;
                UpdateGameSummary();
                MessageBox.Show($"{(winner == player1Symbol ? txtFirstPlayerName.Text : txtSecondPlayerName.Text)} wins!");
                ResetGame();
            }
            else if (gameBoard.Cast<Label>().All(label => !string.IsNullOrEmpty(label.Text)))
            {
                MessageBox.Show("It's a draw!");
                ResetGame();
            }
        }
        private bool CheckLine(Label a, Label b, Label c)
        {
            return a.Text == b.Text && b.Text == c.Text && !string.IsNullOrEmpty(a.Text);
        }
        private void UpdateGameSummary()
        {
            lblGameSummeryDiscription.Text = $"{txtFirstPlayerName.Text} (X): {player1Score} | {txtSecondPlayerName.Text} (O): {player2Score}";
        }



        #endregion

        #region UI Click Event Handlers

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
            MessageBox.Show("Symbols selected! Game can now begin.");
           
        }
        private void btnTurn_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void Label_Click(object sender , EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            if (clickedLabel.Text != "") return;
            // Set the text based on the current player's turn  
            clickedLabel.Text = isPlayer1Turn ? player1Symbol : player2Symbol;
            isPlayer1Turn = !isPlayer1Turn;
            TurnDecider();
            CheckForWin();
           
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Conformation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          ResetGame();
          lblGameSummeryDiscription.Text = "";
          txtFirstPlayerName.Text = string.Empty;
          txtSecondPlayerName.Text = string.Empty;
        }
        #endregion

        #region Game State Management
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
          