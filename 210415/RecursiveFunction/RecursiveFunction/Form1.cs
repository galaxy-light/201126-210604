using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int number);
            MessageBox.Show("1부터 " + number + "까지 합 : " + sum(number) + "이다.");
        }

        // 재귀함수 : 자기자신을 다시 호출하는 것
        private int sum(int end)
        {
            // 재귀함수는 리턴 조건(값)이 없다면 무한 루프
            if (end <= 0)
            {
                return 0;
            }
            return end + sum(end - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int num1);
            MessageBox.Show("n : " + num1 + " / " + "값 : " + multi(num1));
        }

        // 피보나치 수열
        private int multi(int num2)
        {            
            if (num2 <= 0)
            {
                return 0;
            }
            if (num2 == 1)
            {
                return 1;
            }
            if (num2 == 2)
            {
                return 1;
            }
            return multi(num2 - 2) + multi(num2 - 1);
        }
    }
}
