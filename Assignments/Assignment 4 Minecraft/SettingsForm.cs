/*
 * SeetingsForm.cs
 * Name :Bidhyashree dahal
 * 100952513
 * 2024-11-15
 * frmSettings class manages player profiles in a settings form for a Minecraft-style application. 
 * It allows users to create, edit, save, and load profiles that store gameplay settings (like input devices, sensitivity, graphics, etc.). 
 * The form displays these profiles in a list, updates settings when a profile is selected, and persists the profiles by saving them to or loading them from a file.
 * 
 */

using Assignment_4_Minecraft.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Assignment_4_Minecraft
{
    public partial class frmSettings : Form
    {
        /// <summary>
        /// Represents the player's profile in the settings form.
        /// </summary>
        private PlayerProfile profile;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        public frmSettings()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the form's Load event. It hides the form, shows the splash screen, and populates the profiles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash frm = new frmSplash(this);
            frm.ShowDialog();
            PopulateProfiles(); // Load profiles on form load  
        }
        /// <summary>
        /// Populates the ListBox with available player profiles.
        /// </summary>
        public void PopulateProfiles()
        {
            lbxProfiles.Items.Clear();  // Clear existing items

            if (PlayerProfile.Profiles == null || !PlayerProfile.Profiles.Any())
            {
                MessageBox.Show("No profiles loaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (PlayerProfile profile in PlayerProfile.Profiles)
            {
                lbxProfiles.Items.Add(profile);  // Add PlayerProfile to ListBox
            }

            lbxProfiles.DisplayMember = "ProfileName";  // Display ProfileName in ListBox
        }
        /// <summary>
        /// Populates the character details in the form based on the selected profile.
        /// </summary>
        /// <param name="profile"></param>
        public void PopulateCharacterDetails(PlayerProfile profile)
        {
            txtnameValue.Text = profile.ProfileName;
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
            /// <summary>
            /// Event handler for saving a new profile.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSave_Click(object sender, EventArgs e)
        {
            string newProfileName = txtnameValue.Text.Trim();

            // Check if the profile name is not empty and doesn't already exist in the profiles list
            if (string.IsNullOrEmpty(newProfileName))
            {
                MessageBox.Show("Profile name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingProfile = PlayerProfile.FindProfile(newProfileName);
            if (existingProfile != null)
            {
                MessageBox.Show("Error: A profile with this name already exists. Please choose a different name.");
                return;
            }

            // Create a new profile if no existing profile is selected
            PlayerProfile newProfile = new PlayerProfile
            {
                ProfileName = newProfileName,
                InputDevice = cboInputDevices.SelectedItem.ToString(),
                AutoJump = chkAutoJump.Checked,
                MouseSensitivity = (int)nudMouseSensitivity.Value,
                ControllerSensitivity = (int)nudControllerSensitivity.Value,
                InvertYAxis = chkInvertYAxis.Checked,
                Brightness = trkBrightness.Value,
                FancyGraphics = chkFancyGraphics.Checked,
                VSync = chkVSync.Checked,
                UpScaling = chkUpscaling.Checked,
                RayTracing = chkRayTracing.Checked,
                Fullscreen = chkFullscreen.Checked,
                RenderDistance = (int)nudRenderDistance.Value,
                FieldOfView = trkFieldOfView.Value,
                Music = trkMusic.Value,
                Sound = trkSound.Value,
                HUDDTransparency = trkHuddTransparency.Value,
                ShowCoordinates = chkShowCoordinates.Checked,
                CameraPerspective = cboCameraProspective.SelectedItem.ToString()
            };

            // Add the newly created profile to the profiles list
            PlayerProfile.Profiles.Add(newProfile);

            // Save profiles
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Profile Files (*.profiles)|*.profiles|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Profiles to File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Save the profiles to the file
                        Tools.SaveProfilesToFile(PlayerProfile.Profiles, saveFileDialog.FileName);
                        MessageBox.Show("Profiles saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for selecting a profile from the ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Check if the selected item is a PlayerProfile  
            if (lbxProfiles.SelectedItem is PlayerProfile selectedProfile)
            {
                // Use the selected profile directly  
                PopulateCharacterDetails(selectedProfile);
            }
            else
            {
                MessageBox.Show("Select a valid profile from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Event handler for loading profiles from a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Profile Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Load Profiles from File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load profiles from file
                        var profiles = Tools.LoadProfilesFromFile(openFileDialog.FileName);
                        if (profiles != null && profiles.Any())
                        {
                            PlayerProfile.Profiles.Clear();  // Clear existing profiles
                            PlayerProfile.Profiles.AddRange(profiles);  // Add new profiles
                            PopulateProfiles();  // Populate ListBox with profiles

                            // Automatically select the first profile in the ListBox
                            lbxProfiles.SelectedIndex = 0;  // Select the first profile

                            MessageBox.Show("Profiles loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No profiles found in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}