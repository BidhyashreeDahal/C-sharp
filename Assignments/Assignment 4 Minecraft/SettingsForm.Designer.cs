namespace Assignment_4_Minecraft
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcMovement = new System.Windows.Forms.TabPage();
            this.chkInvertYAxis = new System.Windows.Forms.CheckBox();
            this.lblInvertYAxis = new System.Windows.Forms.Label();
            this.nudControllerSensitivity = new System.Windows.Forms.NumericUpDown();
            this.lblControllerSensitivity = new System.Windows.Forms.Label();
            this.nudMouseSensitivity = new System.Windows.Forms.NumericUpDown();
            this.lblMouseSensitivity = new System.Windows.Forms.Label();
            this.chkAutoJump = new System.Windows.Forms.CheckBox();
            this.lblAutoJump = new System.Windows.Forms.Label();
            this.cboInputDevices = new System.Windows.Forms.ComboBox();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.tcAudio = new System.Windows.Forms.TabPage();
            this.trkSound = new System.Windows.Forms.TrackBar();
            this.trkMusic = new System.Windows.Forms.TrackBar();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.tcInterface = new System.Windows.Forms.TabPage();
            this.cboCameraProspective = new System.Windows.Forms.ComboBox();
            this.chkShowCoordinates = new System.Windows.Forms.CheckBox();
            this.trkHuddTransparency = new System.Windows.Forms.TrackBar();
            this.lblCameraPerspective = new System.Windows.Forms.Label();
            this.lblShowCoordinates = new System.Windows.Forms.Label();
            this.lblHuddTransparency = new System.Windows.Forms.Label();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tcVideo = new System.Windows.Forms.TabPage();
            this.chkUpscaling = new System.Windows.Forms.CheckBox();
            this.chkRayTracing = new System.Windows.Forms.CheckBox();
            this.trkFieldOfView = new System.Windows.Forms.TrackBar();
            this.nudRenderDistance = new System.Windows.Forms.NumericUpDown();
            this.chkFullscreen = new System.Windows.Forms.CheckBox();
            this.chkVSync = new System.Windows.Forms.CheckBox();
            this.chkFancyGraphics = new System.Windows.Forms.CheckBox();
            this.lblUpscaling = new System.Windows.Forms.Label();
            this.lblRayTracing = new System.Windows.Forms.Label();
            this.lblFieldOfView = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.lblFancyGraphics = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.lblRebderDistance = new System.Windows.Forms.Label();
            this.lblVsync = new System.Windows.Forms.Label();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblSettingTitle = new System.Windows.Forms.Label();
            this.lbxProfiles = new System.Windows.Forms.ListBox();
            this.lblAvailableProfiles = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbUniquelName = new System.Windows.Forms.Label();
            this.txtnameValue = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudControllerSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSensitivity)).BeginInit();
            this.tcAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMusic)).BeginInit();
            this.tcInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkHuddTransparency)).BeginInit();
            this.tcSettings.SuspendLayout();
            this.tcVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFieldOfView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMovement
            // 
            this.tcMovement.Controls.Add(this.chkInvertYAxis);
            this.tcMovement.Controls.Add(this.lblInvertYAxis);
            this.tcMovement.Controls.Add(this.nudControllerSensitivity);
            this.tcMovement.Controls.Add(this.lblControllerSensitivity);
            this.tcMovement.Controls.Add(this.nudMouseSensitivity);
            this.tcMovement.Controls.Add(this.lblMouseSensitivity);
            this.tcMovement.Controls.Add(this.chkAutoJump);
            this.tcMovement.Controls.Add(this.lblAutoJump);
            this.tcMovement.Controls.Add(this.cboInputDevices);
            this.tcMovement.Controls.Add(this.lblInputDevice);
            this.tcMovement.Location = new System.Drawing.Point(4, 29);
            this.tcMovement.Name = "tcMovement";
            this.tcMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tcMovement.Size = new System.Drawing.Size(648, 493);
            this.tcMovement.TabIndex = 3;
            this.tcMovement.Text = "Movement";
            this.toolTip1.SetToolTip(this.tcMovement, "Click to change the clicked status");
            this.tcMovement.UseVisualStyleBackColor = true;
            // 
            // chkInvertYAxis
            // 
            this.chkInvertYAxis.AutoSize = true;
            this.chkInvertYAxis.Location = new System.Drawing.Point(165, 316);
            this.chkInvertYAxis.Name = "chkInvertYAxis";
            this.chkInvertYAxis.Size = new System.Drawing.Size(22, 21);
            this.chkInvertYAxis.TabIndex = 9;
            this.toolTip1.SetToolTip(this.chkInvertYAxis, "Click to change the clicked status");
            this.chkInvertYAxis.UseVisualStyleBackColor = true;
            // 
            // lblInvertYAxis
            // 
            this.lblInvertYAxis.AutoSize = true;
            this.lblInvertYAxis.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvertYAxis.Location = new System.Drawing.Point(8, 308);
            this.lblInvertYAxis.Name = "lblInvertYAxis";
            this.lblInvertYAxis.Size = new System.Drawing.Size(120, 30);
            this.lblInvertYAxis.TabIndex = 9;
            this.lblInvertYAxis.Text = "Invert Y-Axis";
            // 
            // nudControllerSensitivity
            // 
            this.nudControllerSensitivity.Location = new System.Drawing.Point(212, 232);
            this.nudControllerSensitivity.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudControllerSensitivity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudControllerSensitivity.Name = "nudControllerSensitivity";
            this.nudControllerSensitivity.Size = new System.Drawing.Size(120, 26);
            this.nudControllerSensitivity.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nudControllerSensitivity, "Change the value of Controller Sensitivity");
            this.nudControllerSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblControllerSensitivity
            // 
            this.lblControllerSensitivity.AutoSize = true;
            this.lblControllerSensitivity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControllerSensitivity.Location = new System.Drawing.Point(6, 232);
            this.lblControllerSensitivity.Name = "lblControllerSensitivity";
            this.lblControllerSensitivity.Size = new System.Drawing.Size(195, 30);
            this.lblControllerSensitivity.TabIndex = 7;
            this.lblControllerSensitivity.Text = "Controller Sensitivity";
            // 
            // nudMouseSensitivity
            // 
            this.nudMouseSensitivity.Location = new System.Drawing.Point(212, 159);
            this.nudMouseSensitivity.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudMouseSensitivity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMouseSensitivity.Name = "nudMouseSensitivity";
            this.nudMouseSensitivity.Size = new System.Drawing.Size(120, 26);
            this.nudMouseSensitivity.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nudMouseSensitivity, "Change the value of MouseSensitivity");
            this.nudMouseSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblMouseSensitivity
            // 
            this.lblMouseSensitivity.AutoSize = true;
            this.lblMouseSensitivity.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseSensitivity.Location = new System.Drawing.Point(6, 156);
            this.lblMouseSensitivity.Name = "lblMouseSensitivity";
            this.lblMouseSensitivity.Size = new System.Drawing.Size(166, 30);
            this.lblMouseSensitivity.TabIndex = 5;
            this.lblMouseSensitivity.Text = "Mouse Sensitivity";
            // 
            // chkAutoJump
            // 
            this.chkAutoJump.AutoSize = true;
            this.chkAutoJump.Checked = true;
            this.chkAutoJump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoJump.Location = new System.Drawing.Point(165, 94);
            this.chkAutoJump.Name = "chkAutoJump";
            this.chkAutoJump.Size = new System.Drawing.Size(22, 21);
            this.chkAutoJump.TabIndex = 6;
            this.chkAutoJump.UseVisualStyleBackColor = true;
            // 
            // lblAutoJump
            // 
            this.lblAutoJump.AutoSize = true;
            this.lblAutoJump.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoJump.Location = new System.Drawing.Point(6, 88);
            this.lblAutoJump.Name = "lblAutoJump";
            this.lblAutoJump.Size = new System.Drawing.Size(107, 30);
            this.lblAutoJump.TabIndex = 2;
            this.lblAutoJump.Text = "Auto-Jump";
            // 
            // cboInputDevices
            // 
            this.cboInputDevices.FormattingEnabled = true;
            this.cboInputDevices.Items.AddRange(new object[] {
            "Controller",
            "Keyboard",
            "Touch"});
            this.cboInputDevices.Location = new System.Drawing.Point(212, 37);
            this.cboInputDevices.Name = "cboInputDevices";
            this.cboInputDevices.Size = new System.Drawing.Size(185, 28);
            this.cboInputDevices.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboInputDevices, "Click to change the Input device");
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDevice.Location = new System.Drawing.Point(6, 33);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(122, 30);
            this.lblInputDevice.TabIndex = 0;
            this.lblInputDevice.Text = "Input Device";
            // 
            // tcAudio
            // 
            this.tcAudio.Controls.Add(this.trkSound);
            this.tcAudio.Controls.Add(this.trkMusic);
            this.tcAudio.Controls.Add(this.lblSound);
            this.tcAudio.Controls.Add(this.lblMusic);
            this.tcAudio.Location = new System.Drawing.Point(4, 29);
            this.tcAudio.Name = "tcAudio";
            this.tcAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tcAudio.Size = new System.Drawing.Size(648, 493);
            this.tcAudio.TabIndex = 2;
            this.tcAudio.Text = "Audio";
            this.tcAudio.UseVisualStyleBackColor = true;
            // 
            // trkSound
            // 
            this.trkSound.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trkSound.Location = new System.Drawing.Point(112, 131);
            this.trkSound.Maximum = 100;
            this.trkSound.Name = "trkSound";
            this.trkSound.Size = new System.Drawing.Size(104, 69);
            this.trkSound.TabIndex = 3;
            this.toolTip1.SetToolTip(this.trkSound, "Click to change the Sound");
            this.trkSound.Value = 100;
            // 
            // trkMusic
            // 
            this.trkMusic.BackColor = System.Drawing.Color.White;
            this.trkMusic.Location = new System.Drawing.Point(112, 25);
            this.trkMusic.Maximum = 100;
            this.trkMusic.Name = "trkMusic";
            this.trkMusic.Size = new System.Drawing.Size(104, 69);
            this.trkMusic.TabIndex = 2;
            this.toolTip1.SetToolTip(this.trkMusic, "Click to change the Music");
            this.trkMusic.Value = 100;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.Location = new System.Drawing.Point(21, 116);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(69, 30);
            this.lblSound.TabIndex = 1;
            this.lblSound.Text = "Sound";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.Location = new System.Drawing.Point(21, 38);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(65, 30);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Music";
            // 
            // tcInterface
            // 
            this.tcInterface.Controls.Add(this.cboCameraProspective);
            this.tcInterface.Controls.Add(this.chkShowCoordinates);
            this.tcInterface.Controls.Add(this.trkHuddTransparency);
            this.tcInterface.Controls.Add(this.lblCameraPerspective);
            this.tcInterface.Controls.Add(this.lblShowCoordinates);
            this.tcInterface.Controls.Add(this.lblHuddTransparency);
            this.tcInterface.Location = new System.Drawing.Point(4, 29);
            this.tcInterface.Name = "tcInterface";
            this.tcInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tcInterface.Size = new System.Drawing.Size(648, 493);
            this.tcInterface.TabIndex = 0;
            this.tcInterface.Text = "Interface";
            this.tcInterface.UseVisualStyleBackColor = true;
            // 
            // cboCameraProspective
            // 
            this.cboCameraProspective.AllowDrop = true;
            this.cboCameraProspective.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameraProspective.FormattingEnabled = true;
            this.cboCameraProspective.Items.AddRange(new object[] {
            "FirstPerson",
            "ThirdPersonFront",
            "ThirdPersonBack"});
            this.cboCameraProspective.Location = new System.Drawing.Point(255, 159);
            this.cboCameraProspective.Name = "cboCameraProspective";
            this.cboCameraProspective.Size = new System.Drawing.Size(221, 28);
            this.cboCameraProspective.TabIndex = 28;
            this.toolTip1.SetToolTip(this.cboCameraProspective, "Click to change the Camera Prespective");
            // 
            // chkShowCoordinates
            // 
            this.chkShowCoordinates.AutoSize = true;
            this.chkShowCoordinates.Location = new System.Drawing.Point(264, 95);
            this.chkShowCoordinates.Name = "chkShowCoordinates";
            this.chkShowCoordinates.Size = new System.Drawing.Size(22, 21);
            this.chkShowCoordinates.TabIndex = 27;
            this.toolTip1.SetToolTip(this.chkShowCoordinates, "Click to change the clicked status");
            this.chkShowCoordinates.UseVisualStyleBackColor = true;
            // 
            // trkHuddTransparency
            // 
            this.trkHuddTransparency.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trkHuddTransparency.Location = new System.Drawing.Point(255, 17);
            this.trkHuddTransparency.Maximum = 100;
            this.trkHuddTransparency.Minimum = 25;
            this.trkHuddTransparency.Name = "trkHuddTransparency";
            this.trkHuddTransparency.Size = new System.Drawing.Size(104, 69);
            this.trkHuddTransparency.TabIndex = 26;
            this.toolTip1.SetToolTip(this.trkHuddTransparency, "Change the HUDD Transparency");
            this.trkHuddTransparency.Value = 100;
            // 
            // lblCameraPerspective
            // 
            this.lblCameraPerspective.AccessibleName = "";
            this.lblCameraPerspective.AutoSize = true;
            this.lblCameraPerspective.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraPerspective.Location = new System.Drawing.Point(23, 155);
            this.lblCameraPerspective.Name = "lblCameraPerspective";
            this.lblCameraPerspective.Size = new System.Drawing.Size(190, 30);
            this.lblCameraPerspective.TabIndex = 2;
            this.lblCameraPerspective.Text = "Camera Prespective";
            // 
            // lblShowCoordinates
            // 
            this.lblShowCoordinates.AccessibleName = "";
            this.lblShowCoordinates.AutoSize = true;
            this.lblShowCoordinates.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowCoordinates.Location = new System.Drawing.Point(23, 87);
            this.lblShowCoordinates.Name = "lblShowCoordinates";
            this.lblShowCoordinates.Size = new System.Drawing.Size(171, 30);
            this.lblShowCoordinates.TabIndex = 1;
            this.lblShowCoordinates.Text = "Show Coordinates";
            // 
            // lblHuddTransparency
            // 
            this.lblHuddTransparency.AccessibleName = "";
            this.lblHuddTransparency.AutoSize = true;
            this.lblHuddTransparency.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuddTransparency.Location = new System.Drawing.Point(23, 17);
            this.lblHuddTransparency.Name = "lblHuddTransparency";
            this.lblHuddTransparency.Size = new System.Drawing.Size(186, 30);
            this.lblHuddTransparency.TabIndex = 0;
            this.lblHuddTransparency.Text = "HUDD Transparency";
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tcMovement);
            this.tcSettings.Controls.Add(this.tcVideo);
            this.tcSettings.Controls.Add(this.tcAudio);
            this.tcSettings.Controls.Add(this.tcInterface);
            this.tcSettings.Location = new System.Drawing.Point(394, 56);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(656, 526);
            this.tcSettings.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tcSettings, "Click to change the Settings");
            // 
            // tcVideo
            // 
            this.tcVideo.Controls.Add(this.chkUpscaling);
            this.tcVideo.Controls.Add(this.chkRayTracing);
            this.tcVideo.Controls.Add(this.trkFieldOfView);
            this.tcVideo.Controls.Add(this.nudRenderDistance);
            this.tcVideo.Controls.Add(this.chkFullscreen);
            this.tcVideo.Controls.Add(this.chkVSync);
            this.tcVideo.Controls.Add(this.chkFancyGraphics);
            this.tcVideo.Controls.Add(this.lblUpscaling);
            this.tcVideo.Controls.Add(this.lblRayTracing);
            this.tcVideo.Controls.Add(this.lblFieldOfView);
            this.tcVideo.Controls.Add(this.trkBrightness);
            this.tcVideo.Controls.Add(this.lblFancyGraphics);
            this.tcVideo.Controls.Add(this.lblFullscreen);
            this.tcVideo.Controls.Add(this.lblRebderDistance);
            this.tcVideo.Controls.Add(this.lblVsync);
            this.tcVideo.Controls.Add(this.lblBrightness);
            this.tcVideo.Location = new System.Drawing.Point(4, 29);
            this.tcVideo.Name = "tcVideo";
            this.tcVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tcVideo.Size = new System.Drawing.Size(648, 493);
            this.tcVideo.TabIndex = 1;
            this.tcVideo.Text = "Video";
            this.tcVideo.UseVisualStyleBackColor = true;
            // 
            // chkUpscaling
            // 
            this.chkUpscaling.AutoSize = true;
            this.chkUpscaling.Location = new System.Drawing.Point(533, 185);
            this.chkUpscaling.Name = "chkUpscaling";
            this.chkUpscaling.Size = new System.Drawing.Size(22, 21);
            this.chkUpscaling.TabIndex = 25;
            this.toolTip1.SetToolTip(this.chkUpscaling, "Click to change the clicked status");
            this.chkUpscaling.UseVisualStyleBackColor = true;
            // 
            // chkRayTracing
            // 
            this.chkRayTracing.AutoSize = true;
            this.chkRayTracing.Location = new System.Drawing.Point(230, 444);
            this.chkRayTracing.Name = "chkRayTracing";
            this.chkRayTracing.Size = new System.Drawing.Size(22, 21);
            this.chkRayTracing.TabIndex = 24;
            this.toolTip1.SetToolTip(this.chkRayTracing, "Click to change the clicked status");
            this.chkRayTracing.UseVisualStyleBackColor = true;
            // 
            // trkFieldOfView
            // 
            this.trkFieldOfView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trkFieldOfView.Location = new System.Drawing.Point(230, 368);
            this.trkFieldOfView.Maximum = 90;
            this.trkFieldOfView.Minimum = 60;
            this.trkFieldOfView.Name = "trkFieldOfView";
            this.trkFieldOfView.Size = new System.Drawing.Size(104, 69);
            this.trkFieldOfView.TabIndex = 23;
            this.toolTip1.SetToolTip(this.trkFieldOfView, "Change the Field Of View");
            this.trkFieldOfView.Value = 64;
            // 
            // nudRenderDistance
            // 
            this.nudRenderDistance.Location = new System.Drawing.Point(230, 311);
            this.nudRenderDistance.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudRenderDistance.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenderDistance.Name = "nudRenderDistance";
            this.nudRenderDistance.Size = new System.Drawing.Size(120, 26);
            this.nudRenderDistance.TabIndex = 22;
            this.toolTip1.SetToolTip(this.nudRenderDistance, "Change the value of Render Distance");
            this.nudRenderDistance.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // chkFullscreen
            // 
            this.chkFullscreen.AutoSize = true;
            this.chkFullscreen.Location = new System.Drawing.Point(230, 238);
            this.chkFullscreen.Name = "chkFullscreen";
            this.chkFullscreen.Size = new System.Drawing.Size(22, 21);
            this.chkFullscreen.TabIndex = 21;
            this.toolTip1.SetToolTip(this.chkFullscreen, "Click to change the clicked status");
            this.chkFullscreen.UseVisualStyleBackColor = true;
            // 
            // chkVSync
            // 
            this.chkVSync.AutoSize = true;
            this.chkVSync.Checked = true;
            this.chkVSync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVSync.Location = new System.Drawing.Point(230, 176);
            this.chkVSync.Name = "chkVSync";
            this.chkVSync.Size = new System.Drawing.Size(22, 21);
            this.chkVSync.TabIndex = 20;
            this.toolTip1.SetToolTip(this.chkVSync, "Click to change the clicked status");
            this.chkVSync.UseVisualStyleBackColor = true;
            // 
            // chkFancyGraphics
            // 
            this.chkFancyGraphics.AutoSize = true;
            this.chkFancyGraphics.Checked = true;
            this.chkFancyGraphics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFancyGraphics.Location = new System.Drawing.Point(230, 114);
            this.chkFancyGraphics.Name = "chkFancyGraphics";
            this.chkFancyGraphics.Size = new System.Drawing.Size(22, 21);
            this.chkFancyGraphics.TabIndex = 19;
            this.toolTip1.SetToolTip(this.chkFancyGraphics, "Click to change the clicked status");
            this.chkFancyGraphics.UseVisualStyleBackColor = true;
            // 
            // lblUpscaling
            // 
            this.lblUpscaling.AutoSize = true;
            this.lblUpscaling.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpscaling.Location = new System.Drawing.Point(400, 176);
            this.lblUpscaling.Name = "lblUpscaling";
            this.lblUpscaling.Size = new System.Drawing.Size(99, 30);
            this.lblUpscaling.TabIndex = 8;
            this.lblUpscaling.Text = "Upscaling";
            // 
            // lblRayTracing
            // 
            this.lblRayTracing.AutoSize = true;
            this.lblRayTracing.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRayTracing.Location = new System.Drawing.Point(21, 435);
            this.lblRayTracing.Name = "lblRayTracing";
            this.lblRayTracing.Size = new System.Drawing.Size(114, 30);
            this.lblRayTracing.TabIndex = 7;
            this.lblRayTracing.Text = "Ray Tracing";
            // 
            // lblFieldOfView
            // 
            this.lblFieldOfView.AutoSize = true;
            this.lblFieldOfView.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldOfView.Location = new System.Drawing.Point(21, 377);
            this.lblFieldOfView.Name = "lblFieldOfView";
            this.lblFieldOfView.Size = new System.Drawing.Size(127, 30);
            this.lblFieldOfView.TabIndex = 6;
            this.lblFieldOfView.Text = "Field Of View ";
            // 
            // trkBrightness
            // 
            this.trkBrightness.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trkBrightness.Location = new System.Drawing.Point(217, 44);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(126, 69);
            this.trkBrightness.TabIndex = 18;
            this.toolTip1.SetToolTip(this.trkBrightness, "Change the Brightness");
            this.trkBrightness.Value = 50;
            // 
            // lblFancyGraphics
            // 
            this.lblFancyGraphics.AutoSize = true;
            this.lblFancyGraphics.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFancyGraphics.Location = new System.Drawing.Point(21, 108);
            this.lblFancyGraphics.Name = "lblFancyGraphics";
            this.lblFancyGraphics.Size = new System.Drawing.Size(146, 30);
            this.lblFancyGraphics.TabIndex = 4;
            this.lblFancyGraphics.Text = "Fancy Graphics";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullscreen.Location = new System.Drawing.Point(21, 232);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(103, 30);
            this.lblFullscreen.TabIndex = 3;
            this.lblFullscreen.Text = "Fullscreen";
            // 
            // lblRebderDistance
            // 
            this.lblRebderDistance.AutoSize = true;
            this.lblRebderDistance.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRebderDistance.Location = new System.Drawing.Point(21, 311);
            this.lblRebderDistance.Name = "lblRebderDistance";
            this.lblRebderDistance.Size = new System.Drawing.Size(158, 30);
            this.lblRebderDistance.TabIndex = 2;
            this.lblRebderDistance.Text = "Render Distance";
            // 
            // lblVsync
            // 
            this.lblVsync.AutoSize = true;
            this.lblVsync.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVsync.Location = new System.Drawing.Point(21, 176);
            this.lblVsync.Name = "lblVsync";
            this.lblVsync.Size = new System.Drawing.Size(73, 30);
            this.lblVsync.TabIndex = 1;
            this.lblVsync.Text = "V-Sync";
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.Location = new System.Drawing.Point(21, 44);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(107, 30);
            this.lblBrightness.TabIndex = 0;
            this.lblBrightness.Text = "Brightness";
            // 
            // lblSettingTitle
            // 
            this.lblSettingTitle.AutoSize = true;
            this.lblSettingTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingTitle.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingTitle.Location = new System.Drawing.Point(372, 9);
            this.lblSettingTitle.Name = "lblSettingTitle";
            this.lblSettingTitle.Size = new System.Drawing.Size(249, 39);
            this.lblSettingTitle.TabIndex = 1;
            this.lblSettingTitle.Text = "Minecraft Settings";
            // 
            // lbxProfiles
            // 
            this.lbxProfiles.BackColor = System.Drawing.Color.White;
            this.lbxProfiles.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProfiles.FormattingEnabled = true;
            this.lbxProfiles.HorizontalExtent = 1;
            this.lbxProfiles.ItemHeight = 30;
            this.lbxProfiles.Location = new System.Drawing.Point(12, 138);
            this.lbxProfiles.Name = "lbxProfiles";
            this.lbxProfiles.Size = new System.Drawing.Size(329, 424);
            this.lbxProfiles.TabIndex = 2;
            this.lbxProfiles.SelectedIndexChanged += new System.EventHandler(this.lbxProfiles_SelectedIndexChanged);
            // 
            // lblAvailableProfiles
            // 
            this.lblAvailableProfiles.AutoSize = true;
            this.lblAvailableProfiles.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableProfiles.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableProfiles.Location = new System.Drawing.Point(33, 85);
            this.lblAvailableProfiles.Name = "lblAvailableProfiles";
            this.lblAvailableProfiles.Size = new System.Drawing.Size(248, 44);
            this.lblAvailableProfiles.TabIndex = 3;
            this.lblAvailableProfiles.Text = "Available Profiles";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Assignment_4_Minecraft.Properties.Resources.OIP;
            this.btnSave.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(709, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 62);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.btnSave, "Click here to Save the profile");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = global::Assignment_4_Minecraft.Properties.Resources.OIP;
            this.btnLoad.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(898, 589);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(152, 62);
            this.btnLoad.TabIndex = 31;
            this.btnLoad.Text = "&Load";
            this.toolTip1.SetToolTip(this.btnLoad, "Click Here to load the profile(alt+L)");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbUniquelName
            // 
            this.lbUniquelName.AutoSize = true;
            this.lbUniquelName.BackColor = System.Drawing.Color.Transparent;
            this.lbUniquelName.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUniquelName.Location = new System.Drawing.Point(61, 43);
            this.lbUniquelName.Name = "lbUniquelName";
            this.lbUniquelName.Size = new System.Drawing.Size(79, 38);
            this.lbUniquelName.TabIndex = 6;
            this.lbUniquelName.Text = "Name";
            // 
            // txtnameValue
            // 
            this.txtnameValue.Location = new System.Drawing.Point(146, 49);
            this.txtnameValue.Name = "txtnameValue";
            this.txtnameValue.Size = new System.Drawing.Size(195, 26);
            this.txtnameValue.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtnameValue, "Enter the name of the profile");
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Assignment_4_Minecraft.Properties.Resources.OIP;
            this.btnExit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(512, 589);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 62);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click Here to Exit(alt +E)");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_4_Minecraft.Properties.Resources.OIP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 663);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtnameValue);
            this.Controls.Add(this.lbUniquelName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAvailableProfiles);
            this.Controls.Add(this.lbxProfiles);
            this.Controls.Add(this.lblSettingTitle);
            this.Controls.Add(this.tcSettings);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tcMovement.ResumeLayout(false);
            this.tcMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudControllerSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSensitivity)).EndInit();
            this.tcAudio.ResumeLayout(false);
            this.tcAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkMusic)).EndInit();
            this.tcInterface.ResumeLayout(false);
            this.tcInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkHuddTransparency)).EndInit();
            this.tcSettings.ResumeLayout(false);
            this.tcVideo.ResumeLayout(false);
            this.tcVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFieldOfView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tcMovement;
        private System.Windows.Forms.CheckBox chkInvertYAxis;
        private System.Windows.Forms.Label lblInvertYAxis;
        private System.Windows.Forms.NumericUpDown nudControllerSensitivity;
        private System.Windows.Forms.Label lblControllerSensitivity;
        private System.Windows.Forms.NumericUpDown nudMouseSensitivity;
        private System.Windows.Forms.Label lblMouseSensitivity;
        private System.Windows.Forms.CheckBox chkAutoJump;
        private System.Windows.Forms.Label lblAutoJump;
        private System.Windows.Forms.ComboBox cboInputDevices;
        private System.Windows.Forms.Label lblInputDevice;
        private System.Windows.Forms.TabPage tcAudio;
        private System.Windows.Forms.TabPage tcInterface;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tcVideo;
        private System.Windows.Forms.CheckBox chkUpscaling;
        private System.Windows.Forms.CheckBox chkRayTracing;
        private System.Windows.Forms.TrackBar trkFieldOfView;
        private System.Windows.Forms.NumericUpDown nudRenderDistance;
        private System.Windows.Forms.CheckBox chkFullscreen;
        private System.Windows.Forms.CheckBox chkVSync;
        private System.Windows.Forms.CheckBox chkFancyGraphics;
        private System.Windows.Forms.Label lblUpscaling;
        private System.Windows.Forms.Label lblRayTracing;
        private System.Windows.Forms.Label lblFieldOfView;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.Label lblFancyGraphics;
        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.Label lblRebderDistance;
        private System.Windows.Forms.Label lblVsync;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.TrackBar trkSound;
        private System.Windows.Forms.TrackBar trkMusic;
        private System.Windows.Forms.Label lblCameraPerspective;
        private System.Windows.Forms.Label lblShowCoordinates;
        private System.Windows.Forms.Label lblHuddTransparency;
        private System.Windows.Forms.ComboBox cboCameraProspective;
        private System.Windows.Forms.CheckBox chkShowCoordinates;
        private System.Windows.Forms.TrackBar trkHuddTransparency;
        private System.Windows.Forms.Label lblSettingTitle;
        private System.Windows.Forms.ListBox lbxProfiles;
        private System.Windows.Forms.Label lblAvailableProfiles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbUniquelName;
        private System.Windows.Forms.TextBox txtnameValue;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExit;
    }
}