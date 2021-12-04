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
        int rectext = 1;
        int start = 1, end = 9;
        Random gennum = new Random();
        int num = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            PrintNum.Visible = false;
            NumText.Visible = false;
        }

        private void CheckBut_Click(object sender, EventArgs e)
        {
            string numtext = NumText.Text;
            num = gennum.Next(start*rec,end*rec);
            timeLeft = 5;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PrintNum.Visible = true;
            NumText.Text = "";
            if (timeLeft>0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer2.Stop();
                NumText.Visible = true;
                long pnum = PrintNum.Text == "" ? 0 : Convert.ToInt32(PrintNum.Text);
                if (num == pnum)
                {
                    NumText.Text = "True";
                    rec *= 10;
                    rectext += 1;
                    num = gennum.Next(start * rec, end * rec);
                    recordText.Text = $"Рекорд: {rectext}";
                    CheckBut.Visible = true;
                    PrintNum.Text = "";
                    PrintNum.Visible = false;
                }
                else
                {
                    NumText.Text = "False";
                    PrintNum.Text = "";
                    PrintNum.Visible = false;
                    rec = 1;
                    rectext = 1;
                    num = gennum.Next(start * rec, end * rec);
                    CheckBut.Visible = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NumText.Visible = true;
            NumText.Text = Convert.ToString(num);
            PrintNum.Visible = false;
            CheckBut.Visible = false;
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            } else
            {
                PrintNum.Visible = true;
                NumText.Visible = false;
                timer1.Stop();
                timeLeft = 5;
                timer2.Start();
            }
        }
    }
}
