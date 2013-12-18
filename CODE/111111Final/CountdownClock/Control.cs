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
                
        DateTime NerdNewYear = DateTime.Parse("23:11:11");
        DateTime startDate = DateTime.Now;
        public static Boolean MaxToggle, IdentToggle, cel = false;

        public static Image tH10, tH01, tM10, tM01, tS10, tS01; // these get picked by parsing code and then grabbed by individual forms
        public static Image rI0, rI1, rI2, rI3, rI4, rI5, rI6, rI7, rI8, rI9; // hold 0-9 for the next updates
        public static int iH10, iH01, iM10, iM01, iS10, iS01; // identifier for which image to grab
        
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
                var extensions = new string[] { ".png", ".jpg", ".jpeg", ".gif" };

                var di = new DirectoryInfo(path);
                return (di.GetFiles("*.*").Where(f => extensions.Contains(f.Extension.ToLower())).OrderBy(f => Guid.NewGuid()).First()).FullName;
            }
            catch { return ""; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurTm.Text = DateTime.Now.ToLongTimeString();

            TimeSpan t = NerdNewYear - DateTime.Now;
            lblCntDwn.Text = string.Format("Days{0}, Hrs{1}, Mins{2}, Secs{3}", t.Days, t.Hours, t.Minutes, t.Seconds);

            if (t.TotalSeconds > 0)
            {
                //HOURS
                if (t.Hours <= 24)
                {
                    tH10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Hours.ToString().Substring(0, 1)));
                    tH01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Hours.ToString().Substring(1)));
                }
                else if (t.Hours <= 9)
                {
                    tH01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Hours.ToString().Substring(0)));
                    tH10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\0\"));
                }/*
            else
            { 
                tS10 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
                tS01 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
            }*/

                //MINUTES
                if (t.Minutes <= 60)
                {
                    tM10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Minutes.ToString().Substring(0, 1)));
                    tM01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Minutes.ToString().Substring(1)));
                }
                else if (t.Minutes <= 9)
                {
                    tM01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Minutes.ToString().Substring(0)));
                    tM10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\0\"));
                }/*
            else
            { 
                tS10 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
                tS01 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
            }*/

                //SECONDS
                if (t.Seconds <= 60)
                {
                    tS10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Seconds.ToString().Substring(0, 1)));
                    tS01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Seconds.ToString().Substring(1)));
                }
                else if (t.Seconds <= 9)
                {
                    tS10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\" + t.Seconds.ToString().Substring(0)));
                    tS01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\0\"));
                }/*
            else
            { 
                tS10 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
                tS01 = Bitmap.FromFile(getRandomFile(@"D:\Dropbox\CountdownClock\"));
            }*/
            }
            else
            {
                //CELIBRATE!!!
                cel = true;
                tH10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
                tH01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
                tM10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
                tM01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
                tS10 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
                tS01 = Bitmap.FromFile(getRandomFile(@"D:\DropBox\CountdownClock\1\"));
            }
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
    }
}
