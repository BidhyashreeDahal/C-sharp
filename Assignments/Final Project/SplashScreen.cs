/*
 * Bidhyashree Dahal
 * 100952513
 * 2024-12-10
 * This is the mainform that appears when running the program "Splash Form"
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

namespace Final_Project
{
    /// <summary>
    /// Partial class frmsplash
    /// </summary>
    public partial class frmSplash : Form
    {
        
        private frmMain mainForm;
        /// <summary>
        /// Initializes the splash screen and sets up the timer.
        /// </summary>
        /// <param name="frm">Reference to the login form.</param>
        public frmSplash(frmMain frm)
        {
            InitializeComponent();
            mainForm = frm;
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
            mainForm.Show();
            this.Hide(); 
        }
    }
}
