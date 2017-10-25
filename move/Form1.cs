using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move
{
    public partial class Form1 : Form
    {

        bool lleft = false;
        bool rright = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //timer1.Enabled = true;
            if (e.KeyCode == Keys.Left)
            {
                lleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                rright = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lleft == true)
                pictureBox1.Left = pictureBox1.Left - 2;
            if (rright == true)
                pictureBox1.Left = pictureBox1.Left + 2;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //timer1.Enabled = false;
            if (e.KeyCode == Keys.Left)
            {
                lleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                rright = false;
            }
        }
    }
}
