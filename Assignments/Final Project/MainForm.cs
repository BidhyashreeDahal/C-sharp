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
    public partial class MainForm : Form
    {
        private bool isDarkModeEnabled = false;

        private Contact contact;
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadContacts(0);
            dgvContacts.ClearSelection();
            SplashScreen frm = new SplashScreen(this);
            frm.ShowDialog(); // Show splash screen as modal dialog

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

        private void btnAdd_Click(object sender, EventArgs e)
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
    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                int contactID = Convert.ToInt32(dgvContacts.CurrentRow.Cells["ContactID"].Value);

                using (frmAddorEdit frm = new frmAddorEdit(this))
                {
                    frm.StatusText = " Editing Contact";
                    frm.MainFormRef = this; // Pass the reference of the MainForm
                    frm.LoadContactDetails(contactID); // Load the contact details for editing
                    var result = frm.ShowDialog();

                    // Refresh the DataGridView if the dialog result indicates success
                    if (result == DialogResult.OK)
                    {
                        LoadContacts(contactID);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadContacts(int contactID)
        {
            dgvContacts.DataSource = null; // 
            try
            {
                List<Contact> contacts;
                if (contactID == 0)
                {
                    // Load all contacts  
                    contacts = Contact.GetAllContacts();
                }
                else
                {
                    // Load contact by ID  
                    contacts = Contact.GetAllContacts();
                }

                dgvContacts.DataSource = contacts;
                dgvContacts.ClearSelection();

                // If there's a ContactID, highlight the specific contact  

                if (contactID != 0)
                {
                    var contactToEdit = contacts.FirstOrDefault(c => c.ContactID == contactID);
                    if (contactToEdit != null)
                    {
                        int index = contacts.IndexOf(contactToEdit);
                        if (index >= 0)
                        {
                            dgvContacts.ClearSelection();
                            dgvContacts.Rows[index].Selected = true; // Select the row with the specific ContactID
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contacts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void msMainForm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                var selectedContact = dgvContacts.CurrentRow.DataBoundItem as Contact;

                if (selectedContact != null)
                {
                    // Update the StatusStrip with the contact's name and email
                    toolStatusStriplabelStatus.Text = $"Selected Contact: {selectedContact.FullName} | Email: {selectedContact.Email}";
                }
                else
                {
                    // Clear the StatusStrip if no valid contact is selected
                    toolStatusStriplabelStatus.Text = "No contact selected.";
                }
            }
            else
            {
                // Clear the StatusStrip if no row is selected
                toolStatusStriplabelStatus.Text = "No contact selected.";
            }
        
    }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            
            isDarkModeEnabled = !isDarkModeEnabled; // Toggle the theme
            ApplyTheme();
            ApplyDarkMode(dgvContacts);
        }

        private void ApplyTheme()
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

        private void ApplyDarkMode(DataGridView dgv)
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
                // Apply dark mode styles
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48); // Dark background
                    row.DefaultCellStyle.ForeColor = Color.White; // Dark text
                }
            }
        }

    }

}
