using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            black_swan();
        }
        private void black_swan()
        {
            MessageBox.Show("임수환");
        }
        private void black_swan(string name)
        {
            MessageBox.Show(name);
        }
        private void black_swan(string name, string name2)
        {
            MessageBox.Show(name+name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            black_swan(button2.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            black_swan(button2.Text, button1.Text);
        }
    }
}
