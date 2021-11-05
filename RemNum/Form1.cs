using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RemNum
{
    public partial class Form1 : Form
    {
        public int timeLeft = 5;
        int rec = 1;
        int start = 1, end = 9;
        Random gennum = new Random();
        int num = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void CheckBut_Click(object sender, EventArgs e)
        {
            string numtext = NumText.Text;
            num = gennum.Next(start*rec,end*rec);
            timeLeft = 5;
            timer1.Start();
            NumText.Text = Convert.ToString(num);
            PrintNum.Visible = false;
            timeLeft = 5;
            timer1.Start();
            PrintNum.Visible = true;
            Thread.Sleep(timeLeft * 1000);
            NumText.Text = "";
            timeLeft = 5;
            timer1.Start();
            int pnum = PrintNum.Text=="" ? 0 : Convert.ToInt32(PrintNum.Text);
            if (num == pnum)
            {
                NumText.Text = "True";
                rec += 1;
            }
            else
            {
                NumText.Text = "False";
                rec = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            } else
            {
                timer1.Stop();
            }
        }
    }
}
