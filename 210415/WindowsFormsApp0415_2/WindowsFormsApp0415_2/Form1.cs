using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0415_2
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Account(100, textBox1.Text);
            MessageBox.Show(a1.name + a1.myMoney);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.myMoney = 1234;
            MessageBox.Show(a1.name + a1.myMoney);
            MessageBox.Show(a2.name + a2.myMoney);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int a);
            int.TryParse(textBox4.Text, out int b);
            swapFunction(a, b);
            MessageBox.Show("변경이 됐나요?");
            swapFunction(ref a, ref b); // swapFunction(ref a, ref b); : 주소값을 바꾼거라서 실질적으로 값이 바뀜
            // 함수에서 받아온 a, b를 바꿔도 실제로 바뀌지 않음
            MessageBox.Show("변경 확인하세요.");
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경됐습니다.");

            // 변경 안됨
            /*int tempA = a;
            int tempB = b;
            swapFunction(tempB, tempA, out a, out b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("다시 변경 완료!");*/
        }

        private void swapFunction(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void swapFunction(ref int a, ref int b) // ref : 주소 -> a, b의 주소
            // ref : 주소로 접근
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // 변경 안됨
        /*private void swapFunction(int a, int b, out int changeA, out int changeB)
        {
            changeA = b;
            changeB = a;
        }*/

        // out 키워드 : return과 비슷한 구조
        // 이 함수는 반환형은 없지만 2개의 변수값을 바꿈
        private void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry) // out : 매개변수의 값을 바꿈
        {
            // 다음 위치 = 현재 위치 + 현재 속도
            rx = x + vx;
            ry = y + vy;
        }

        // 반환형은 없음
        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int x);
            int.TryParse(textBox8.Text, out int y);
            int.TryParse(textBox9.Text, out int vx);
            int.TryParse(textBox10.Text, out int vy);
            MessageBox.Show($"x = {x}, y = {y}");

            NextPosition(x, y, vx, vy, out x, out y);
            // x, y, vx, vy : 값을 입력 받고 x, y의 값을 바꿔줌           
            MessageBox.Show($"x = {x}, y = {y}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //outExample(out int abc, out int def, out int hij); // 함수를 통해 변수를 선언함과 동시에 값을 지정

            int abc; // 값을 주지 않았기 때문에 0값을 줌
            int def; // 값을 주지 않았기 때문에 0값을 줌
            int hij; // 값을 주지 않았기 때문에 0값을 줌
            outExample(out abc, out def, out hij); // 함수가 호출되면서 값이 할당됨
            MessageBox.Show(abc + def + hij + "");

            foreach (var item in Controls)
            {
                // Controls : Form 안에 든 정보
                // item : Controls 안에 있는 각각의 것
                /*if (item is TextBox)
                {
                    (item as TextBox).Text = "안녕";
                }*/
                /*if ((item as TextBox) != null)
                {
                    (item as TextBox).Text = "";
                }*/
                var temp = item as TextBox; // var : 변수의 정보가 정해지지 않음
                // item as TextBox : item -> TextBox
                // as : 형변환도 해주면서 됐는지 안됐는지 체크도 해줌
                if (temp != null)
                {
                    temp.Text = "하이"; // Form안의 모든 텍스트박스 내용 변경
                }
            }
        }

        // 반환형은 없지만 매개변수로 값을 반환
        private void outExample(out int a, out int b, out int c)
        {
            a = 100;
            b = 200;
            c = 300;
        }
    }
}
