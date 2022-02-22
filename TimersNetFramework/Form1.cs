using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimersNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextWriter tsw;
        private void Form1_Load(object sender, EventArgs e)
        {
            //tsw = new StreamWriter(@"..\..\timer.txt", true);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            tsw.WriteLine(label1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tsw = new StreamWriter(@"..\..\timer.txt", true);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tsw.Close();
        }

        private void BtnKnapp3_Click(object sender, EventArgs e)
        {

        }

        private void BtnKnapp4_Click(object sender, EventArgs e)
        {

        }
    }
}
