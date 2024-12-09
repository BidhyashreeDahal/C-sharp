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

namespace Assignment5
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            this.Hide();
            frmSplashScreen frm = new frmSplashScreen(this);
            frm.ShowDialog();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegistration frm = new frmRegistration();
            frm.ShowDialog();
        }
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

            
            // Use the GetUser method to retrieve the user
            User user = User.GetUser(email, passKey);
            if (user != null)
            {
                
                frmMain frmMain = new frmMain(user);
                frmMain.ShowDialog();

                this.DialogResult = DialogResult.OK; // Indicate successful login
                this.Close();
            }
            else
            {
                // Invalid credentials
                MessageBox.Show("Invalid email or passkey. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            PasswordDisplay();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordDisplay();
        }

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
    }
}
