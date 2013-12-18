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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            Hours01 Hours01Form = new Hours01();
            Hours01Form.Show();
            Hours10 Hours10Form = new Hours10();
            Hours10Form.Show();

            Minutes01 Minutes01Form = new Minutes01();
            Minutes01Form.Show();
            Minutes10 Minutes10Form = new Minutes10();
            Minutes10Form.Show();

            Seconds01 Seconds01Form = new Seconds01();
            Seconds01Form.Show();
            Seconds10 Seconds10Form = new Seconds10();
            Seconds10Form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
