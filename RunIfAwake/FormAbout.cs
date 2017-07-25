using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunIfAwake.Properties;

namespace RunIfAwake
{

    public partial class FormAbout : Form
    {
        private static string GetAboutText()
        {
            return Resources.About.Replace("VERNUM", "v" + Resources.Version);
        }

        public FormAbout()
        {
            InitializeComponent();
            textAbout.Rtf = GetAboutText();
        }

        private void FormAbout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void textAbout_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}