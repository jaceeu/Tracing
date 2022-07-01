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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Tracing
{
    public partial class DaTrace : Form
    {
        public DaTrace()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void DaTrace_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if(result != null)
                {
                    QRinfo.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void Fillbtn_Click(object sender, EventArgs e)
        {
            string[] Autofill = QRinfo.Lines;

            txtBox1.Text = Autofill[0];
            txtBox2.Text = Autofill[1];
            txtBox3.Text = Autofill[2];
            txtBox4.Text = Autofill[3];
            txtBox5.Text = Autofill[4];
            txtBox6.Text = Autofill[5];
        }
    }
}
