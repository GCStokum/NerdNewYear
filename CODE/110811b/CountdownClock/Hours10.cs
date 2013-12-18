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
    public partial class Hours10 : Form
    {
        public Hours10()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblH10.Text = DateTime.Now.Hour.ToString();
            this.Text = DateTime.Now.Hour.ToString() + " Hourss10";
            BackColor = Control.tCH10;

            pictureBox1.Image = Control.rI2;

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
