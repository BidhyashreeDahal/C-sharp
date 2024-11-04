namespace Assignment_3D_D
{
    partial class MainForm
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
            this.Characters = new System.Windows.Forms.ListBox();
            this.lblAvailableCharacters = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpCharacters = new System.Windows.Forms.GroupBox();
            this.lblStory = new System.Windows.Forms.Label();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Characters
            // 
            this.Characters.BackColor = System.Drawing.SystemColors.Window;
            this.Characters.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Characters.FormattingEnabled = true;
            this.Characters.ItemHeight = 28;
            this.Characters.Location = new System.Drawing.Point(17, 42);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(152, 368);
            this.Characters.TabIndex = 0;
            this.Characters.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblAvailableCharacters
            // 
            this.lblAvailableCharacters.AutoSize = true;
            this.lblAvailableCharacters.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableCharacters.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCharacters.Location = new System.Drawing.Point(428, 9);
            this.lblAvailableCharacters.Name = "lblAvailableCharacters";
            this.lblAvailableCharacters.Size = new System.Drawing.Size(406, 38);
            this.lblAvailableCharacters.TabIndex = 2;
            this.lblAvailableCharacters.Text = "Character Manager";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCreate.Location = new System.Drawing.Point(867, 34);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 67);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "&Create New Character";
            this.toolTip1.SetToolTip(this.btnCreate, "Click To Create New Character");
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1020, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 67);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit Character";
            this.toolTip1.SetToolTip(this.btnEdit, "Click To Edit Character(alt+E)");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpCharacters
            // 
            this.grpCharacters.BackColor = System.Drawing.Color.Transparent;
            this.grpCharacters.Controls.Add(this.lblStory);
            this.grpCharacters.Controls.Add(this.txtStory);
            this.grpCharacters.Controls.Add(this.Characters);
            this.grpCharacters.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCharacters.Location = new System.Drawing.Point(12, 61);
            this.grpCharacters.Name = "grpCharacters";
            this.grpCharacters.Size = new System.Drawing.Size(714, 425);
            this.grpCharacters.TabIndex = 5;
            this.grpCharacters.TabStop = false;
            this.grpCharacters.Text = "Available Characters";
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStory.Location = new System.Drawing.Point(306, 41);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(208, 30);
            this.lblStory.TabIndex = 3;
            this.lblStory.Text = "Background Story";
            // 
            // txtStory
            // 
            this.txtStory.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStory.Location = new System.Drawing.Point(259, 78);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStory.Size = new System.Drawing.Size(389, 258);
            this.txtStory.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExit.Location = new System.Drawing.Point(1118, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit (alt+x)");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Assignment_3D_D.Properties.Resources.dICE;
            this.pictureBox1.Location = new System.Drawing.Point(809, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Assignment_3D_D.Properties.Resources.R;
            this.pictureBox2.Location = new System.Drawing.Point(30, 514);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Assignment_3D_D.Properties.Resources.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1269, 710);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCharacters);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblAvailableCharacters);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpCharacters.ResumeLayout(false);
            this.grpCharacters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Characters;
        private System.Windows.Forms.Label lblAvailableCharacters;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpCharacters;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}