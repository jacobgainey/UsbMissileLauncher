using System;
using System.Drawing;
using System.Windows.Forms;
using MissileSharp;
using AForge.Video.DirectShow;
using AForge.Video;

namespace MissleLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCamera()
        {// enumerate video devices
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // create video source
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            // start the video source
            videoSource.Start();
            OpenVideoSource(videoSource);
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            // stop current video source
            CloseCurrentVideoSource();

            // start new video source
            videoSourcePlayer.VideoSource = source;
            videoSourcePlayer.Start();
        }        
        
        // Close video source if it is running
        private void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var launcher = new CommandCenter(new ThunderMissileLauncher());

            Button button = (Button)sender;
            switch (Convert.ToInt32(button.Tag))
            {
                case 1:
                    for (int i = 1; i < 4; i++)
                    {
                        launcher.Down(25);
                        launcher.Left(25);
                    }
                    break;
                case 2:
                    launcher.Down(25 * trackBar2.Value);
                    break;
                case 3:
                    for (int i = 1; i < 4; i++)
                    {
                        launcher.Down(25);
                        launcher.Right(25);
                    }
                    break;
                case 4:
                    launcher.Left(25 * trackBar2.Value);
                    break;
                case 5:
                    break;
                case 6:
                    launcher.Right(25 * trackBar2.Value);
                    break;
                case 7:
                    for (int i = 1; i < 4; i++)
                    {
                        launcher.Up(25);
                        launcher.Left(25);
                    }
                    break;
                case 8:
                    launcher.Up(25 * trackBar2.Value);
                    break;
                case 9:
                    for (int i = 1; i < 4; i++)
                    {
                        launcher.Up(25);
                        launcher.Right(25);
                    }
                    break;
                default:
                    break;
            }
        }

        private void VideoSourcePlayer1_NewFrame(object sender, ref System.Drawing.Bitmap image)
        {
            Pen Yellow = new Pen(Color.Yellow, 2);
            Pen Green = new Pen(Color.Green, 2);
            Pen Blue = new Pen(Color.Blue, 2);
            Pen Red = new Pen(Color.Red, 2);

            int w = image.Width;
            int h = image.Height;

            using (Graphics graphics = Graphics.FromImage(image))
            {
                if (checkBox1.Checked)
                {
                    graphics.DrawLine(Yellow, new Point(w / 2, 0), new Point(w / 2, h));
                    graphics.DrawLine(Yellow, new Point(0, h / 2), new Point(w, h / 2));
                }
                if (checkBox2.Checked)
                {
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 27, (h / 2) - 27, 55, 55));
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 38, (h / 2) - 38, 77, 77));
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 49, (h / 2) - 49, 99, 99));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCamera();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void BtnFire_Click(object sender, EventArgs e)
        {
            var launcher = new CommandCenter(new ThunderMissileLauncher());
            launcher.Fire(trackBar1.Value);
        }
    }
}
