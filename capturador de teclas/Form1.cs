using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace capturador_de_teclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notify.ShowBalloonTip(5 * 1000);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/yodanielo");
            Process.Start(sInfo);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.WindowState = FormWindowState.Minimized;
            notify.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void notify_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }
    }
}
