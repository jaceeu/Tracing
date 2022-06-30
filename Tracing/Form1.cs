using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracing
{
    public partial class DaTrace : Form
    {
        public DaTrace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //StreamWriter File =File.AppendText(@"Downloads\test.txt");

            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test1.txt");
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test2.txt");
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Carlo\source\test3.txt");
            file.WriteLine("Name :" + txtBox1.Text);
            file.WriteLine("Address :" + txtBox2.Text);
            file.WriteLine("Contact No. :" + txtBox3.Text);
            file.WriteLine("Time In. :" + txtBox4.Text);
            file.WriteLine("Time Out. :" + txtBox5.Text);
            file.WriteLine("Date. :" + txtBox6.Text);
            file.Close();
            MessageBox.Show("Thank you");
        }

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test1.txt");
            InfotxtBox1.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test2.txt");
            InfotxtBox2.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            StreamReader inputFile = new StreamReader(@"C:\Users\Carlo\source\test3.txt");
            InfotxtBox3.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void InfotxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfotxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfotxtBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
