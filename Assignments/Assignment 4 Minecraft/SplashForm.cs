/*
 * SplashForm.cs
 * Bidjyashree dahal
 * 100952513
 * this form is responsible for providing a brief introductory screen, playing a background sound,
 * and seamlessly transitioning to the settings form where the user can interact with profiles.
 */
using Assignment_4_Minecraft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_Minecraft
{
    public partial class frmSplash : Form
    {
        private PlayerProfile eachProfile;
        private frmSettings frmSet;
        // <summary>
        /// Constructor for frmSplash. Initializes components and starts the splash screen timer.
        /// <param name="frm">Reference to the settings form that will be shown after the splash screen.</param>
        public frmSplash(frmSettings frm)
        {
            InitializeComponent();
            PlaySound();
            // Timer for Splash Screen
            frmSet = frm;
            tmrSplashScreen.Interval = 5000;
            tmrSplashScreen.Tick += tmrSplashScreen_Tick;
            tmrSplashScreen.Start(); 
            // Initialize eachProfile  
            eachProfile = new PlayerProfile(); // Ensure this line is added  
            eachProfile.DefaultProfile();
            frmSet.PopulateProfiles();// Now this should work without throwing an exception  
        }
        /// <summary>
        ///  Plays the background sound for the splash screen.
        /// </summary>

        public void PlaySound()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.woods_of_imagination_139004);
            soundPlayer.PlayLooping();
        }
        /// <summary>
        /// Event handler for the splash screen timer's tick event. 
        /// This method is called when the timer reaches its interval (5 seconds).
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            tmrSplashScreen.Stop();
            frmSet.Show();
            this.Close();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
