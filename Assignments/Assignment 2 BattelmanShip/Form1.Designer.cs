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
            this.components = new System.ComponentModel.Container();
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
            this.lblSunkBoat = new System.Windows.Forms.Label();
            this.lblSunkBoatCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(20, 111);
            this.dgv1.MaximumSize = new System.Drawing.Size(532, 511);
            this.dgv1.MinimumSize = new System.Drawing.Size(532, 511);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(532, 511);
            this.dgv1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dgv1, "Click in The cell to hit the Missile");
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(45, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(98, 51);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "&New Game ";
            this.toolTip1.SetToolTip(this.btnNewGame, "Click Here to Start The New Game.(alt+N)");
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click_1);
            // 
            // btnShowBoat
            // 
            this.btnShowBoat.Location = new System.Drawing.Point(167, 12);
            this.btnShowBoat.Name = "btnShowBoat";
            this.btnShowBoat.Size = new System.Drawing.Size(98, 50);
            this.btnShowBoat.TabIndex = 2;
            this.btnShowBoat.Text = "&Show Boat";
            this.toolTip1.SetToolTip(this.btnShowBoat, "Click Here to look at the Boat in the screen.(alt+S)");
            this.btnShowBoat.UseVisualStyleBackColor = true;
            this.btnShowBoat.Click += new System.EventHandler(this.btnShowBoat_Click);
            // 
            // comboBoxX
            // 
            this.comboBoxX.FormattingEnabled = true;
            this.comboBoxX.Location = new System.Drawing.Point(866, 24);
            this.comboBoxX.Name = "comboBoxX";
            this.comboBoxX.Size = new System.Drawing.Size(85, 28);
            this.comboBoxX.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxX, "Choose the row of cell you want to HIt.");
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Location = new System.Drawing.Point(866, 58);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(85, 28);
            this.comboBoxY.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBoxY, "Choose the Colum of cell you want to HIt.");
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(1072, 637);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Click Here to Exit(alt +E)");
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
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "&Attack";
            this.toolTip1.SetToolTip(this.btnAttack, "Click Here to attack The Missile.(alt+A)");
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
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.BackColor = System.Drawing.Color.RoyalBlue;
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
            // lblSunkBoat
            // 
            this.lblSunkBoat.AutoSize = true;
            this.lblSunkBoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSunkBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunkBoat.Location = new System.Drawing.Point(896, 298);
            this.lblSunkBoat.Name = "lblSunkBoat";
            this.lblSunkBoat.Size = new System.Drawing.Size(112, 25);
            this.lblSunkBoat.TabIndex = 131;
            this.lblSunkBoat.Text = "Sunk Boat";
            // 
            // lblSunkBoatCount
            // 
            this.lblSunkBoatCount.AutoSize = true;
            this.lblSunkBoatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunkBoatCount.Location = new System.Drawing.Point(1049, 298);
            this.lblSunkBoatCount.Name = "lblSunkBoatCount";
            this.lblSunkBoatCount.Size = new System.Drawing.Size(0, 25);
            this.lblSunkBoatCount.TabIndex = 132;
            // 
            // BattelShip
            // 
            this.AcceptButton = this.btnAttack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment_2_BattelmanShip.Properties.Resources.New;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1236, 775);
            this.Controls.Add(this.lblSunkBoatCount);
            this.Controls.Add(this.lblSunkBoat);
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
            this.MinimumSize = new System.Drawing.Size(1258, 831);
            this.Name = "BattelShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblSunkBoat;
        private System.Windows.Forms.Label lblSunkBoatCount;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

