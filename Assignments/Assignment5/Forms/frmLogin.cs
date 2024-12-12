using Assignment5.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAL;
using Assignment5.Properties;

namespace Assignment5
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// I itialize form component
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Event handler for form load.
        /// Displays the splash screen and hides the login form initially.
        /// </summary>

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            frmSplashScreen frm = new frmSplashScreen(this);
            frm.ShowDialog();
        }
        /// <summary>
        /// Event handler for the "Register" button click.
        /// Opens the registration form as a modal dialog.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.ShowDialog();
        }
        /// <summary>
        /// Event handler for the "Login" button click.
        /// Validates the user's email and passkey, authenticates the user, and transitions to the main form if successful.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text.ToString();
            string passKey = txtPassword.Text.ToString();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Tools.IsValidPasskey(passKey))
            {
                MessageBox.Show("Passkey must be a 4-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = User.GetUser(email, passKey);
            if (user != null)
            {
                int currentUserID = Settings.Default.CurrentUserID;
                Settings.Default.CurrentUserID = user.UserID;
                Settings.Default.Save();

                frmMain frmMain = new frmMain(user);
                this.Hide();
                frmMain.ShowDialog();

                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or passkey. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Event handler for showing or hiding the password based on the checkbox state.
        /// </summary>
        private void radShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            PasswordDisplay();
        }
        /// <summary>
        /// Event handler for text change in password input.
        /// Updates password visibility based on checkbox state.
        /// </summary>

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordDisplay();
        }
        /// <summary>
        /// Toggles the visibility of the password.
        /// </summary>

        private void PasswordDisplay()
        {
            if (!radShowPassword.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }
        /// <summary>
        /// Event handler for the "Exit" button click.
        /// Exits the application.
        /// </summary>

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
