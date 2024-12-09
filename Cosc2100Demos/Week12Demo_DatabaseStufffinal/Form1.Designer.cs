namespace Week12Demo_DatabaseStufffinal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportleaguesDataSet1 = new Week12Demo_DatabaseStufffinal.SportleaguesDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamsTableAdapter1 = new Week12Demo_DatabaseStufffinal.SportleaguesDataSet1TableAdapters.teamsTableAdapter();
            this.sportleagueDataSetPlayersOnTeams = new Week12Demo_DatabaseStufffinal.SportleagueDataSetPlayersOnTeams();
            this.sportleagueDataSetPlayersOnTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersOnTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerRostersTableAdpter = new Week12Demo_DatabaseStufffinal.SportleagueDataSetPlayersOnTeamsTableAdapters.PlayerRostersTableAdpter();
            this.fkrostersplayer1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rostersTableAdapter = new Week12Demo_DatabaseStufffinal.SportleagueDataSetPlayersOnTeamsTableAdapters.rostersTableAdapter();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jerseynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleagueDataSetPlayersOnTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleagueDataSetPlayersOnTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersOnTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkrostersplayer1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamsBindingSource1;
            this.comboBox1.DisplayMember = "teamname";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "teamid";
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "teams";
            this.teamsBindingSource1.DataSource = this.sportleaguesDataSet1;
            // 
            // sportleaguesDataSet1
            // 
            this.sportleaguesDataSet1.DataSetName = "SportleaguesDataSet1";
            this.sportleaguesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.jerseynumberDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.isactiveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playersOnTeamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(970, 459);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // sportleagueDataSetPlayersOnTeams
            // 
            this.sportleagueDataSetPlayersOnTeams.DataSetName = "SportleagueDataSetPlayersOnTeams";
            this.sportleagueDataSetPlayersOnTeams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportleagueDataSetPlayersOnTeamsBindingSource
            // 
            this.sportleagueDataSetPlayersOnTeamsBindingSource.DataSource = this.sportleagueDataSetPlayersOnTeams;
            this.sportleagueDataSetPlayersOnTeamsBindingSource.Position = 0;
            this.sportleagueDataSetPlayersOnTeamsBindingSource.CurrentChanged += new System.EventHandler(this.sportleagueDataSetPlayersOnTeamsBindingSource_CurrentChanged);
            // 
            // playersOnTeamsBindingSource
            // 
            this.playersOnTeamsBindingSource.DataMember = "PlayersOnTeams";
            this.playersOnTeamsBindingSource.DataSource = this.sportleagueDataSetPlayersOnTeamsBindingSource;
            // 
            // playerRostersTableAdpter
            // 
            this.playerRostersTableAdpter.ClearBeforeFill = true;
            // 
            // fkrostersplayer1BindingSource
            // 
            this.fkrostersplayer1BindingSource.DataMember = "fk_rosters_player1";
            this.fkrostersplayer1BindingSource.DataSource = this.playersOnTeamsBindingSource;
            // 
            // rostersTableAdapter
            // 
            this.rostersTableAdapter.ClearBeforeFill = true;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "playerid";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "playerid";
            this.playeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // jerseynumberDataGridViewTextBoxColumn
            // 
            this.jerseynumberDataGridViewTextBoxColumn.DataPropertyName = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.HeaderText = "jerseynumber";
            this.jerseynumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jerseynumberDataGridViewTextBoxColumn.Name = "jerseynumberDataGridViewTextBoxColumn";
            this.jerseynumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "regnumber";
            this.regnumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // isactiveDataGridViewTextBoxColumn
            // 
            this.isactiveDataGridViewTextBoxColumn.DataPropertyName = "isactive";
            this.isactiveDataGridViewTextBoxColumn.HeaderText = "isactive";
            this.isactiveDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.isactiveDataGridViewTextBoxColumn.Name = "isactiveDataGridViewTextBoxColumn";
            this.isactiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isactiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isactiveDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleaguesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleagueDataSetPlayersOnTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportleagueDataSetPlayersOnTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersOnTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkrostersplayer1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SportleaguesDataSet1 sportleaguesDataSet1;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private SportleaguesDataSet1TableAdapters.teamsTableAdapter teamsTableAdapter1;
        private System.Windows.Forms.BindingSource sportleagueDataSetPlayersOnTeamsBindingSource;
        private SportleagueDataSetPlayersOnTeams sportleagueDataSetPlayersOnTeams;
        private System.Windows.Forms.BindingSource playersOnTeamsBindingSource;
        private SportleagueDataSetPlayersOnTeamsTableAdapters.PlayerRostersTableAdpter playerRostersTableAdpter;
        private System.Windows.Forms.BindingSource fkrostersplayer1BindingSource;
        private SportleagueDataSetPlayersOnTeamsTableAdapters.rostersTableAdapter rostersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jerseynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isactiveDataGridViewTextBoxColumn;
    }
}

