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
            lblS01.Text = DateTime.Now.Second.ToString();
            this.Text = DateTime.Now.Second.ToString() + " Seconds01";
            BackColor = Control.tCS01;
            if (Control.IdentToggle == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
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
