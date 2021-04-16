using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();
        // TestDelegate : 일종의 자료형 / 반환형과 매개변수가 없는 함수를 저장할 수 있음
        // TestDelegate : 함수의 변수화

        public Form1()
        {
            InitializeComponent();

            // 함수의 변수화 : 델리게이트
            /*Button button2 = new Button();
            button2.Text = "코드로 만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(60, 200);
            button2.Click += Button2_Click; // +=까지 입력하고 tab키 두번
            button2.Click += Button2_Click1;
            Controls.Add(button2);*/

            Button button2 = new Button();
            button2.Text = "코드로 만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(60, 200);
            button2.Click += Button2_Click; // +=까지 입력하고 tab키 두번
            button2.Click += Button2_Click1;
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Test delegate");
            };
            button2.Click += (object sender, EventArgs e) => { MessageBox.Show("Lamda"); };               
            Controls.Add(button2);
        }

        private void Button2_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello;
            TestDelegate b = delegate () { MessageBox.Show("안녕!"); }; // 무명함수 : 함수에 이름이 없는 함수
            TestDelegate c = () => { MessageBox.Show("안녕!"); }; // => : 람다 : delegate를 뜻함

            a(); // Hello() 호출
            b(); // Hello() 호출
            c(); // Hello() 호출
            exCallBack(a);
        }

        private void Hello()
        {
            MessageBox.Show("안녕!");
        }

        private void exCallBack(TestDelegate t) //  exCallBack() : 함수를 매개변수로 받는 것
        {
            for (int i = 0; i < 3; i++)            
            {
                t(); // 함수를 매개변수로 받아서 세번 호출
            }
        }
    }
}
