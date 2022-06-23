using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vx=-10;
        int vy=-10;
        int score = 1000;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx)* 11 / 10;
            }

            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 11 / 10;
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 11 / 10;
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 11 / 10;

            }

            score--;
            label2.Text = $"SCORE{score}";

            if(score==0)
            {
                timer1.Enabled = false;
                MessageBox.Show("GAME OVER");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("章瑞謙");
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
