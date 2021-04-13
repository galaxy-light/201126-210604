using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("함수 결과 : " + f(int.Parse(textBox1.Text)));
        }

        private int f(int x) // f라는 이름의 함수 / int x : int타입의 x변수
        {
            return x * x + 2 * x + 1; // return x * x + 2 * x + 1; : 값을 반환
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 함수를 쓰지 않고 해보기
            //label1.Text = "" + int.Parse(textBox2.Text)*int.Parse(textBox2.Text);
            label1.Text = (int.Parse(textBox2.Text) * int.Parse(textBox2.Text)).ToString(); // 위와 동일한 구조

            // 함수를 사용해서 해보기
            MessageBox.Show(power(textBox2.Text));
            example(100, 5, 60);
            black();
        }

        private string power(string inputNumber)
        {
            return "" + int.Parse(inputNumber) * int.Parse(inputNumber);
        }

        private void example(int a, int b, int c)
        {
            int d = a + b + c;
            d = d - a + c * b;            
            MessageBox.Show("d값은 " + d + "입니다.");
        }

        private void black()
        {
            MessageBox.Show("black is simple");
        }
    }
}
