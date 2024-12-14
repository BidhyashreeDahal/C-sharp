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
    public partial class frmAddorEdit : Form
    {
        private MainForm frm;
        public int? ContactID { get; set; }
        public MainForm MainFormRef { get; internal set; }

        public frmAddorEdit(MainForm mainForm)
        {
            InitializeComponent();
            MainFormRef = mainForm;

        }

        public string StatusText
        {
            get => lblStatus.Text;
            set => lblStatus.Text = value;
        }


        private void AddorEdit_Load(object sender, EventArgs e)
        {
           
        }

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
                    contact.CreatedAt = DateTime.Now;
                    Contact.InsertContacts(contact);
                    
                    MessageBox.Show("Contact added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Set the MainFormRef property before calling LoadContacts  
                MainFormRef.LoadContacts(0);
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }



        private void pnlEditOrSave_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
