using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week05Collections.Properties;

namespace Week05Collections
{
    public partial class Form1 : Form
    {
        private String[] studentsOLD = { "John", "Raj", "Harmondeep", "Sally", "Wai", "Jennifer", "George" };
        private String[] friendsOLD = new string[7];
        private int[,] scores = new int[5, 19];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("The Author is" + Resources.AUTHER);
            listBox1.DataSource = students;// Students is an array
            students.Clear();
            students.Add("John");
            students.Add("Raj");
            students.Add("Harmondeep");
            students.Add("Sally");
            students.Add("Wai");
            students.Add("Jennifer");
            students.Add("George");
            UpdateLists();
            students.Sort();// Sort also changes by Index number

            
               // students.AddRange()---> Add whole list

        } // List is more advanced than array ---> Order does not matter ---> Will have index number
        // -----------------> LIST--------------------------> //List changes its size automatically
        //                                                      if we remove the item but the array does not
        // LILO
        // FIFO
        // LILO
        private List<String> students = new List<string>();
        private List<string> friends = new List<string>();

        private void UpdateLists()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = students;
            listBox2.DataSource = friends;

            label1.Text = students.Count.ToString();
            label2.Text = friends.Count.ToString();  /// Display and Values Database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count> 0)
            {
                String str =listBox1.SelectedItem.ToString();
                friends.Add(str);
                students.Remove(str);
                UpdateLists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItems.Count> 0)
            {
                students.Add(listBox2.SelectedItem.ToString());
                friends.Remove(listBox2.SelectedItem.ToString());
                UpdateLists();
            }
        }
    }
}
