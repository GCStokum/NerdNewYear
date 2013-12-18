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

        //public int cntdwnSeconds, cntdwnMinutes, cntdwnHours;
        DateTime NerdNewYear = DateTime.Parse("11/11/2011 23:11:11");
        DateTime startDate = DateTime.Now;
        public static Boolean MaxToggle, IdentToggle = false;

        public static Image tHr10, tHr01, tM10, tM01, tS10, tS01;
        public static Color tCH10, tCH01, tCM10, tCM01, tCS10, tCS01;

        public void Form1_Load(object sender, EventArgs e)
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
            TimeSpan t = NerdNewYear - DateTime.Now;
            lblCurTm.Text = DateTime.Now.ToLongTimeString();
            lblCntDwn.Text = string.Format("Days{0}, Hrs{1}, Mins{2}, Secs{3}",t.Days, t.Hours, t.Minutes, t.Seconds);
        }

        private void bMax_Click(object sender, EventArgs e)
        {
            if (MaxToggle == false)
            {
                MaxToggle = true;
            }
            else if (MaxToggle == true)
            {
                MaxToggle = false;
            }
        }

        private void bIdent_Click_1(object sender, EventArgs e)
        {
            if (IdentToggle == false)
            {
                IdentToggle = true;
            }
            else if (IdentToggle == true)
            {
                IdentToggle = false;
            }
            tHr10 = Bitmap.FromFile(@"D:\Dropbox\CountdownClock\0\ad0.jpg");
            tCH10 = Color.Red;
            tCH01 = Color.Orange;
            tCM10 = Color.Yellow;
            tCM01 = Color.Green;
            tCS10 = Color.Blue;
            tCS01 = Color.Purple;
        }
    }
}
