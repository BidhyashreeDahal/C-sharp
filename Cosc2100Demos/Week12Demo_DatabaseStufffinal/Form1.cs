using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Demo_DatabaseStufffinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleagueDataSetPlayersOnTeams.rosters' table. You can move, or remove it, as needed.
            this.rostersTableAdapter.Fill(this.sportleagueDataSetPlayersOnTeams.rosters);
            // TODO: This line of code loads data into the 'sportleagueDataSetPlayersOnTeams.PlayersOnTeams' table. You can move, or remove it, as needed.
            // this.playerRostersTableAdpter.Fill(this.sportleagueDataSetPlayersOnTeams.PlayersOnTeams);
            // TODO: This line of code loads data into the 'sportleaguesDataSet1.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter1.Fill(this.sportleaguesDataSet1.teams);
          

        }

        private void sportleagueDataSetPlayersOnTeamsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {  if(comboBox1.SelectedIndex> -1)
            {
                this.playerRostersTableAdpter.Fill(this.sportleagueDataSetPlayersOnTeams.PlayersOnTeams, (int)comboBox1.SelectedValue);
            }
            
        }
    }
}
