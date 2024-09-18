using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = (MessageBox.Show("Hi Bidhya",
                MessageBoxButtons.YesNoCancel);
            if (dr = DialogResult.Yes) btnClickThis.Text = "Yeah!";


            {
                lblHelloWorld.Text = "Yeah";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
