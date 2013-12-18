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

        public static PictureBox pbH10 = new PictureBox();
        public static PictureBox pbH01 = new PictureBox();
        public static PictureBox pbM10 = new PictureBox();
        public static PictureBox pbM01 = new PictureBox();
        public static PictureBox pbS10 = new PictureBox();
        public static PictureBox pbS01 = new PictureBox();
        
        public Control()
        {
            InitializeComponent();
        }

        public int cntdwnSeconds, cntdwnMinutes, cntdwnHours;
        DateTime NerdNewYear = DateTime.Parse("11/11/2011 23:11:11");
        DateTime startDate = DateTime.Now;

        public void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            pbH01.BackColor = Color.AliceBlue;

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

    }
}
