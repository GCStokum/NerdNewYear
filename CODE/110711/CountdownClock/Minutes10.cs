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
            label1.Text = DateTime.Now.Minute.ToString();
            this.Text = DateTime.Now.Minute.ToString() + " Minutes10";
        }
    }
}
