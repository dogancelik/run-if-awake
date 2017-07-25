namespace RunIfAwake
{
    partial class FormQuestion
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
            this.labelCountdown = new System.Windows.Forms.Label();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCountdown
            // 
            this.labelCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountdown.Location = new System.Drawing.Point(15, 48);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(263, 22);
            this.labelCountdown.TabIndex = 0;
            this.labelCountdown.Text = "Countdown";
            this.labelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerWait
            // 
            this.timerWait.Interval = 1000;
            this.timerWait.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(15, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonAwakeClick);
            // 
            // labelHeader
            // 
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(266, 34);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Are you awake?";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 129);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCountdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionForm_FormClosing);
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.VisibleChanged += new System.EventHandler(this.QuestionForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHeader;
    }
}