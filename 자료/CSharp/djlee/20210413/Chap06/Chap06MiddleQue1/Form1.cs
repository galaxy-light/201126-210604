using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06MiddleQue1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox1.Text);
            double answer = read_inch_Write_Cm(param);
            label1.Text = answer.ToString();
        }
        private double read_inch_Write_Cm(int inch)
        {
            return inch * 2.54;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox2.Text);
            double answer = read_kg_Write_pound(param);
            label2.Text = answer.ToString();
        }

        private double read_kg_Write_pound(int kg)
        {
            return kg * 2.20462262;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            int r = int.Parse(textBox3.Text);
            double doolle_answer = doolle(r);
            if (doolle_answer == -1)
                return;
            double area_answer = area(r);
            if (area_answer == -1)
                return;
            label3.Text = doolle_answer.ToString();
            label4.Text = area_answer.ToString();

        }
        private double doolle(int r)
        {
            if(r<0)
            {
                MessageBox.Show(r+"은 음수입니다");
                return -1;
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }
        private double area(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r + "은 음수입니다");
                return -1;
            }
            else
            {
                return r * r * 3.14;
            }
        }
    }
}
