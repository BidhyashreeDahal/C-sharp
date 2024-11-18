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

namespace Assignment_4_Minecraft
{
    public partial class frmSettings : Form
    {
        private PlayerProfile profile;
        
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash frm = new frmSplash(this); 
            frm.ShowDialog();
            
        }
        public void PopulateProfiles()
        {
            foreach (PlayerProfile profile in PlayerProfile.Profiles)
            {
                lbxProfiles.Items.Add(profile.ProfileName);
            }
            
        }
        public void PopulateCharacterDetails(PlayerProfile profile)
        {  
        cboInputDevices.SelectedItem = profile.InputDevice;
        chkAutoJump.Checked = profile.AutoJump;
        nudMouseSensitivity.Value = profile.MouseSensitivity;
        nudControllerSensitivity.Value = profile.ControllerSensitivity;
        chkInvertYAxis.Checked = profile.InvertYAxis;   
        trkBrightness.Value = profile.Brightness;
        chkFancyGraphics.Checked = profile.FancyGraphics;
        chkVSync.Checked = profile.VSync;
        chkUpscaling.Checked = profile.UpScaling;
        chkRayTracing.Checked = profile.RayTracing;
        chkFullscreen.Checked = profile.Fullscreen;
        nudRenderDistance.Value = profile.RenderDistance;
        trkFieldOfView.Value = profile.FieldOfView;
        trkMusic.Value = profile.Music;
        trkSound.Value = profile.Sound;
        trkHuddTransparency.Value = profile.HUDDTransparency;
        chkShowCoordinates.Checked = profile.ShowCoordinates;
        cboCameraProspective.SelectedItem = profile.CameraPerspective;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Tools.SaveProfilesToFile(PlayerProfile.Profiles, Tools.DefaultConstantPath);
                MessageBox.Show("Profiles saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pp =lbxProfiles.SelectedItem.ToString();
            PlayerProfile p = PlayerProfile.FindProfile(pp);
            if (p != null) {
                PopulateCharacterDetails(p);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            try
            {
                var profiles = Tools.LoadProfilesFromFile();
                lbxProfiles.DataSource = profiles; // Assuming you use a ListBox to display profiles.
                MessageBox.Show("Profiles loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
