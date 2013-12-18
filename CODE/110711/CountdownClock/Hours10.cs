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
        }
    }
}
