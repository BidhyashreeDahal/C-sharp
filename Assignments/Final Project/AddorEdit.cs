/*Bidhyashree Dahal
 * 100952513
 * 2024-12-14
 * The form to add the new contact or edit the existing one
 */

using Final_Project.Properties;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project.DBAL
{
    /// <summary>
    /// Represents a form for adding or editing contact information.
    /// </summary>
    public partial class frmAddorEdit : Form
    {
        /// <summary>
        /// Gets or sets the ID of the contact to edit. If null, a new contact is being added.
        /// </summary>
        public int? ContactID { get; set; }
        /// <summary>
        /// Gets or sets the reference to the main form.
        /// </summary>
        public frmMain MainFormRef { get; internal set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddorEdit"/> class.
        /// </summary>
        /// <param name="mainForm">The main form instance.</param>
        public frmAddorEdit(frmMain mainForm)
        {
            InitializeComponent();
            MainFormRef = mainForm;
        }
        /* Genertated Code 
         * Prompt :: I want to update the label of the addoredit form while clicking buttons in mainform 
         * Chat GPT suggested me to generate  
         * get or set peoperty and use in in the mainform
         */
        /// <summary>
        /// Gets or sets the status text displayed on the form.
        /// </summary>
        public string StatusText
        {
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }
        /// <summary>
        /// Handles the form load event.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">Event data.</param>
        private void AddorEdit_Load(object sender, EventArgs e)
        {
           MainFormRef.Hide();
        }
        #region Click Events
        /// <summary>
        /// Handles the Save button click event to save or update contact details.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">Event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtfirstName.Text.Trim();
                string phoneNumber = txtPhoneNumber.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtAddress.Text.Trim();

                // Validation checks
                if (string.IsNullOrEmpty(fullName) || !Tools.IsValidFullName(fullName))
                {
                    MessageBox.Show("Invalid Full Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != 10 || !Tools.IsValidPhoneNumber(phoneNumber))
                {
                    MessageBox.Show("Invalid Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(email) || !Tools.IsValidEmail(email))
                {
                    MessageBox.Show("Invalid Email", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Address cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Contact contact = new Contact
                {
                    FullName = fullName,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    Address = address,
                    UpdatedAt = DateTime.Now,
                    CreatedAt = DateTime.Now
                };

                if (ContactID.HasValue)
                {
                    // Edit existing contact
                    contact.ContactID = ContactID.Value;
                    Contact.UpdateContact(contact);
                    MessageBox.Show("Contact updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Tools.EmailExists(email))
                    {
                        MessageBox.Show("Email already exist", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Tools.PhoneNumberExists(phoneNumber)) 
                    {
                        MessageBox.Show("Phone Number already exist", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Contact.InsertContacts(contact);
                    MessageBox.Show("Contact added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MainFormRef.LoadContacts(0);
                MainFormRef.Show();
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the Return button click event to return to the main form.
        /// </summary>
        /// <param name="sender">The event source.</param>
        /// <param name="e">Event data.</param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainFormRef.Show();
            this.Close();
        }
        #endregion
        /// <summary>
        /// Loads contact details into the form for editing.
        /// </summary>
        /// <param name="contactID">The ID of the contact to load.</param>
        public void LoadContactDetails(int contactID)
        {
            try
            {
                this.ContactID = contactID; // Set the ContactID
                var contact = Contact.GetContactByID(contactID); // Fetch contact details using the ID

                if (contact != null)
                {
                    txtfirstName.Text = contact.FullName;
                    txtPhoneNumber.Text = contact.PhoneNumber;
                    txtEmail.Text = contact.Email;
                    txtAddress.Text = contact.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contact details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
