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
    public partial class Hours01 : Form
    {
        public Hours01()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            this.Text = DateTime.Now.Hour.ToString() + " Hours01";
            //pictureBox1.BackColor = Color.Black;
            pictureBox1.BackColor = Control.pbH10.BackColor;
        }
    }
}
