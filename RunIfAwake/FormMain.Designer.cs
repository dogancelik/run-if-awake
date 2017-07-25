using System.Drawing;

namespace RunIfAwake
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textSound = new System.Windows.Forms.TextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.numericTimeout = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.textCommand = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgListStatus = new System.Windows.Forms.ImageList(this.components);
            this.panelStart = new System.Windows.Forms.Panel();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.LinkLabel();
            this.dialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.panelStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.textSound);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.numericTimeout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.numericInterval);
            this.panel1.Controls.Add(this.textCommand);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 112);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RunIfAwake.Properties.Resources.alarm;
            this.pictureBox4.Location = new System.Drawing.Point(6, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // textSound
            // 
            this.textSound.ContextMenuStrip = this.contextMenu;
            this.textSound.Location = new System.Drawing.Point(41, 79);
            this.textSound.Name = "textSound";
            this.textSound.Size = new System.Drawing.Size(273, 20);
            this.textSound.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textSound, "Alarm sound file path");
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(134, 26);
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.selectFileToolStripMenuItem.Text = "Select file…";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RunIfAwake.Properties.Resources.timeout;
            this.pictureBox3.Location = new System.Drawing.Point(205, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // numericTimeout
            // 
            this.numericTimeout.Location = new System.Drawing.Point(243, 5);
            this.numericTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTimeout.Name = "numericTimeout";
            this.numericTimeout.Size = new System.Drawing.Size(70, 20);
            this.numericTimeout.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numericTimeout, "Answer timeout in seconds");
            this.numericTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RunIfAwake.Properties.Resources.interval;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RunIfAwake.Properties.Resources.terminal;
            this.pictureBox2.Location = new System.Drawing.Point(3, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // numericInterval
            // 
            this.numericInterval.Location = new System.Drawing.Point(41, 5);
            this.numericInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(70, 20);
            this.numericInterval.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numericInterval, "Timer interval in minutes");
            this.numericInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericInterval.ValueChanged += new System.EventHandler(this.UpdateIntervalEvent);
            // 
            // textCommand
            // 
            this.textCommand.ContextMenuStrip = this.contextMenu;
            this.textCommand.Location = new System.Drawing.Point(41, 42);
            this.textCommand.Name = "textCommand";
            this.textCommand.Size = new System.Drawing.Size(273, 20);
            this.textCommand.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textCommand, "Command to run");
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = (Icon)(resources.GetObject("$this.Icon"));
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            // 
            // imgListStatus
            // 
            this.imgListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListStatus.ImageStream")));
            this.imgListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListStatus.Images.SetKeyName(0, "play.png");
            this.imgListStatus.Images.SetKeyName(1, "stop.png");
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.buttonToggle);
            this.panelStart.Location = new System.Drawing.Point(36, 129);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(96, 29);
            this.panelStart.TabIndex = 7;
            // 
            // buttonToggle
            // 
            this.buttonToggle.AutoSize = true;
            this.buttonToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonToggle.ImageIndex = 0;
            this.buttonToggle.ImageList = this.imgListStatus;
            this.buttonToggle.Location = new System.Drawing.Point(0, 0);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(96, 29);
            this.buttonToggle.TabIndex = 1;
            this.buttonToggle.Text = "Start";
            this.buttonToggle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAbout.Location = new System.Drawing.Point(305, 141);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(66, 25);
            this.labelAbout.TabIndex = 8;
            this.labelAbout.TabStop = true;
            this.labelAbout.Text = "About";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAbout_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 173);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 212);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run If Awake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox textCommand;
        public System.Windows.Forms.NumericUpDown numericTimeout;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.TextBox textSound;
        private System.Windows.Forms.ImageList imgListStatus;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.LinkLabel labelAbout;
        private System.Windows.Forms.OpenFileDialog dialogOpen;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
    }
}

