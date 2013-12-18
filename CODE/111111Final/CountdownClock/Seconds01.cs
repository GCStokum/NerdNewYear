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
    public partial class Seconds01 : Form
    {
        public Seconds01()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (DateTime.Now.Second.ToString().Length < 2)
            { lblS01.Text = DateTime.Now.Second.ToString(); }
            else {lblS01.Text = DateTime.Now.Second.ToString().Substring(1); }

            this.Text = lblS01.Text + " Seconds01";
            */
            pictureBox1.Image = Control.tS01;

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
