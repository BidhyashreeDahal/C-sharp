namespace Week02DemoA
{
    partial class frmMain
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtMySoccorTeam = new System.Windows.Forms.TextBox();
            this.lbxSoccorTeam = new System.Windows.Forms.ListBox();
            this.btndeselect = new System.Windows.Forms.Button();
            this.rtbMainText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(398, 233);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(650, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(801, 436);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(145, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(442, 93);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(92, 20);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Enter Team";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMySoccorTeam
            // 
            this.txtMySoccorTeam.Location = new System.Drawing.Point(560, 93);
            this.txtMySoccorTeam.Multiline = true;
            this.txtMySoccorTeam.Name = "txtMySoccorTeam";
            this.txtMySoccorTeam.Size = new System.Drawing.Size(376, 38);
            this.txtMySoccorTeam.TabIndex = 6;
            this.txtMySoccorTeam.Text = "zgsdfged";
            // 
            // lbxSoccorTeam
            // 
            this.lbxSoccorTeam.FormattingEnabled = true;
            this.lbxSoccorTeam.ItemHeight = 20;
            this.lbxSoccorTeam.Location = new System.Drawing.Point(2, 154);
            this.lbxSoccorTeam.Name = "lbxSoccorTeam";
            this.lbxSoccorTeam.Size = new System.Drawing.Size(236, 284);
            this.lbxSoccorTeam.TabIndex = 7;
            // 
            // btndeselect
            // 
            this.btndeselect.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeselect.Location = new System.Drawing.Point(12, 87);
            this.btndeselect.Name = "btndeselect";
            this.btndeselect.Size = new System.Drawing.Size(135, 38);
            this.btndeselect.TabIndex = 8;
            this.btndeselect.Text = "Deselect";
            this.btndeselect.UseVisualStyleBackColor = true;
            this.btndeselect.Click += new System.EventHandler(this.btndeselect_Click);
            // 
            // rtbMainText
            // 
            this.rtbMainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMainText.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMainText.Location = new System.Drawing.Point(2, -3);
            this.rtbMainText.Name = "rtbMainText";
            this.rtbMainText.Size = new System.Drawing.Size(956, 75);
            this.rtbMainText.TabIndex = 4;
            this.rtbMainText.Text = "My Soccer Team";
            this.rtbMainText.TextChanged += new System.EventHandler(this.rtbMainText_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 489);
            this.Controls.Add(this.btndeselect);
            this.Controls.Add(this.lbxSoccorTeam);
            this.Controls.Add(this.txtMySoccorTeam);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.rtbMainText);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.linkLabel1);
            this.MinimumSize = new System.Drawing.Size(889, 501);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtMySoccorTeam;
        private System.Windows.Forms.ListBox lbxSoccorTeam;
        private System.Windows.Forms.Button btndeselect;
        private System.Windows.Forms.RichTextBox rtbMainText;
    }
}