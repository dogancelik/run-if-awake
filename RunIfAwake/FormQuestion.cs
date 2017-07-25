using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunIfAwake
{
    public partial class FormQuestion : Form
    {
        private int _timeout;
        private FormMain _mf;
        private SoundPlayer _sound = new SoundPlayer();

        public FormQuestion()
        {
            InitializeComponent();
            labelHeader.Font = new Font(labelHeader.Font.FontFamily, 20, FontStyle.Bold);
            labelCountdown.Font = new Font(labelCountdown.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void UpdateCountdown()
        {
            labelCountdown.Text = _timeout.ToString();
            Debug.WriteLine(DateTime.Now);
            Debug.WriteLine("_timeout: " + _timeout);
            Debug.WriteLine("timerWait.Enabled: " + timerWait.Enabled.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeout = _timeout - 1;
            UpdateCountdown();

            if (_timeout <= 0)
            {
                timerWait.Enabled = false;
                Hide();
                _mf.ToggleTimer(false);
            }
        }

        private void QuestionForm_VisibleChanged(object sender, EventArgs e)
        {
            _timeout = Convert.ToInt32(_mf.numericTimeout.Value);
            UpdateCountdown();

            if (Visible)
            {
                timerWait.Enabled = true;

                try
                {
                    _sound.SoundLocation = _mf.textSound.Text;
                    _sound.PlayLooping();
                }
                catch
                {
                }
            }
            else
            {
                StopSound();
            }
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            _mf = Owner as FormMain;
            Text = Owner.Text;
        }

        private void ButtonAwakeClick(object sender, EventArgs e)
        {
            timerWait.Enabled = false;
            Hide();

            var psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = String.Format("/C start {0}", _mf.textCommand.Text);

            if (_mf.IsRunAsAdmin)
            {
                psi.Verb = "runas";
            }

            Process.Start(psi);
        }

        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void StopSound()
        {
            _sound.Stop();
        }
    }
}
