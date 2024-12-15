namespace Final_Project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.lblContacts = new System.Windows.Forms.Label();
            this.stsMainFrame = new System.Windows.Forms.StatusStrip();
            this.toolStatusStriplabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMainForm = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.stsMainFrame.SuspendLayout();
            this.msMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContacts
            // 
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(31, 114);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.RowHeadersWidth = 62;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(1126, 407);
            this.dgvContacts.TabIndex = 5;
            this.dgvContacts.SelectionChanged += new System.EventHandler(this.dgvContacts_SelectionChanged);
            // 
            // lblContacts
            // 
            this.lblContacts.AutoSize = true;
            this.lblContacts.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacts.Location = new System.Drawing.Point(24, 62);
            this.lblContacts.Name = "lblContacts";
            this.lblContacts.Size = new System.Drawing.Size(134, 39);
            this.lblContacts.TabIndex = 1;
            this.lblContacts.Text = "Contacts";
            // 
            // stsMainFrame
            // 
            this.stsMainFrame.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsMainFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusStriplabelStatus,
            this.toolStripStatusLabel1});
            this.stsMainFrame.Location = new System.Drawing.Point(0, 716);
            this.stsMainFrame.Name = "stsMainFrame";
            this.stsMainFrame.Size = new System.Drawing.Size(1179, 22);
            this.stsMainFrame.TabIndex = 2;
            this.stsMainFrame.Text = "statusStrip1";
            // 
            // toolStatusStriplabelStatus
            // 
            this.toolStatusStriplabelStatus.Name = "toolStatusStriplabelStatus";
            this.toolStatusStriplabelStatus.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // msMainForm
            // 
            this.msMainForm.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.msMainForm.Location = new System.Drawing.Point(0, 0);
            this.msMainForm.Name = "msMainForm";
            this.msMainForm.Size = new System.Drawing.Size(1179, 33);
            this.msMainForm.TabIndex = 3;
            this.msMainForm.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.deleteContactToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.ToolTipText = "Click Here to check the menu(alt+M)";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteContactToolStripMenuItem.Text = "Delete Contact";
            this.deleteContactToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::Final_Project.Properties.Resources.search;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.searchToolStripMenuItem.Text = "Search ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(498, 567);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.toolTipMainForm.SetToolTip(this.btnAdd, "Click Here to Add New Contact(alt+A)");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(654, 570);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 58);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.toolTipMainForm.SetToolTip(this.btnEdit, "Click Here to Edd the Contact(alt+E)");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(822, 574);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 58);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.toolTipMainForm.SetToolTip(this.btnDelete, "Click Here To Delete the Contact(alt+D)");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.DarkRed;
            this.btnTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTheme.BackgroundImage")));
            this.btnTheme.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTheme.Location = new System.Drawing.Point(1049, 52);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(108, 49);
            this.btnTheme.TabIndex = 0;
            this.btnTheme.Text = "Dar&k Mode";
            this.toolTipMainForm.SetToolTip(this.btnTheme, "Click Here To Change the Screen into Dark Mode. (alt+K))");
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnDelete;
            this.ClientSize = new System.Drawing.Size(1179, 738);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.stsMainFrame);
            this.Controls.Add(this.msMainForm);
            this.Controls.Add(this.lblContacts);
            this.Controls.Add(this.dgvContacts);
            this.MainMenuStrip = this.msMainForm;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.stsMainFrame.ResumeLayout(false);
            this.stsMainFrame.PerformLayout();
            this.msMainForm.ResumeLayout(false);
            this.msMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label lblContacts;
        private System.Windows.Forms.StatusStrip stsMainFrame;
        private System.Windows.Forms.MenuStrip msMainForm;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusStriplabelStatus;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTipMainForm;
    }
}