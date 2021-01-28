using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 7");
            // textBox1.Text += "7"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "7"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 9");
            // textBox1.Text += "9"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "9"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 4");
            // textBox1.Text += "4"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "4"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 5");
            // textBox1.Text += "5"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "5"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 6");
            // textBox1.Text += "6"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "6"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 1");
            // textBox1.Text += "1"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "1"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 2");
            // textBox1.Text += "2"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "2"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 3");
            // textBox1.Text += "3"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "3"; // 두번째 방법

            ButtonsClick(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 0"); // 출력 창에 뜸
            // n개 출력 방법은 정적인 방법 두가지
            // textBox1.Text += "0"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "0"; // 두번째 방법

            // n개 출력 방법은 동적인 방법 두가지
            //textBox1.Text = textBox1.Text + button11.Text;
            // Button btn = (Button)sender;
            // textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("button11_Click : 8");
            // textBox1.Text += "8"; // 첫번째 방법
            // textBox1.Text = textBox1.Text + "8"; // 두번째 방법

            ButtonsClick(sender);
        }
             
        void ButtonsClick(object sender) // sender 함수
        {
            // n개 출력 방법은 동적인 방법 두가지
            //textBox1.Text = textBox1.Text + button11.Text; // 첫번째 방법
            Button btn = (Button)sender; // 두번째 방법
            textBox1.Text = textBox1.Text + btn.Text;

            // 더하기
            String[] str1 = textBox1.Text.Split("+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str1.Length == 2) 
            {
                int a1 = Convert.ToInt32(str1[0]);
                int a2 = Convert.ToInt32(str1[1]);
                int result = a1 + a2;
                // 출력하는 두가지 방법
                textBox1.Text = "" + result; // 첫번째 방법
                // textBox1.Text = string.Format("%d", result); // 두번째 방법
            }

            // 빼기
            String[] str2 = textBox1.Text.Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str2.Length == 2)
            {
                int a1 = Convert.ToInt32(str2[0]);
                int a2 = Convert.ToInt32(str2[1]);
                int result = a1 - a2;
                // 출력하는 두가지 방법
                textBox1.Text = "" + result; // 첫번째 방법
                // textBox1.Text = string.Format("%d", result); // 두번째 방법
            }

            // 곱하기
            String[] str3 = textBox1.Text.Split("*".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str3.Length == 2)
            {
                int a1 = Convert.ToInt32(str3[0]);
                int a2 = Convert.ToInt32(str3[1]);
                int result = a1 * a2;
                // 출력하는 두가지 방법
                textBox1.Text = "" + result; // 첫번째 방법
                // textBox1.Text = string.Format("%d", result); // 두번째 방법
            }

            // 나누기
            String[] str4 = textBox1.Text.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (str4.Length == 2)
            {
                int a1 = Convert.ToInt32(str4[0]);
                int a2 = Convert.ToInt32(str4[1]);
                int result = a1 / a2;
                // 출력하는 두가지 방법
                textBox1.Text = "" + result; // 첫번째 방법
                // textBox1.Text = string.Format("%d", result); // 두번째 방법
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            ButtonOperator(sender);
        }

        void ButtonOperator(object sender)
        {
            if (textBox1.Text.Length > 0)
            {
                Button btn = (Button)sender;
                if (btn.Text.Equals("+"))
                {   
                    // textBox1.Text += btn.Text;

                    // textBox1.Text값의 마지막 문자열을 가져온다.
                    String s1 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                    if (s1 == "+")
                    {
                        // textBox1.Text += btn.Text; // 이 코드가 살아있으면 +를 누를 때마다 출력됨
                    }
                    else
                    {
                        textBox1.Text += btn.Text;  
                    }
                }
                else if (btn.Text.Equals("-"))
                {
                    String s2 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                    if (s2 == "-")
                    {

                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
                else if (btn.Text.Equals("*"))
                {
                    String s3 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                    if (s3 == "*")
                    {

                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
                else if (btn.Text.Equals("/"))
                {
                    String s4 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                    if (s4 == "/")
                    {

                    }
                    else
                    {
                        textBox1.Text += btn.Text;
                    }
                }
            }
        }

        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
