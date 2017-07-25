using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace RunIfAwake
{
    public partial class FormMain : Form
    {
        Type settingsType;
        FieldInfo defaultFontField;
        FormQuestion qform;
        public readonly bool IsRunAsAdmin;

        [DefaultValue(typeof(Decimal), "1")]
        public decimal InitValue { get; set; }

        public FormMain()
        {
            settingsType = typeof(Control);
            defaultFontField = settingsType.GetField("defaultFont", BindingFlags.Static | BindingFlags.NonPublic);
            defaultFontField.SetValue(null, new Font("Segoe UI", 10.0F));

            IsRunAsAdmin = (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);

            InitializeComponent();
        }

        // Keyboard shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.Q):
                    Close();
                    return true;
                case (Keys.Control | Keys.S):
                    buttonToggle.PerformClick();
                    return true;
                case (Keys.Control | Keys.H):
                    labelAbout_LinkClicked(this, null);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CenterControl(Control ctrl)
        {
            ctrl.Left = (int)((ClientSize.Width - ctrl.Size.Width) / 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            qform = new FormQuestion();
            qform.Owner = this;
            Debug.WriteLine("Owner set");

            CenterControl(panel1);
            CenterControl(panelStart);

            if (Properties.Settings.Default.Interval != 0M)
                numericInterval.Value = Properties.Settings.Default.Interval;

            UpdateIntervalEvent(this, EventArgs.Empty);

            if (Properties.Settings.Default.Timeout != 0M)
                numericTimeout.Value = Properties.Settings.Default.Timeout;

            textCommand.Text = Properties.Settings.Default.Command ?? "";
            textSound.Text = Properties.Settings.Default.Sound ?? "";

            trayIcon.Text = Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!qform.Visible)
            {
                qform.Show(qform.Owner);
            }
        }

        private void UpdateIntervalEvent(object sender, EventArgs e)
        {
            timer.Interval = (int)numericInterval.Value * 1000 * 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleTimer(!timer.Enabled);
        }

        public void ToggleTimer(bool enable)
        {
            timer.Enabled = enable;

            if (timer.Enabled)
            {
                buttonToggle.Text = "Stop";
                buttonToggle.ImageIndex = 1;
            }
            else
            {
                buttonToggle.ImageIndex = 0;
                buttonToggle.Text = "Start";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToggleTimer(false);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            var vis = !Visible;
            ShowInTaskbar = vis;
            if (vis) Show(); else Hide();
            WindowState = vis ? FormWindowState.Normal : FormWindowState.Minimized;
            Activate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Interval = numericInterval.Value;
            Properties.Settings.Default.Timeout = numericTimeout.Value;
            Properties.Settings.Default.Command = textCommand.Text;
            Properties.Settings.Default.Sound = textSound.Text;
            Properties.Settings.Default.Save();
        }

        private void labelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var owner = item.Owner as ContextMenuStrip;
            var box = owner.SourceControl as TextBox;

            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                box.Text = dialogOpen.FileName;
            }
        }
    }
}
