/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-6
 * The form is the first form that open when running the program
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

namespace Assignment5.Forms
{
    public partial class frmSplashScreen : Form
    {
        private frmLogin frmLog;
        /// <summary>
        /// Initializes the splash screen and sets up the timer.
        /// </summary>
        /// <param name="frm">Reference to the login form.</param>
        public frmSplashScreen(frmLogin frm)
        {
            InitializeComponent();
            frmLog = frm;
            tmrSplash.Interval = 5000;
            tmrSplash.Tick += tmrSplash_Tick;
            tmrSplash.Start();
        }
        /// <summary>
        /// Handles the timer tick event, transitioning from the splash screen to the login form.
        /// </summary>
        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            tmrSplash.Stop();
            frmLog.Show();
            this.Close();
        }

       
    }
}
