using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimeanswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            number = new Random().Next(10) + 1;
            Console.WriteLine(number);
        }

        int number = 0;
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time >= 1)
            {
                label1.Text = $"시간 경과 : {time}";
            }
            if (time>10) // 10초 이상 경과했을 때
            {
                label1.Text = "timeover!";
                time = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // try catch : 예외 처리를 하기 위한 문구 / try문에서 에러가 발생할 경우 catch(Exception)로 빠져서 그 안의 실행문을 실행
            try
            {
                int choiceNumber = int.Parse(textBox1.Text);
                if (choiceNumber == number)
                {
                    time = 0; // 타이머 리셋
                    MessageBox.Show("정답!");
                    number = new Random().Next(10) + 1;
                    Console.WriteLine(number); // 정답 다시 출력
                    label1.Text = "Finish!";
                }
                else
                {
                    if (choiceNumber > number)
                    {
                        MessageBox.Show("선택한 숫자가 정답보다 큽니다.");
                    }
                    else
                    {
                        MessageBox.Show("선택한 숫자가 정답보다 작습니다.");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("숫자를 입력하세요.");
                // 에러메세지의 두가지 표출 방법
                Console.WriteLine(ee.Message);
                Console.WriteLine(ee.StackTrace);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int choiceNumber = int.Parse(textBox1.Text);
            int choiceNumber;
            bool result = int.TryParse(textBox1.Text, out choiceNumber);
            // textBox1.Text, out choiceNumber : textBox1의 텍스트 값을 choiceNumber에 저장
            // 만약 textBox1에 문자열을 입력했다면 TryParse는 result에 false를 반환해줌
            if (result == false) // 이 if문이 없고 textBox1에 문자열을 입력했다면 choiceNumber에는 0이 들어감
            {
                MessageBox.Show("숫자를 입력하세요.");
                return;
            }
            if (choiceNumber == number)
            {
                time = 0; // 타이머 리셋
                MessageBox.Show("정답!");
                number = new Random().Next(10) + 1;
                Console.WriteLine(number); // 정답 다시 출력
                label1.Text = "Finish!";
            }
            else
            {
                if (choiceNumber > number)
                {
                    MessageBox.Show("선택한 숫자가 정답보다 큽니다.");
                }
                else
                {
                    MessageBox.Show("선택한 숫자가 정답보다 작습니다.");
                }
            }            
        }
    }
}
