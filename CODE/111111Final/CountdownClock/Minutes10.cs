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
    public partial class Minutes10 : Form
    {
        public Minutes10()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (DateTime.Now.Minute < 10)
            { this.Text = "0"; }
            else
            {
                string sub = DateTime.Now.Minute.ToString();
                this.Text = sub.Substring(0, 1);
            }
            this.Text += " Minutes10";

            label1.Text = this.Text;
*/
            pictureBox1.Image = Control.tM10;
            if (Control.cel == true)
            {
                this.timer1.Interval = 1000;
            }

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
    }
}
