using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FilterInfoCollection VideoCaptureDevices;
       
        private VideoCaptureDevice FinalVideoDevice;
        private VideoCaptureDevice FinalVideoDevice2;
        private VideoCaptureDevice FinalVideoDevice3;
        private VideoCaptureDevice FinalVideoDevice4;

        public int j = 0;
        private void Form1_Load(object sender, EventArgs e)
        {   
            
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            try
            {

                foreach (FilterInfo VidCapDev in VideoCaptureDevices)
                {
                    var i = VidCapDev.MonikerString;

                    j = j + 1;
                    
                   
                    if (j == 1)
                    {
                        comboBox1.Items.Add("Camera " + j);
                        comboBox1.SelectedIndex = 0;
                        FinalVideoDevice = new VideoCaptureDevice(i);
                        FinalVideoDevice.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame);
                        FinalVideoDevice.Start();
                    }
                    if (j == 2)
                    {
                        comboBox2.Items.Add("Camera " + j);
                        comboBox2.SelectedIndex = 0;
                        FinalVideoDevice2 = new VideoCaptureDevice(i);
                        FinalVideoDevice2.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame2);
                        FinalVideoDevice2.Start();
                    }
                    if (j == 3)
                    {
                        comboBox3.Items.Add("Camera " + j);
                        comboBox3.SelectedIndex = 0;
                        FinalVideoDevice3 = new VideoCaptureDevice(i);
                        FinalVideoDevice3.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame3);
                        FinalVideoDevice3.Start();
                    }
                    if (j == 4)
                    {
                        comboBox4.Items.Add("Camera " + j);
                        comboBox4.SelectedIndex = 0;
                        FinalVideoDevice4 = new VideoCaptureDevice(i);
                        FinalVideoDevice4.NewFrame += new NewFrameEventHandler(FinalVideoDevice_NewFrame4);
                        FinalVideoDevice4.Start();
                    }
                  
                }
            }
            catch
            {
                MessageBox.Show("No camera found. Please connect your camera and click RESET.");
            }

        }
        void FinalVideoDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            try
            {
                pictureBox1.Image = (Bitmap)e.Frame.Clone();
               
            }
            catch { }
        }

        void FinalVideoDevice_NewFrame2(object sender, NewFrameEventArgs e)
        {
            try
            {
               
                pictureBox2.Image = (Bitmap)e.Frame.Clone();
            }
            catch { }
        }

        void FinalVideoDevice_NewFrame3(object sender, NewFrameEventArgs e)
        {
            try
            {
                pictureBox3.Image = (Bitmap)e.Frame.Clone();

            }
            catch { }
        }
        void FinalVideoDevice_NewFrame4(object sender, NewFrameEventArgs e)
        {
            try
            {
                pictureBox4.Image = (Bitmap)e.Frame.Clone();

            }
            catch { }
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

