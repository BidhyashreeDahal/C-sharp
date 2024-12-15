/*
 * Bidhyashree Dahal 
 * 100952513
 * 2024-12-10
 * Main-Form which displays the contact details in datagrid 
 * view and has button to add, edit and delete contacts
 */


using Final_Project.DBAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Final_Project
{
  /// <summary>
 /// Represents the main form of the application.
 /// </summary>
    public partial class frmMain : Form
    {
        private bool isDarkModeEnabled = false;
        private Contact contact;
        /// <summary>
        /// Main form constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }
        ///<summary>
        /// Handles the form load event. Loads contacts and initializes the data grid.
        /// </summary>
        /// <param name="sender">The source of the event (usually the form).</param>
        /// <param name="e">Event arguments.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadContacts(0);
            dgvContacts.ClearSelection();
            dgvContacts.CurrentCell = null;
            dgvContacts.RowHeadersVisible = false;
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();
            this.Show();
            try
            {
                List<Contact> contacts = Contact.GetAllContacts();
                dgvContacts.DataSource = contacts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        /// <summary>
        /// Loads contacts into the DataGridView. Supports loading all contacts or a specific contact by ID.
        /// </summary>
        /// <param name="contactID">The ID of the contact to load. 0 for all contacts, non-zero for specific contact.</param>

        public void LoadContacts(int contactID)
        {
            dgvContacts.DataSource = null; 
            try
            {
                List<Contact> contacts;
                if (contactID == 0)
                {
                    contacts = Contact.GetAllContacts();
                }
                else
                {
                    contacts = Contact.GetAllContacts();
                }

                dgvContacts.DataSource = contacts;
                dgvContacts.ClearSelection();
                dgvContacts.CurrentCell = null;
                // If there's a ContactID, highlight the specific contact  
                // Generated Code during debugging 
                if (contactID != 0)
                {
                    var contactToEdit = contacts.FirstOrDefault(c => c.ContactID == contactID);
                    if (contactToEdit != null)
                    {
                        int index = contacts.IndexOf(contactToEdit);
                        if (index >= 0)
                        {
                            dgvContacts.ClearSelection();
                            dgvContacts.Rows[index].Selected = true; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Click Events

        /// <summary>
        /// Handles the Add button click event. Opens the form to add a new contact.
        /// </summary>
        /// <param name="sender">The source of the event (Add button).</param>
        /// <param name="e">Event arguments.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddorEdit addOrEditForm = new frmAddorEdit(this)
                {

                    StatusText = "Add New Contact"
                };

                var result = addOrEditForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadContacts(0);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred while adding the contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Edit button click event. Opens the form to edit the selected contact.
        /// </summary>
        /// <param name="sender">The source of the event (Edit button).</param>
        /// <param name="e">Event arguments.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContacts.CurrentRow != null)
                {
                    int contactID = Convert.ToInt32(dgvContacts.CurrentRow.Cells["ContactID"].Value);

                    frmAddorEdit frm = new frmAddorEdit(this)
                    {
                        StatusText = " Editing Contact"
                    };
                    frm.MainFormRef = this; // Pass the reference of the MainForm
                    frm.LoadContactDetails(contactID); // Load the contact details for editing
                    var result = frm.ShowDialog();

                    // Refresh the DataGridView if the dialog result indicates success
                    if (result == DialogResult.OK)
                    {
                        LoadContacts(contactID);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a contact to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred while editing the contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the Delete button click event. Deletes the selected contact after confirmation.
        /// </summary>
        /// <param name="sender">The source of the event (Delete button).</param>
        /// <param name="e">Event arguments.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null || dgvContacts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a contact to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedContact = dgvContacts.CurrentRow.DataBoundItem as Contact;
            if (selectedContact == null)
            {
                MessageBox.Show("Error retrieving the selected contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this contact?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = Contact.DeleteContact(selectedContact.ContactID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Contact deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadContacts(0);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        /// <summary>
        /// Handles the selection change event on the DataGridView. Updates the status strip with the selected contact's information.
        /// </summary>
        /// <param name="sender">The source of the event (DataGridView).</param>
        /// <param name="e">Event arguments.</param>
        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvContacts.CurrentRow != null)
                {
                    var selectedContact = dgvContacts.CurrentRow.DataBoundItem as Contact;

                    if (selectedContact != null)
                    {
                        toolStatusStriplabelStatus.Text = $"Selected Contact: {selectedContact.FullName} | Email: {selectedContact.Email}";
                    }
                    else
                    {
                        toolStatusStriplabelStatus.Text = "No contact selected.";
                    }
                }
                else
                {
                    toolStatusStriplabelStatus.Text = "No contact selected.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting a contact: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStatusStriplabelStatus.Text = "Error updating status."; // Optionally display a generic error message
            }

        }
        #region Cool Feature
        ///////////// ------------------- Added Cool Feature ---------------------/////////
        /// <summary>
        /// Handles the theme button click event. Toggles between dark mode and light mode.
        /// </summary>
        /// <param name="sender">The source of the event (Theme button).</param>
        /// <param name="e">Event arguments.</param>
        private void btnTheme_Click(object sender, EventArgs e)
        {

            isDarkModeEnabled = !isDarkModeEnabled; // Toggle the theme
            ApplyTheme();
            ApplyDarkMode(dgvContacts);
        }
        #endregion
        /*
         * Generated Code : Added enabled and disabled feature, fixed Colors, 
         */
        /// <summary>
        /// Applies the current theme (dark or light) to the form controls.
        /// </summary>

        private void ApplyTheme()
        {
            try
            {
                if (isDarkModeEnabled)
                {
                    // Dark Mode colors
                    this.BackColor = Color.DarkSlateGray;
                    this.ForeColor = Color.White;

                    foreach (Control control in Controls)
                    {
                        control.BackColor = Color.DarkSlateGray;
                        control.ForeColor = Color.White;
                    }

                    dgvContacts.BackgroundColor = Color.DarkSlateGray;
                    dgvContacts.ForeColor = Color.White;
                }
                else
                {
                    // Light Mode colors
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;

                    foreach (Control control in Controls)
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }

                    dgvContacts.BackgroundColor = Color.White;
                    dgvContacts.ForeColor = Color.Black;
                }

                // Save the theme preference
                Properties.Settings.Default.IsDarkMode = isDarkModeEnabled;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while applying the theme: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Applies dark mode or light mode styles to the DataGridView based on the theme setting.
        /// </summary>
        /// <param name="dgv">The DataGridView to apply styles to.</param>
        private void ApplyDarkMode(DataGridView dgv)
        {
            try
            {
                if (!isDarkModeEnabled)
                {
                    // Apply light mode styles
                    dgv.BackgroundColor = Color.White;
                    dgv.ForeColor = Color.Black;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White; // Default background
                        row.DefaultCellStyle.ForeColor = Color.Black; // Default text color
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Dark background
                        row.DefaultCellStyle.ForeColor = Color.White; // Dark text
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while applying dark mode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion
}