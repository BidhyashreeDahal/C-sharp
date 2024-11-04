/*/*
 * Title :SplashForm.cs
 * Name : Bidhyashree Dahal
 * Student ID :100952513
 * The purpose of this file is to create a user interface for showchasing the images 
 * and additional information of the main function of the UI
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3D_D
{
    public partial class SplashForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashForm"/> class.
        /// This constructor sets up the form components by calling the InitializeComponent method.
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the SplashForm.
        /// This method plays background music when the form loads.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            Classes.Tools.Play();
        }
        /// <summary>
        /// Handles the Click event of the btnStart button.
        /// This method opens the main form of the application and hides the splash form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Hide();
        }
    }
}
