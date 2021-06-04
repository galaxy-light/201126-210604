using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer_function_que
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input);
            MyMath m = new MyMath();
            MessageBox.Show(textBox1.Text+"의 제곱은"+m.Power(input));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input);
            int.TryParse(textBox2.Text, out int count);
            MessageBox.Show(textBox1.Text + "의 "
                + textBox2.Text + "곱은" 
                + MyMath.Power(input,count));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int end);
            MessageBox.Show("0부터 "+end+"까지의 합은 "+MyMath.SumAll(end));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int start);
            int.TryParse(textBox4.Text, out int end);
            MessageBox.Show(start+"부터 " + end + 
                "까지의 합은 " + MyMath.SumAll(start,end));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyMath m = new MyMath();
            int.TryParse(textBox3.Text, out m.end);
            MessageBox.Show("0부터 "+m.end+"까지의 합은"+m.SumAll());

            MyMath m2 = new MyMath();
            int.TryParse(textBox4.Text, out m2.end);
            MessageBox.Show("0부터 " + m2.end + "까지의 합은" + m2.SumAll());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyMath a = new MyMath();
            a.end = 100;
            //a.abc = 100; //보호 수준때문에 접근 안 됨
        }
    }
}
