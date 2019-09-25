namespace MissleLauncher
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBullseyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBullseyeLowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.missilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireTwoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fireThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchAllFourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playQuickSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMediumSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playFullSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(381, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 155);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Movement Speed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(6, 119);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(117, 30);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.Value = 10;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.button7.Location = new System.Drawing.Point(87, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 18;
            this.button7.Tag = "9";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.button8.Location = new System.Drawing.Point(50, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 17;
            this.button8.Tag = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.button9.Location = new System.Drawing.Point(13, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 16;
            this.button9.Tag = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.button4.Location = new System.Drawing.Point(87, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 15;
            this.button4.Tag = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(50, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 23);
            this.button5.TabIndex = 14;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.button6.Location = new System.Drawing.Point(13, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 13;
            this.button6.Tag = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.button3.Location = new System.Drawing.Point(87, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 12;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.button2.Location = new System.Drawing.Point(50, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 11;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.button1.Location = new System.Drawing.Point(13, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 10;
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
            this.videoSourcePlayer.TabIndex = 11;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.VideoSourcePlayer_NewFrame);
            this.videoSourcePlayer.MouseLeave += new System.EventHandler(this.VideoSourcePlayer_MouseLeave);
            this.videoSourcePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayer_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(394, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Crosshairs";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(393, 197);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Show Bullseye";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnFire
            // 
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFire.Location = new System.Drawing.Point(393, 220);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(105, 34);
            this.btnFire.TabIndex = 14;
            this.btnFire.Text = "Fire!";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.BtnFire_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(387, 276);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(117, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Value = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(391, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Number of Missiles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(522, 22);
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
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.missilesToolStripMenuItem,
            this.soundsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssToolStripMenuItem,
            this.showBullseyeToolStripMenuItem,
            this.showBullseyeLowerToolStripMenuItem,
            this.toolStripSeparator1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.optionsToolStripMenuItem.Text = "Aim";
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.Checked = true;
            this.ssToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ssToolStripMenuItem.Text = "Show Crosshairs";
            // 
            // showBullseyeToolStripMenuItem
            // 
            this.showBullseyeToolStripMenuItem.Checked = true;
            this.showBullseyeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBullseyeToolStripMenuItem.Name = "showBullseyeToolStripMenuItem";
            this.showBullseyeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showBullseyeToolStripMenuItem.Text = "Show Bullseye";
            // 
            // showBullseyeLowerToolStripMenuItem
            // 
            this.showBullseyeLowerToolStripMenuItem.Checked = true;
            this.showBullseyeLowerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBullseyeLowerToolStripMenuItem.Name = "showBullseyeLowerToolStripMenuItem";
            this.showBullseyeLowerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showBullseyeLowerToolStripMenuItem.Text = "Show Bullseye (Lower)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // missilesToolStripMenuItem
            // 
            this.missilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fireTwoToolStripMenuItem,
            this.fireTwoToolStripMenuItem1,
            this.fireThreeToolStripMenuItem,
            this.launchAllFourToolStripMenuItem});
            this.missilesToolStripMenuItem.Name = "missilesToolStripMenuItem";
            this.missilesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.missilesToolStripMenuItem.Text = "Missiles";
            // 
            // fireTwoToolStripMenuItem
            // 
            this.fireTwoToolStripMenuItem.Checked = true;
            this.fireTwoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fireTwoToolStripMenuItem.Name = "fireTwoToolStripMenuItem";
            this.fireTwoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fireTwoToolStripMenuItem.Text = "Launch one";
            // 
            // fireTwoToolStripMenuItem1
            // 
            this.fireTwoToolStripMenuItem1.Name = "fireTwoToolStripMenuItem1";
            this.fireTwoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fireTwoToolStripMenuItem1.Text = "Launch two";
            // 
            // fireThreeToolStripMenuItem
            // 
            this.fireThreeToolStripMenuItem.Name = "fireThreeToolStripMenuItem";
            this.fireThreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fireThreeToolStripMenuItem.Text = "Launch three";
            // 
            // launchAllFourToolStripMenuItem
            // 
            this.launchAllFourToolStripMenuItem.Name = "launchAllFourToolStripMenuItem";
            this.launchAllFourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.launchAllFourToolStripMenuItem.Text = "Launch four";
            this.launchAllFourToolStripMenuItem.Click += new System.EventHandler(this.LaunchAllFourToolStripMenuItem_Click);
            // 
            // soundsToolStripMenuItem
            // 
            this.soundsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.toolStripSeparator2,
            this.playQuickSoundToolStripMenuItem,
            this.playMediumSoundToolStripMenuItem,
            this.playFullSoundToolStripMenuItem});
            this.soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            this.soundsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.soundsToolStripMenuItem.Text = "Sounds";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Checked = true;
            this.noneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // playQuickSoundToolStripMenuItem
            // 
            this.playQuickSoundToolStripMenuItem.Name = "playQuickSoundToolStripMenuItem";
            this.playQuickSoundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playQuickSoundToolStripMenuItem.Text = "Play quick sound";
            // 
            // playMediumSoundToolStripMenuItem
            // 
            this.playMediumSoundToolStripMenuItem.Name = "playMediumSoundToolStripMenuItem";
            this.playMediumSoundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playMediumSoundToolStripMenuItem.Text = "Play medium sound";
            // 
            // playFullSoundToolStripMenuItem
            // 
            this.playFullSoundToolStripMenuItem.Name = "playFullSoundToolStripMenuItem";
            this.playFullSoundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playFullSoundToolStripMenuItem.Text = "Play full sound";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missle Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBullseyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBullseyeLowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireTwoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fireThreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchAllFourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem playQuickSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMediumSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playFullSoundToolStripMenuItem;
    }
}

