using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CountdownClock
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        //public int cntdwnSeconds, cntdwnMinutes, cntdwnHours;
        DateTime NerdNewYear = DateTime.Parse("23:11:11");
        DateTime startDate = DateTime.Now;
        public static Boolean MaxToggle, IdentToggle = false;

        public static Image tHr10, tHr01, tM10, tM01, tS10, tS01;
        public static Image rI0, rI1, rI2, rI3, rI4, rI5, rI6, rI7, rI8, rI9;
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

        private Random generator;
        private Random Generator
        {
            get
            {
                if (this.generator == null)
                {
                    this.generator = new Random();
                }
                return this.generator;
            }
        }
        private static string getRandomFile(string path)
        {
            try
            {
                var extensions = new string[] { ".png", ".jpg", ".gif" };

                var di = new DirectoryInfo(path);
                return (di.GetFiles("*.*").Where(f => extensions.Contains(f.Extension.ToLower())).OrderBy(f => Guid.NewGuid()).First()).FullName;
            }
            catch { return ""; }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = NerdNewYear - DateTime.Now;
            lblCurTm.Text = DateTime.Now.ToLongTimeString();
            lblCntDwn.Text = string.Format("Days{0}, Hrs{1}, Mins{2}, Secs{3}",t.Days, t.Hours, t.Minutes, t.Seconds);

            rI0 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\0\"));
            rI1 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\1\"));
            rI2 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\2\"));
            rI3 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\3\"));
            rI4 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\4\"));
            rI5 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\5\"));
            rI6 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\6\"));
            rI7 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\7\"));
            rI8 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\8\"));
            rI9 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\9\"));
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

        private void bIdent_Click(object sender, EventArgs e)
        {
            if (IdentToggle == false)
            {
                IdentToggle = true;
            }

            tHr10 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\0\"));
            tCH10 = Color.Red;
            tCH01 = Color.Orange;
            tCM10 = Color.Yellow;
            tCM01 = Color.Green;
            tCS10 = Color.Blue;
            tCS01 = Color.Purple;

            IdentToggle = false;
        }
    }
}
