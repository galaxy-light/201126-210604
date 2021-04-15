using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0415
{
    public partial class Form1 : Form
    {
        // 변수 선언
        Account a1;
        Account a2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // 계좌를 개설해주는 버튼
        private void button7_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int money);
            string name = textBox2.Text;

            // 인스턴스 선언
            a1 = new Account(money, name);

            string message = a1.name + "님, " + "잔액은 " + a1.myMoney + "입니다.";

            foreach (var item in Controls)
            // foreach : 배열안의 요소를 끝까지(마지막 인덱스까지) 반복해줌 
            // var : 타입이 정해져 있지 않은 변수 -> Controls 자리에 다양한 타입이 오기 때문에
            // item : 배열이나 리스트안에 있는 구성 요소를 의미
            // Controls : form창 안에 있는 button이나 textbox 등을 모아놓은 리스트
            {
                if (item is Label) // (item is Label) : true / false 체크
                {
                    if ((item as Label).Name == "temp") // (item as Label) : item을 Label로 형변환(타입변환)
                    {
                        Controls.Remove((item as Label));
                    }
                }
            }

            Label msg = new Label();
            msg.Name = "temp";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(50, 150);
            Controls.Add(msg);
        }

        // 계좌를 개설해주는 버튼
        private void button8_Click(object sender, EventArgs e)
        {
            // 참조변수 : 클래스를 통해 만든 변수 : 주소값을 가짐
            /*a2 = a1; // a1이나 a2 둘 다 똑같은 위치(주소값)를 가르킴
            a2.name = textBox3.Text;
            a2.myMoney = int.Parse(textBox4.Text);*/

            // a1 = a1; // 참조변수의 특성상 문제 발생
            // 문제 해결
            /*a2 = new Account(a1.myMoney, a1.name);
            a2.myMoney = int.Parse(textBox4.Text);
            a2.name = textBox3.Text;*/

            int.TryParse(textBox4.Text, out int money);
            string name = textBox3.Text;

            // 인스턴스 변수 선언
            a2 = new Account(money, name); 

            string message = a2.name + "님, " + "잔액은 " + a2.myMoney + "입니다.";

            foreach (var item in Controls)
            {
                if (item is Label)
                {
                    if ((item as Label).Name == "temp2" || (item as Label).Name == "temp3")
                    {
                        Controls.Remove((item as Label));
                    }
                }
            }
            
            Label msg = new Label();
            msg.Name = "temp2";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(285, 150);
            Controls.Add(msg);

            Label msg2 = new Label();
            msg2.Text = a2.name + a2.myMoney;                      
            msg2.AutoSize = true;
            msg2.Location = new Point(285, 200);
            msg.Name = "temp3";
            Controls.Add(msg2);

            //MessageBox.Show("a1 : " + a1.name + a1.myMoney);
            //MessageBox.Show("a2 : " + a2.name + a2.myMoney);
        }
    }
}
