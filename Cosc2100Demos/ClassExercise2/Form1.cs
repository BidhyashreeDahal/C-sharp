using ClassExercise2.SportleaguesDataSet3TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'sportleaguesDataSet1.players' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'sportleaguesDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboTeams.SelectedValue != null)
            {
                int selectedTeamId = Convert.ToInt32(cboTeams.SelectedValue);

               
                playersTableAdapter.Fill(sportleaguesDataSetPlayers.players, selectedTeamId);
                dgvPlayers.DataSource = sportleaguesDataSetPlayers.players;
            }
    }
    }
}
