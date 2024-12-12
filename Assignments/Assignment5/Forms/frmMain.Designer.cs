namespace Assignment5
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dvgGames = new System.Windows.Forms.DataGridView();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.textReview = new System.Windows.Forms.TextBox();
            this.lblWriteReview = new System.Windows.Forms.Label();
            this.lblreview = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.toolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.lblGames = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1569, 33);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutUserToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logOutUserToolStripMenuItem
            // 
            this.logOutUserToolStripMenuItem.Name = "logOutUserToolStripMenuItem";
            this.logOutUserToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.logOutUserToolStripMenuItem.Text = "LogOut User";
            this.logOutUserToolStripMenuItem.Click += new System.EventHandler(this.logOutUserToolStripMenuItem_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 710);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1569, 32);
            this.statusStripMain.TabIndex = 1;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dvgGames
            // 
            this.dvgGames.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dvgGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGames.Location = new System.Drawing.Point(12, 100);
            this.dvgGames.Name = "dvgGames";
            this.dvgGames.ReadOnly = true;
            this.dvgGames.RowHeadersWidth = 62;
            this.dvgGames.RowTemplate.Height = 28;
            this.dvgGames.Size = new System.Drawing.Size(724, 354);
            this.dvgGames.TabIndex = 2;
            this.dvgGames.SelectionChanged += new System.EventHandler(this.dgvGames_SelectionChanged);
            // 
            // dgvReviews
            // 
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Location = new System.Drawing.Point(0, 518);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.ReadOnly = true;
            this.dgvReviews.RowHeadersWidth = 62;
            this.dgvReviews.RowTemplate.Height = 28;
            this.dgvReviews.Size = new System.Drawing.Size(915, 138);
            this.dgvReviews.TabIndex = 3;
            this.dgvReviews.SelectionChanged += new System.EventHandler(this.dgvReviews_SelectionChanged);
            // 
            // textReview
            // 
            this.textReview.Location = new System.Drawing.Point(45, 29);
            this.textReview.Multiline = true;
            this.textReview.Name = "textReview";
            this.textReview.Size = new System.Drawing.Size(488, 26);
            this.textReview.TabIndex = 4;
            this.toolTipMainForm.SetToolTip(this.textReview, "Enter Your review Here");
            // 
            // lblWriteReview
            // 
            this.lblWriteReview.AutoSize = true;
            this.lblWriteReview.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteReview.Location = new System.Drawing.Point(948, 30);
            this.lblWriteReview.Name = "lblWriteReview";
            this.lblWriteReview.Size = new System.Drawing.Size(203, 27);
            this.lblWriteReview.TabIndex = 5;
            this.lblWriteReview.Text = "Manage Review";
            // 
            // lblreview
            // 
            this.lblreview.AutoSize = true;
            this.lblreview.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreview.Location = new System.Drawing.Point(335, 483);
            this.lblreview.Name = "lblreview";
            this.lblreview.Size = new System.Drawing.Size(96, 32);
            this.lblreview.TabIndex = 6;
            this.lblreview.Text = "Review";
            // 
            // btnAddReview
            // 
            this.btnAddReview.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReview.Location = new System.Drawing.Point(106, 384);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(105, 52);
            this.btnAddReview.TabIndex = 7;
            this.btnAddReview.Text = "&Add Review";
            this.toolTipMainForm.SetToolTip(this.btnAddReview, "Click Here To Add Reviews (alt +A)");
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReview.Location = new System.Drawing.Point(351, 384);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(109, 52);
            this.btnDeleteReview.TabIndex = 8;
            this.btnDeleteReview.Text = "&Delete Review";
            this.toolTipMainForm.SetToolTip(this.btnDeleteReview, "Click Here To Delete Review (alt +D)");
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblRating);
            this.panel1.Controls.Add(this.nudRating);
            this.panel1.Controls.Add(this.btnDeleteReview);
            this.panel1.Controls.Add(this.textReview);
            this.panel1.Controls.Add(this.btnAddReview);
            this.panel1.Location = new System.Drawing.Point(764, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 452);
            this.panel1.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(223, 384);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 52);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Edit";
            this.toolTipMainForm.SetToolTip(this.btnEdit, "Click Here To Edit Reviews(alt +E)");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Harlow Solid Italic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(49, 286);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(96, 35);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Rating";
            // 
            // nudRating
            // 
            this.nudRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudRating.Location = new System.Drawing.Point(208, 292);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 26);
            this.nudRating.TabIndex = 9;
            this.nudRating.ValueChanged += new System.EventHandler(this.nudRating_ValueChanged);
            // 
            // lblGames
            // 
            this.lblGames.AutoSize = true;
            this.lblGames.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGames.Location = new System.Drawing.Point(321, 60);
            this.lblGames.Name = "lblGames";
            this.lblGames.Size = new System.Drawing.Size(84, 32);
            this.lblGames.TabIndex = 11;
            this.lblGames.Text = "Games";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 742);
            this.Controls.Add(this.lblGames);
            this.Controls.Add(this.lblWriteReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblreview);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.dvgGames);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dvgGames;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.TextBox textReview;
        private System.Windows.Forms.Label lblWriteReview;
        private System.Windows.Forms.Label lblreview;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem logOutUserToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipMainForm;
        private System.Windows.Forms.Label lblGames;
    }
}

