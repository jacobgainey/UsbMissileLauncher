using AForge.Video;
using AForge.Video.DirectShow;
using MissileSharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissleLauncher
{
    public partial class frmMain : Form
    {
        private int NumberOfMissiles = 1;
        private CommandCenter launcher = new CommandCenter(new ThunderMissileLauncher());

        private enum Direction
        { Up, Down, Left, Right }

        public frmMain()
        {
            InitializeComponent();
            toolStripStatusLabel5.Text = $@"Firing {NumberOfMissiles} Missile(s)";
        }

        #region ------------------------------------------------------------ Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            // enumerate video devices
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            for (int i = 0; i < videoDevices.Count; i++)
            {
                videoToolStripMenuItem.DropDownItems.Add(videoDevices[i].Name);
            }

            ToolStripMenuItem tsitem = (ToolStripMenuItem)videoToolStripMenuItem.DropDownItems[0];
            tsitem.Checked = true;

            LoadCamera(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
            launcher.Dispose();
        }

        #endregion ------------------------------------------------------------ Form Events

        #region ------------------------------------------------------------ Button Events

        private void Button_Click(object sender, EventArgs e)
        {
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
                    SmoothMove(100, Direction.Left);
                    SmoothMove(100, Direction.Right);
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

        private void BtnFire_Click(object sender, EventArgs e)
        {
            FireMissile();
        }

        #endregion ------------------------------------------------------------ Button Events

        #region --------------------------------------------------------------- Toolbar Events

        private void TsMenuItemAim_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsitem = (ToolStripMenuItem)sender;
            tsitem.Checked = !tsitem.Checked;
        }

        private void TsMenuItemMissiles_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsitem;
            foreach (var item in missilesToolStripMenuItem.DropDownItems)
            {
                tsitem = (ToolStripMenuItem)item;
                tsitem.Checked = false;
            }
            tsitem = (ToolStripMenuItem)sender;
            tsitem.Checked = true;

            NumberOfMissiles = Convert.ToInt32(tsitem.Tag);
            toolStripStatusLabel5.Text = $@"Firing {NumberOfMissiles} Missile(s)";
        }

        private void TsMenuItemSounds_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsitem;
            foreach (var item in soundsToolStripMenuItem.DropDownItems)
            {
                tsitem = (ToolStripMenuItem)item;
                tsitem.Checked = false;
            }
            tsitem = (ToolStripMenuItem)sender;
            tsitem.Checked = true;
        }

        #endregion --------------------------------------------------------------- Toolbar Events

        #region --------------------------------------------------------------- Player Events

        private void VideoSourcePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = $@"X : {e.X}";
            toolStripStatusLabel2.Text = $@"Y : {e.Y}";

            int w = videoSourcePlayer.Size.Width;
            int h = videoSourcePlayer.Size.Height;

            if ((e.X >= w / 2) && (e.Y >= h / 2))
            {
                videoSourcePlayer.Cursor = Cursors.PanSE;
            }
            else if ((e.X >= w / 2) && (e.Y <= h / 2))
            {
                videoSourcePlayer.Cursor = Cursors.PanNE;
            }
            else if ((e.X <= w / 2) && (e.Y <= h / 2))
            {
                videoSourcePlayer.Cursor = Cursors.PanNW;
            }
            else if ((e.X <= w / 2) && (e.Y >= h / 2))
            {
                videoSourcePlayer.Cursor = Cursors.PanSW;
            }
            else
            {
                videoSourcePlayer.Cursor = Cursors.Default;
            }
        }

        private void VideoSourcePlayer_MouseLeave(object sender, EventArgs e)
        {
            videoSourcePlayer.Cursor = Cursors.Default;
        }

        private void VideoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            Pen Yellow = new Pen(Color.Yellow, 2);
            Pen Green = new Pen(Color.Green, 2);
            Pen Blue = new Pen(Color.Blue, 2);
            Pen Red = new Pen(Color.Red, 2);

            int w = image.Width;
            int h = image.Height;

            using (Graphics graphics = Graphics.FromImage(image))
            {
                if (tsMenuItemCrosshairs.Checked)
                {
                    graphics.DrawLine(Yellow, new Point(w / 2, 0), new Point(w / 2, h));
                    graphics.DrawLine(Yellow, new Point(0, h / 2), new Point(w, h / 2));
                }
                if (tsMenuItemBullseye.Checked)
                {
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 27, (h / 2) - 27, 55, 55));
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 38, (h / 2) - 38, 77, 77));
                    graphics.DrawEllipse(Green, new Rectangle((w / 2) - 49, (h / 2) - 49, 99, 99));
                }
                if (tsMenuItemBullseyeL.Checked)
                {
                    graphics.DrawEllipse(Red, new Rectangle((w / 2) - 27, h - 50 - 27, 55, 55));
                    graphics.DrawEllipse(Red, new Rectangle((w / 2) - 38, h - 50 - 38, 77, 77));
                    graphics.DrawEllipse(Red, new Rectangle((w / 2) - 49, h - 50 - 49, 99, 99));
                }
            }
        }

        #endregion --------------------------------------------------------------- Player Events

        #region --------------------------------------------------------------- Methods

        private void FireMissile()
        {
            int missileCount = NumberOfMissiles;
            foreach (var item in missilesToolStripMenuItem.DropDownItems)
            {
                ToolStripMenuItem tsitem = (ToolStripMenuItem)item;
                if (tsitem.Checked)
                {
                    missileCount = Convert.ToInt32(tsitem.Tag);
                }
            }
            launcher.Fire(missileCount);

            if (tsMenuItemPlay1.Checked) PlaySoundEffect("");
            if (tsMenuItemPlay2.Checked) PlaySoundEffect("");
            if (tsMenuItemPlay3.Checked) PlaySoundEffect("");
        }

        private void PlaySoundEffect(string path)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = path;
                player.Play();
            }
            catch (Exception ex)
            {
                HandleExecptions(ex);
            }
        }

        private void SmoothMove(int distance, Direction direction)
        {
            toolStripStatusLabel3.Text = $@"Moving {direction}";
            for (int j = 0; j < 100; j++)
            {
                switch (direction)
                {
                    case Direction.Up:
                        launcher.Up(100);
                        break;

                    case Direction.Down:
                        launcher.Down(100);
                        break;

                    case Direction.Left:
                        launcher.Left(100);
                        break;

                    case Direction.Right:
                        launcher.Right(100);
                        break;

                    default:
                        break;
                }
                for (int k = 0; k < 9; k++)
                {
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                }
            }
            toolStripStatusLabel3.Text = $@"Ready";
        }

        private void LoadCamera(int index)
        {
            try
            {
                // enumerate video devices
                var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                VideoCaptureDevice videoCaptureDevice = new VideoCaptureDevice(videoDevices[index].MonikerString);

                videoCaptureDevice.Start();
                OpenVideoSource(videoCaptureDevice);
                toolStripStatusLabel4.Text = videoDevices[index].Name;
            }
            catch (Exception ex)
            {
                HandleExecptions(ex);
            }
        }

        // Open video source
        private void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // stop current video source
                CloseCurrentVideoSource();

                // start new video source
                videoSourcePlayer.VideoSource = source;
                videoSourcePlayer.Start();
            }
            catch (Exception ex)
            {
                HandleExecptions(ex);
            }
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

        private void HandleExecptions(Exception ex)
        {
            try
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                //
            }
        }

        #endregion --------------------------------------------------------------- Methods

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show(this);
        }
    }
}