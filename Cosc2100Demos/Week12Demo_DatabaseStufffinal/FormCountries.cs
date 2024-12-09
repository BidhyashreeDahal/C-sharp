using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Demo_DatabaseStufffinal
{
    public partial class frmContries : Form
    {
        public frmContries()
        {
            InitializeComponent();
        }

        private void FormCountries_Load(object sender, EventArgs e)
        {
            try
            {
                Country.PopulateCountries();
            }
             catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
            dataGridView1.AutoGenerateColumns =false;
            dataGridView1.DataSource = Country.countries;
        }
    }
}
