using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountdownClock
{
    public partial class Seconds10 : Form
    {
        public Seconds10()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (DateTime.Now.Second < 10)
            { this.Text = "0"; }
            else
            {
                string sub = DateTime.Now.Second.ToString();
                this.Text = sub.Substring(0,1);
            }
            this.Text += " Seconds10";
            */

            pictureBox1.Image = Control.tS10;

            if (Control.MaxToggle == true)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

        }

        private void Seconds10_Load(object sender, EventArgs e)
        {

        }
    }
}
