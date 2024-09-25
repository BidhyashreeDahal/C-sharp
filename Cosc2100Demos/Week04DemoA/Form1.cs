using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04DemoA
{
    public partial class Form1 : Form
    {
        public const int Y = 15; // Global Scope (not truly)   [Dont put this in the user interface)
        private const int X = 12; //File (Class scope)
        private static int W = 10; // Class scope // can not be copied or instintiated 
        private int Z = 14;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            W = Tools.RandomInt(0, 255);
            label1.Text = W.ToString();

            Z = Tools.RandomInt(0, 255);
            label2.Text = Z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            W = Tools.RandomInt(0, 255);
            label1.Text = W.ToString();
            label2.Text = Z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = W.ToString();
            label2.Text = Z.ToString();
            if(W > 128)
            {
                int W = 20; // Block Scope
                label3.Text = W.ToString();
            }
            label1.Text = W.ToString();

        }
        private void DoStuff()
        {
            int B = 0;// Local variable
            for (int i = 0; i < 100; i++) // i is the block scope
            {
                 B = i * 2;
                MessageBox.Show(B.ToString());
            }
        }
    }
}
