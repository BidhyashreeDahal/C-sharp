/// Title: frmMain.cs
/// Name: Bidhyashree Dahal
/// 100952513
/// 2024-09-19
/// This is a form that has two buttons one number guessing game where users can select the difficulty level and the random number is generated
/// Then the user has to guess that number and another is icecream cart where user can order the icecreams they want the program will show the
/// total amount to pay and user can pay amount by cash the change will be calculated , total money in the cash box will be calculated.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExercise01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        #region Menu buttons for My little Games
        private void btnIceCream_Click(object sender, EventArgs e)
        {
            pnlIceCream.Visible= !pnlIceCream.Visible;
            pnlGTN.Visible = false;
        }

        // Make the GTN panel invisible and vise versa when the user click the GTN button
        private void btnGTN_Click(object sender, EventArgs e)
        {
            pnlGTN.Visible = !(pnlGTN.Visible);
            pnlIceCream.Visible = false;
        }
        #endregion

       


        #region Set Defaults GTN
        // Set defaults value when the form loads
        private void SetDefaults()
        {
            SetGTNDefaults();
            SetIceCreamDefaults(); // Set defaults for icecream
        }
        // Set Defaults value of guess the number games
        private void SetGTNDefaults()
        {
            cboGTNSettingDifficulty.SelectedIndex = 0;
            SetGTNRandomNumber();
            nudGTNGuess.Value = 1;
            lblGTNOutput.Text = String.Empty;
            btnGTNPlayAgain.Visible = false; // Make the play again button invisible
        }

        // Set the random number with in a selected range
        private void SetGTNRandomNumber()
        {
            nudGTNActualNumber.Value = Tools.RandomInt(1, (int)nudGTNGuess.Maximum);
            nudGTNnumGuesses.Value = 0;
        }
        #endregion 

        #region Set Difficulty Level

        // Set the level of difficulty for the game i.e. easy, medium or hard
        private void SetGTNDifficulty()
        {
            switch (cboGTNSettingDifficulty.SelectedIndex)
            {
                case 1: // Medium Difficulty
                    nudGTNGuess.Maximum = Settings.MEDIUM_MAXIMUM;
                    lblGTNGuessMaximum.Text = Settings.MEDIUM_MAXIMUM.ToString();
                    break;
                case 2: // Hard  Difficulty
                    nudGTNGuess.Maximum = Settings.HARD_MAXIMUM;
                    lblGTNGuessMaximum.Text = Settings.HARD_MAXIMUM.ToString();
                    break;
                default: //Easy or Default Difficulty
                    nudGTNGuess.Maximum = Settings.DEFAULT_MAXIMUM;
                    lblGTNGuessMaximum.Text = Settings.DEFAULT_MAXIMUM.ToString();
                    break;
            }
            // Generate the new random number on the basis of difficulty level
            SetGTNRandomNumber();

        }
        #endregion GTN

       

        #region Event Handlers for Guess the Number Games
        // Set the defaults when the form loads
        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }
        // Make the GTN panel invisible and vise versa when the user click the GTN button
        

        // Change the difficulty when the new level is selected
        private void cboGTNSettingDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNDifficulty();
        }
        // Exit button click event to confirm if the user really wants to exit

        // Guess button click event to guide the user if the number they have enter is higher, lower or the exact.
        private void btnGTNGuess_Click(object sender, EventArgs e)
        {
            nudGTNnumGuesses.Value += 1;

            // compare guess to the random number
            if (nudGTNGuess.Value > nudGTNActualNumber.Value)
            {
                lblGTNOutput.Text += "Guess " + nudGTNnumGuesses.Value + " is TOO HIGH!\n";
            }
            else if (nudGTNGuess.Value < nudGTNActualNumber.Value)
            {
                lblGTNOutput.Text += "Guess " + nudGTNnumGuesses.Value + " is TOO LOW!\n";
            }
            else
            {
                lblGTNOutput.Text += "YEAH! You got it!  It took you " + nudGTNnumGuesses.Value + " guesses!";
                btnGTNPlayAgain.Visible = true; // When the user's guess is correct make the play again button visible
            }
        }
        // Reset the game when the user clicks play again
        private void btnGTNPlayAgain_Click(object sender, EventArgs e)
        {
            SetGTNDefaults();
        }
        private void btnExitt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        #endregion


        #region SetIceCreamDefaults

        // Set Icecream Defaults
        private void SetIceCreamDefaults()
        {
            cboProductlisst.SelectedIndex = Settings.DEFAULT_SELECTEDINDEX;
            nudQuantity.Value = Settings.DEFAULT_NUMERICUPDOWN;
            lblDisplayTotalPurchase.Text = "$" + Settings.DEFAULT_TOTALPURCHASE.ToString();
            txtEnterCash.Text ="$" + Settings.DEFAULT_ENTERCASH.ToString();
            lblReturnAmount.Text = "$" + Settings.DEFAULT_RETURNAMOUNT.ToString();
            lblCashBoxAmount.Text = "$" + Settings.DEFAULT_CASHBOXTOTAL.ToString();

        }
        #endregion

        #region Event Handlers for Icecream
        // Event Handlers for click button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCalculateTotal.Visible = true;
            int selIceCreamIndex = cboProductlisst.SelectedIndex;
            String iceCreamType = cboProductlisst.Items[selIceCreamIndex].ToString();
            lbxAddedIceCreams.Items.Add(iceCreamType + " : " + nudQuantity.Value);

        }
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (var item in lbxAddedIceCreams.Items)
            {
                // Items in the list box has two parts i.e Name and Quantity 
                string[] parts = item.ToString().Split(':'); 
                string iceCreamName = parts[0].Trim(); // Name of the Ice cream  
                int quantity = int.Parse(parts[1].Trim()); // Quantity of this ice cream  

                int iceCreamPrice = 0;

                // Price based on the ice cream name  
                switch (iceCreamName)
                {
                    case "Vanilla": // For Vanilla
                        iceCreamPrice = 3;
                        break;
                    case "Chocolate":
                        iceCreamPrice = 4; // For Chocolate
                        break;
                    case "Strawberry":
                        iceCreamPrice = 3; // For Strawberry
                        break;
                    case "Rocy Road":
                        iceCreamPrice = 3;// For Rocy Road
                        break;
                    case "Pastachio":
                        iceCreamPrice = 3; // For Pastachio
                        break;
                        // Add additional cases as necessary  
                }

                // Calculate total for this specific item  
                total += iceCreamPrice * quantity;
                lblCashBoxAmount.Text = "$" + (total +Settings.DEFAULT_CASHBOXTOTAL).ToString();
            }

            // Display the total cost  
            lblDisplayTotalPurchase.Text = "$" + total.ToString();
        }

        // Remove the selected items from the listbox with the user click remove
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            lbxAddedIceCreams.Items.Remove(lbxAddedIceCreams.SelectedItem);
        }

        // Clear everything in and set the defaults value when user hit clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxAddedIceCreams.Items.Clear();
            SetIceCreamDefaults();
        }
        // Calculate the change when the user pay by cash
        private void btnReturnBack_Click(object sender, EventArgs e)
        {
           

            string cashPaidText = txtEnterCash.Text;
            decimal cashPaid = decimal.Parse(cashPaidText);
            decimal total = decimal.Parse(lblDisplayTotalPurchase.Text.Replace("$",""));
            decimal returnAmount = cashPaid - total;
            lblReturnAmount.Text = "$" + returnAmount.ToString();


            // Total Amount in Cash Box
            lblCashBoxAmount.Text = "$" + ((total - returnAmount ) + Settings.DEFAULT_CASHBOXTOTAL).ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }
        #endregion

        private void pnlIceCream_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
