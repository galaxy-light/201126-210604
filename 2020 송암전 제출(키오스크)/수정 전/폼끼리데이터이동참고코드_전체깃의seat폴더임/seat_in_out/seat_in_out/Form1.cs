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

namespace seat_in_out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            //폼간 데이터 이동
            //https://link2me.tistory.com/857
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{label1.Text}를 결재할래?" );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "김밥\n";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text += "피자\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text += "국밥\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label1.Text += "짬뽕\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.vvv = label1.Text;
            f2.ShowDialog();
        }
    }
}
