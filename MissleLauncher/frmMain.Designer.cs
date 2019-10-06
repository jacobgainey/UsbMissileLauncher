namespace MissleLauncher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCrosshairs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBullseye = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBullseyeL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.missilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLaunch1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLaunch2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLaunch3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLaunch4 = new System.Windows.Forms.ToolStripMenuItem();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPlay1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPlay2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPlay3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFire);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(380, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 280);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btnFire
            // 
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Image = ((System.Drawing.Image)(resources.GetObject("btnFire.Image")));
            this.btnFire.Location = new System.Drawing.Point(17, 183);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(98, 46);
            this.btnFire.TabIndex = 11;
            this.btnFire.Text = "Fire!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Turret Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(6, 147);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(117, 30);
            this.trackBar2.TabIndex = 10;
            this.trackBar2.Value = 10;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.button7.Location = new System.Drawing.Point(83, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 3;
            this.button7.Tag = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(50, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 2;
            this.button8.Tag = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button9.Location = new System.Drawing.Point(24, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 1;
            this.button9.Tag = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(83, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 6;
            this.button4.Tag = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(50, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(17, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 4;
            this.button6.Tag = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.button3.Location = new System.Drawing.Point(83, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 9;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(50, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 8;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.button1.Location = new System.Drawing.Point(24, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 7;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoSourcePlayer.Location = new System.Drawing.Point(12, 24);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(360, 280);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayer_NewFrame);
            this.videoSourcePlayer.MouseLeave += new System.EventHandler(this.VideoSourcePlayer_MouseLeave);
            this.videoSourcePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayer_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(520, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "X : 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = "Y : 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel3.Text = "Ready";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel4.Text = "No Camera Loaded ...";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(184, 17);
            this.toolStripStatusLabel5.Spring = true;
            this.toolStripStatusLabel5.Text = "Firing 1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.videoToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.missilesToolStripMenuItem,
            this.soundsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemCrosshairs,
            this.tsMenuItemBullseye,
            this.tsMenuItemBullseyeL,
            this.toolStripSeparator1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.optionsToolStripMenuItem.Text = "Aim";
            // 
            // tsMenuItemCrosshairs
            // 
            this.tsMenuItemCrosshairs.Checked = true;
            this.tsMenuItemCrosshairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMenuItemCrosshairs.Name = "tsMenuItemCrosshairs";
            this.tsMenuItemCrosshairs.Size = new System.Drawing.Size(192, 22);
            this.tsMenuItemCrosshairs.Text = "Show Crosshairs";
            this.tsMenuItemCrosshairs.Click += new System.EventHandler(this.TsMenuItemAim_Click);
            // 
            // tsMenuItemBullseye
            // 
            this.tsMenuItemBullseye.Checked = true;
            this.tsMenuItemBullseye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMenuItemBullseye.Name = "tsMenuItemBullseye";
            this.tsMenuItemBullseye.Size = new System.Drawing.Size(192, 22);
            this.tsMenuItemBullseye.Text = "Show Bullseye";
            this.tsMenuItemBullseye.Click += new System.EventHandler(this.TsMenuItemAim_Click);
            // 
            // tsMenuItemBullseyeL
            // 
            this.tsMenuItemBullseyeL.Checked = true;
            this.tsMenuItemBullseyeL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMenuItemBullseyeL.Name = "tsMenuItemBullseyeL";
            this.tsMenuItemBullseyeL.Size = new System.Drawing.Size(192, 22);
            this.tsMenuItemBullseyeL.Text = "Show Bullseye (Lower)";
            this.tsMenuItemBullseyeL.Click += new System.EventHandler(this.TsMenuItemAim_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // missilesToolStripMenuItem
            // 
            this.missilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemLaunch1,
            this.tsMenuItemLaunch2,
            this.tsMenuItemLaunch3,
            this.tsMenuItemLaunch4});
            this.missilesToolStripMenuItem.Name = "missilesToolStripMenuItem";
            this.missilesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.missilesToolStripMenuItem.Text = "Missiles";
            // 
            // tsMenuItemLaunch1
            // 
            this.tsMenuItemLaunch1.Checked = true;
            this.tsMenuItemLaunch1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsMenuItemLaunch1.Name = "tsMenuItemLaunch1";
            this.tsMenuItemLaunch1.Size = new System.Drawing.Size(145, 22);
            this.tsMenuItemLaunch1.Tag = "1";
            this.tsMenuItemLaunch1.Text = "Launch One";
            this.tsMenuItemLaunch1.Click += new System.EventHandler(this.TsMenuItemMissiles_Click);
            // 
            // tsMenuItemLaunch2
            // 
            this.tsMenuItemLaunch2.Name = "tsMenuItemLaunch2";
            this.tsMenuItemLaunch2.Size = new System.Drawing.Size(145, 22);
            this.tsMenuItemLaunch2.Tag = "2";
            this.tsMenuItemLaunch2.Text = "Launch Two";
            this.tsMenuItemLaunch2.Click += new System.EventHandler(this.TsMenuItemMissiles_Click);
            // 
            // tsMenuItemLaunch3
            // 
            this.tsMenuItemLaunch3.Name = "tsMenuItemLaunch3";
            this.tsMenuItemLaunch3.Size = new System.Drawing.Size(145, 22);
            this.tsMenuItemLaunch3.Tag = "3";
            this.tsMenuItemLaunch3.Text = "Launch Three";
            this.tsMenuItemLaunch3.Click += new System.EventHandler(this.TsMenuItemMissiles_Click);
            // 
            // tsMenuItemLaunch4
            // 
            this.tsMenuItemLaunch4.Name = "tsMenuItemLaunch4";
            this.tsMenuItemLaunch4.Size = new System.Drawing.Size(145, 22);
            this.tsMenuItemLaunch4.Tag = "4";
            this.tsMenuItemLaunch4.Text = "Launch Four";
            this.tsMenuItemLaunch4.Click += new System.EventHandler(this.TsMenuItemMissiles_Click);
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.tsMenuItemPlay1,
            this.tsMenuItemPlay2,
            this.tsMenuItemPlay3});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.soundsToolStripMenuItem.Text = "Sounds";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Checked = true;
            this.noneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.TsMenuItemSounds_Click);
            // 
            // tsMenuItemPlay1
            // 
            this.tsMenuItemPlay1.Name = "tsMenuItemPlay1";
            this.tsMenuItemPlay1.Size = new System.Drawing.Size(165, 22);
            this.tsMenuItemPlay1.Tag = "1";
            this.tsMenuItemPlay1.Text = "Play Sound One";
            this.tsMenuItemPlay1.Click += new System.EventHandler(this.TsMenuItemSounds_Click);
            // 
            // tsMenuItemPlay2
            // 
            this.tsMenuItemPlay2.Name = "tsMenuItemPlay2";
            this.tsMenuItemPlay2.Size = new System.Drawing.Size(165, 22);
            this.tsMenuItemPlay2.Tag = "2";
            this.tsMenuItemPlay2.Text = "Play Sound Two";
            this.tsMenuItemPlay2.Click += new System.EventHandler(this.TsMenuItemSounds_Click);
            // 
            // tsMenuItemPlay3
            // 
            this.tsMenuItemPlay3.Name = "tsMenuItemPlay3";
            this.tsMenuItemPlay3.Size = new System.Drawing.Size(165, 22);
            this.tsMenuItemPlay3.Tag = "3";
            this.tsMenuItemPlay3.Text = "Play Sound Three";
            this.tsMenuItemPlay3.Click += new System.EventHandler(this.TsMenuItemSounds_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missle Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCrosshairs;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBullseye;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBullseyeL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLaunch1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLaunch2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLaunch3;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLaunch4;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPlay1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPlay2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPlay3;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}

