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
    public partial class frmSplash : Form
    {
        private Students frmS;
        public frmSplash(Students frm)
        {
            InitializeComponent();
            frmS = frm;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmS.Show();
            this.Close();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
