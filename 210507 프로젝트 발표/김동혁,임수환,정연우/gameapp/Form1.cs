using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Process.Start("Snake.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("puzzle2.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("FlappyBird Windows Form.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("Snake.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("puzzle2.exe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("FlappyBird Windows Form.exe");
        }
    }
}
