/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-6
 * Form for user registration.
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
using DBAL;

namespace Assignment5
{
    public partial class frmRegistration : Form
    {
        private frmLogin frmIn;
        /// <summary>
        /// Initializes a new instance of the frmRegistration class.
        /// </summary>
        public frmRegistration()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the click event of the registration button.
        /// Validates user input, creates a new User object, and inserts it into the database.
        /// </summary>
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Tools.GetMaxUserIDFromDatabase() + 1; ;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    MessageBox.Show("First Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Tools.IsValidFirstName(firstName))
                {
                    MessageBox.Show("First Name contains invalid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                   
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    MessageBox.Show("Last Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Tools.IsValidLastName(lastName))
                {
                    MessageBox.Show("Last Name contains invalid characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Tools.IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Tools.EmailExists(email)) 
                {
                    MessageBox.Show("Email already exist." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Tools.IsValidPasskey(password))
                {
                    MessageBox.Show("Password must be a valid 4-digit number between 1000 and 9999.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                    {                    
                    User u = new User()
                      {
                       
                        UserID = userID,
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Passkey = password
                    };
                    try
                    {
                        User.insertUser(u);
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                       
                        MessageBox.Show(ex.Message);
                    }       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while registering the user: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                    }
                }
                catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the click event of the cancel button.
        /// Closes the registration form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
