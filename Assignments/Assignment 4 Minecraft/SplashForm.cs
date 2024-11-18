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
   
        public void PlaySound()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.woods_of_imagination_139004);
            soundPlayer.PlayLooping();
        }
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
