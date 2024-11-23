namespace ClassExercise2
{
    partial class Form1
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
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSetPlayers = new ClassExercise2.SportleaguesDataSet1();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet = new ClassExercise2.SportleaguesDataSet();
            this.teamsTableAdapter = new ClassExercise2.SportleaguesDataSetTableAdapters.teamsTableAdapter();
            this.playersTableAdapter = new ClassExercise2.SportleaguesDataSet1TableAdapters.playersTableAdapter();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.sportleaguesDataSetPlayers;
            // 
            // sportleaguesDataSetPlayers
            // 
            this.sportleaguesDataSetPlayers.DataSetName = "SportleaguesDataSetPlayers";
            this.sportleaguesDataSetPlayers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTeams
            // 
            this.cboTeams.DataSource = this.teamsBindingSource;
            this.cboTeams.DisplayMember = "teamname";
            this.cboTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(12, 96);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(219, 37);
            this.cboTeams.TabIndex = 2;
            this.cboTeams.ValueMember = "teamid";
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "teams";
            this.teamsBindingSource.DataSource = this.sportleaguesDataSet;
            // 
            // sportleaguesDataSet
            // 
            this.sportleaguesDataSet.DataSetName = "SportleaguesDataSet";
            this.sportleaguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToOrderColumns = true;
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.fullname,
            this.isactiveDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.playersBindingSource;
            this.dgvPlayers.Location = new System.Drawing.Point(291, 96);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 62;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.Size = new System.Drawing.Size(857, 520);
            this.dgvPlayers.TabIndex = 9;
            this.dgvPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "playerid";
            this.playeridDataGridViewTextBoxColumn.Frozen = true;
            this.playeridDataGridViewTextBoxColumn.HeaderText = "PlayerID";
            this.playeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.playeridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playeridDataGridViewTextBoxColumn.Width = 70;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "Regnumber";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.regnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Fullname";
            this.fullname.MinimumWidth = 8;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Width = 150;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "isactive";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.Width = 50;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 150;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(415, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Players in Teams";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.BackColor = System.Drawing.Color.Transparent;
            this.lblTeams.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeams.Location = new System.Drawing.Point(7, 32);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(246, 27);
            this.lblTeams.TabIndex = 11;
            this.lblTeams.Text = "Available Teams";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1300, 628);
            this.Controls.Add(this.lblTeams);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.dgvPlayers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSetPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTeams;
        private SportleaguesDataSet sportleaguesDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private SportleaguesDataSetTableAdapters.teamsTableAdapter teamsTableAdapter;
        private SportleaguesDataSet1 sportleaguesDataSetPlayers;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private SportleaguesDataSet1TableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

