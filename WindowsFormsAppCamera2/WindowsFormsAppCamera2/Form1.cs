using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsAppCamera2
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if(buttonStartStop.Text.Equals("Start"))
            {
                CaptureCamera();
                buttonStartStop.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                buttonStartStop.Text = "Start";
                isCameraRunning = false;
            }
        }

        private void buttonTakePicture_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                Bitmap snapshot = new Bitmap(pictureBox1.Image);
                snapshot.Save(string.Format(@"D:\Data\{0}.jpg",Guid.NewGuid(),ImageFormat.Jpeg));
            } else
            {
                MessageBox.Show("Cannot take a picture while the camera is off");
            }
        }
    }
}
