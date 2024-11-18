using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11
{
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Do Stuff
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSet4.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.employeeSampleDataSet4.countries);

        }
    }
}
