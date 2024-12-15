namespace Final_Project.DBAL
{
    partial class frmAddorEdit
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlEditOrSave = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTipAddorEdit = new System.Windows.Forms.ToolTip(this.components);
            this.pnlEditOrSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(24, 79);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(129, 33);
            this.lblFullname.TabIndex = 0;
            this.lblFullname.Text = "FullName";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 135);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(192, 33);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(24, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 33);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(24, 235);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(105, 33);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // pnlEditOrSave
            // 
            this.pnlEditOrSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEditOrSave.Controls.Add(this.txtPhoneNumber);
            this.pnlEditOrSave.Controls.Add(this.txtEmail);
            this.pnlEditOrSave.Controls.Add(this.txtAddress);
            this.pnlEditOrSave.Controls.Add(this.txtfirstName);
            this.pnlEditOrSave.Controls.Add(this.lblStatus);
            this.pnlEditOrSave.Controls.Add(this.lblFullname);
            this.pnlEditOrSave.Controls.Add(this.lblAddress);
            this.pnlEditOrSave.Controls.Add(this.lblPhoneNumber);
            this.pnlEditOrSave.Controls.Add(this.lblEmail);
            this.pnlEditOrSave.Location = new System.Drawing.Point(1, 4);
            this.pnlEditOrSave.Name = "pnlEditOrSave";
            this.pnlEditOrSave.Size = new System.Drawing.Size(523, 307);
            this.pnlEditOrSave.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(237, 127);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(260, 41);
            this.txtPhoneNumber.TabIndex = 1;
            this.toolTipAddorEdit.SetToolTip(this.txtPhoneNumber, "Phone Number Of The Contact.");
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(237, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 41);
            this.txtEmail.TabIndex = 2;
            this.toolTipAddorEdit.SetToolTip(this.txtEmail, "Email of The Contact");
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(237, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 41);
            this.txtAddress.TabIndex = 3;
            this.toolTipAddorEdit.SetToolTip(this.txtAddress, "Write The Address Of The Contact");
            // 
            // txtfirstName
            // 
            this.txtfirstName.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(237, 71);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(260, 41);
            this.txtfirstName.TabIndex = 0;
            this.toolTipAddorEdit.SetToolTip(this.txtfirstName, "Write the Full name of the Contact");
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(181, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 33);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(393, 317);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 54);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "&Return";
            this.toolTipAddorEdit.SetToolTip(this.btnReturn, "Click Here To Return(alt+R)");
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(240, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.toolTipAddorEdit.SetToolTip(this.btnSave, "Click Here to Save the Contact. (alt+S)");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(534, 385);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlEditOrSave);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddorEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddorEdit";
            this.Load += new System.EventHandler(this.AddorEdit_Load);
            this.pnlEditOrSave.ResumeLayout(false);
            this.pnlEditOrSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlEditOrSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ToolTip toolTipAddorEdit;
    }
}