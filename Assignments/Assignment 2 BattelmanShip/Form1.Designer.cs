namespace Assignment_2_BattelmanShip
{
    partial class BattelShip
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnShowBoat = new System.Windows.Forms.Button();
            this.comboBoxX = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.ProgressBarBoats = new System.Windows.Forms.ProgressBar();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblTruncount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(20, 111);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(635, 540);
            this.dgv1.TabIndex = 82;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(45, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(98, 51);
            this.btnNewGame.TabIndex = 102;
            this.btnNewGame.Text = "New Game ";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click_1);
            // 
            // btnShowBoat
            // 
            this.btnShowBoat.Location = new System.Drawing.Point(167, 12);
            this.btnShowBoat.Name = "btnShowBoat";
            this.btnShowBoat.Size = new System.Drawing.Size(98, 50);
            this.btnShowBoat.TabIndex = 103;
            this.btnShowBoat.Text = "Show Boat";
            this.btnShowBoat.UseVisualStyleBackColor = true;
            this.btnShowBoat.Click += new System.EventHandler(this.btnShowBoat_Click);
            // 
            // comboBoxX
            // 
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxX.Location = new System.Drawing.Point(866, 24);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(85, 28);
            this.comboBoxX.TabIndex = 104;
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxY.Location = new System.Drawing.Point(866, 58);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(85, 28);
            this.comboBoxY.TabIndex = 105;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1135, 722);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 50);
            this.btnExit.TabIndex = 120;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(827, 27);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 121;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(827, 61);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 126;
            this.lblY.Text = "Y";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(984, 29);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(89, 52);
            this.btnAttack.TabIndex = 127;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // ProgressBarBoats
            // 
            this.ProgressBarBoats.Location = new System.Drawing.Point(888, 133);
            this.ProgressBarBoats.Name = "ProgressBarBoats";
            this.ProgressBarBoats.Size = new System.Drawing.Size(262, 54);
            this.ProgressBarBoats.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarBoats.TabIndex = 128;
            this.ProgressBarBoats.Click += new System.EventHandler(this.ProgressBarBoats_Click);
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.Location = new System.Drawing.Point(895, 231);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(109, 25);
            this.lblTurns.TabIndex = 129;
            this.lblTurns.Text = "label Turn";
            // 
            // lblTruncount
            // 
            this.lblTruncount.AutoSize = true;
            this.lblTruncount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruncount.Location = new System.Drawing.Point(1100, 230);
            this.lblTruncount.Name = "lblTruncount";
            this.lblTruncount.Size = new System.Drawing.Size(0, 25);
            this.lblTruncount.TabIndex = 130;
            // 
            // BattelShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_2_BattelmanShip.Properties.Resources.New;
            this.ClientSize = new System.Drawing.Size(1236, 775);
            this.Controls.Add(this.lblTruncount);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.ProgressBarBoats);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxX);
            this.Controls.Add(this.btnShowBoat);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.dgv1);
            this.MaximumSize = new System.Drawing.Size(1258, 831);
            this.Name = "BattelShip";
            this.Text = "BettleShip";
            this.Load += new System.EventHandler(this.BattelShip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnShowBoat;
        private System.Windows.Forms.ComboBox comboBoxX;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ProgressBar ProgressBarBoats;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblTruncount;
    }
}

