using System.Windows.Forms;

namespace RunIfAwake
{
    public class ExRichTextBox : RichTextBox
    {
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0007) m.Msg = 0x0008;
            base.WndProc(ref m);
        }
    }

    partial class FormAbout
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
            this.textAbout = new RunIfAwake.ExRichTextBox();
            this.SuspendLayout();
            // 
            // textAbout
            // 
            this.textAbout.BackColor = System.Drawing.SystemColors.Control;
            this.textAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.textAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAbout.Location = new System.Drawing.Point(15, 15);
            this.textAbout.Name = "textAbout";
            this.textAbout.ReadOnly = true;
            this.textAbout.Size = new System.Drawing.Size(343, 106);
            this.textAbout.TabIndex = 1;
            this.textAbout.Text = "";
            this.textAbout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.textAbout_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 136);
            this.Controls.Add(this.textAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbout_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private ExRichTextBox textAbout;
    }
}