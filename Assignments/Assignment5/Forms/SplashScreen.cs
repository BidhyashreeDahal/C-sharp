using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Forms
{
    public partial class frmSplashScreen : Form
    {
        private frmLogin frmLog;
        public frmSplashScreen(frmLogin frm)
        {
            InitializeComponent();
            frmLog = frm;
            tmrSplash.Interval = 5000;
            tmrSplash.Tick += tmrSplash_Tick;
            tmrSplash.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Stop();
            frmLog.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
