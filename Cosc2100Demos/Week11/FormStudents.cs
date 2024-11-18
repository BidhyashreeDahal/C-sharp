using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week11.Class;

namespace Week11
{
    public partial class Students : Form
    {
        private bool isLoading = true;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();

            Student.PopulateStudents();
            studentBindingSource.DataSource = Student.students;
            isLoading = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                Student students = (Student)comboBox1.SelectedItem;
                if (students != null)
                {
                    lblFirstName.Text = students.FirstName;
                    lblLastName.Text = students.LastName;
                    lblAge.Text = students.Age.ToString();
                    lblFullName.Text = students.FullName;
                    sslblCurrentStudent.Text = students.ToString();
                }
                else {
                    lblFirstName.Text=String.Empty; 
                    lblLastName.Text=String.Empty;
                    lblAge.Text=String.Empty;
                    lblFullName.Text=String.Empty;
                    sslblCurrentStudent.Text = "-none-";
                }
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0)comboBox1.SelectedIndex = 0;
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0)
            {
                if (comboBox1.SelectedIndex > 0) comboBox1.SelectedIndex--;
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                if(comboBox1.SelectedIndex < comboBox1.Items.Count - 1)
                    comboBox1.SelectedIndex++;
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if(comboBox1.Items.Count > 0)comboBox1.SelectedIndex = 
                    comboBox1.Items.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                Student student = (Student)comboBox1.SelectedItem;
                Student.students.Remove(student);
                studentBindingSource .Remove(student);
                comboBox1.SelectedIndex = 0;
                studentBindingSource.ResetBindings(false);
            }
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees();
            frm.ShowDialog();

        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            frmCountries frm = new frmCountries();
            frm.ShowDialog();
        }
    }
}
