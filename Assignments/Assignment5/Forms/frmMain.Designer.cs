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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dvgGames = new System.Windows.Forms.DataGridView();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.textReview = new System.Windows.Forms.TextBox();
            this.lblWriteReview = new System.Windows.Forms.Label();
            this.lblreview = new System.Windows.Forms.Label();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblRating = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1369, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            this.dvgGames.Location = new System.Drawing.Point(12, 46);
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
            this.dgvReviews.Size = new System.Drawing.Size(945, 138);
            this.dgvReviews.TabIndex = 3;
            // 
            // textReview
            // 
            this.textReview.Location = new System.Drawing.Point(45, 29);
            this.textReview.Multiline = true;
            this.textReview.Name = "textReview";
            this.textReview.Size = new System.Drawing.Size(488, 26);
            this.textReview.TabIndex = 4;
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
            this.btnAddReview.Location = new System.Drawing.Point(260, 384);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(158, 65);
            this.btnAddReview.TabIndex = 7;
            this.btnAddReview.Text = "Add Review";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReview.Location = new System.Drawing.Point(434, 384);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(159, 65);
            this.btnDeleteReview.TabIndex = 8;
            this.btnDeleteReview.Text = "Delete Review";
            this.btnDeleteReview.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRating);
            this.panel1.Controls.Add(this.nudRating);
            this.panel1.Controls.Add(this.btnDeleteReview);
            this.panel1.Controls.Add(this.textReview);
            this.panel1.Controls.Add(this.btnAddReview);
            this.panel1.Location = new System.Drawing.Point(764, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 452);
            this.panel1.TabIndex = 9;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 742);
            this.Controls.Add(this.lblWriteReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblreview);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.dvgGames);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
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
    }
}

