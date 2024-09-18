using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02DemoA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbMainText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            String soccerTeam = txtMySoccorTeam.Text;
            lbxSoccorTeam.Items.Add(soccerTeam);
            txtMySoccorTeam.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit Conformation", MessageBoxButtons.YesNo) == DialogResult.Yes)Application.Exit();
        }

        private void btndeselect_Click(object sender, EventArgs e)
        {
            lbxSoccorTeam.SelectedItems.Clear();
            txtMySoccorTeam.Clear();
        }
    }
}
