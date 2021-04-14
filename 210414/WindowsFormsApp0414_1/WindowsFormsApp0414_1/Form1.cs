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

namespace WindowsFormsApp0414_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 이것도 일종의 함수
        // object sender : 이벤트를 호출한 자기 자신 / EventArgs e : 이벤트 속성(이벤트에 관련된 정보들)
        {
            /*int value = int.Parse(textBox1.Text);
            label1.Text = second_demension_sik(value) + "";*/
            label1.Text = second_demension_sik(int.Parse(textBox1.Text)) + ""; // 위의 두 줄을 한 줄로
        }

        private void button2_Click(object sender, EventArgs e)
        {
            introduce_my_name(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = random_one_to_ten();
            MessageBox.Show("오늘의 랜덤 숫자는 " + number + "입니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hello();
        }

        // 매개변수가 있고 반환형이 있는 함수
        private int second_demension_sik(int x)
        {
            return (x * x) + (2 * x) + 1;
        }

        // 매개변수만 있는 함수
        private void introduce_my_name(string name)
        {
            MessageBox.Show("내 이름은 " + name + "이야.");
        }

        // 반환형만 있는 함수
        private int random_one_to_ten()
        {
            return new Random().Next(10) + 1;
        }

        // 반환형과 매개변수가 없는 함수
        private void Hello()
        {
            MessageBox.Show("안녕");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int.Parse 대신 쓸 수 있는 것 1
            try
            {
                int num = int.Parse(textBox1.Text);
                MessageBox.Show("내가 입력한 숫자 : " + num);
            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show("숫자를 적으세요.");
                MessageBox.Show(ex.Message); // 어떤 에러인지 띄워줌
                MessageBox.Show(ex.StackTrace); // 어느 위치에서 에러가 났는지를 띄워줌
                // txt 위치 : 프로젝트 - bin - Debug - Trace
                pringLog(ex.Message);
                pringLog(ex.StackTrace);
            }
        }

        private void pringLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("Trace"); // DirectoryInfo : using / DirectoryInfo : C#에서 만들어 놓은 클래스
            // Trace라는 폴더를 생성
            if (di.Exists == false) // Trace 폴더가 없다면 
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("Trace" + "\\" + "Log.txt"))
            {
                // 월을 뜻하는 month는 대문자 MM / 분은 소문자 mm
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]{contents}{".txt"}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int.Parse 대신 쓸 수 있는 것 2
            int number;
            bool result = int.TryParse(textBox1.Text, out number);
            // 바로 위 두 줄은 number라는 함수에 값을 주고 true/false를 반환해줌
            // int.TryParse(textBox1.Text, out number); : textBox1에 있는 숫자를 number에 넣는 것을 시도하겠음
            // 숫자로 바꾸는걸 성공했다면 true를 반환해주고 실패했다면 false를 반환해주고 number에는 0이 들어감
            if (result == false)
            {
                MessageBox.Show("숫자를 입력하세요.");
            }
            else
            {
                MessageBox.Show("내가 적은 숫자 : " + textBox1.Text);
            }
        }

        // 오버로딩 : 함수를 만드는데 매개변수의 개수, 타입만 다르다면 함수 이름은 얼마든지 재사용이 가능함
        // 반환형만 있는 함수
        private int random_one_to_ten_except5() // 이런 함수는 만들면 안됨
        {
            int num = new Random().Next(10) + 1;
            while (num == 5)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }

        private int random_one_to_ten(int except) // 오버로딩으로 만들어야 됨
        {   
            int num = new Random().Next(10) + 1;
            while (num == except)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int except = 5;
            int num = random_one_to_ten(except);
            MessageBox.Show("5를 제외한 1 ~ 10사이의 수 : " + num);
        }
                
        private void button8_Click(object sender, EventArgs e)
        {
            string except = textBox2.Text;
            string num = textbox_except(except);
            MessageBox.Show("textBox2의 숫자를 제외한 1 ~ 10사이의 수 : " + num);
        }

        private string textbox_except(string except)
        {
            string num = Convert.ToInt32(new Random().Next(10) + 1).ToString();
            while (textBox2.Text == num)
            {
                num = Convert.ToInt32(new Random().Next(10) + 1).ToString();
            }
            return num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int except);
            label2.Text = "제외되는 숫자 : " + except;
            label3.Text = except+"를 제외한 숫자 : " + random_one_to_ten(except);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // 인스턴스 변수 = (클래스의)멤버 변수
            Circle c1 = new Circle();
            c1.r = 100;
            Circle c2 = new Circle();
            c2.r = 111;
            MessageBox.Show("원의 PI값은 " + Circle.PI + "입니다.");

            MessageBox.Show("c1의 둘레는 " + c1.grith() + "입니다.");
            MessageBox.Show("c2의 둘레는 " + c2.grith() + "입니다.");
            MessageBox.Show("c1의 넓이는 " + c1.area() + "입니다.");
            MessageBox.Show("c2의 넓이는 " + c2.area() + "입니다.");

            Circle.setPi(3.14); // 값 수정
            //MessageBox.Show("원의 PI값은 " + Circle.PI + "입니다.");
            MessageBox.Show("원의 PI값은 " + Circle.getPi() + "입니다."); // 클래스 메서드 : 공통적으로 사용되는 메서드

            MessageBox.Show("c1의 둘레는 " + c1.grith() + "입니다.");
            MessageBox.Show("c2의 둘레는 " + c2.grith() + "입니다.");
            MessageBox.Show("c1의 넓이는 " + c1.area() + "입니다.");
            MessageBox.Show("c2의 넓이는 " + c2.area() + "입니다.");

            Circle.showPi();
        }
    }
}
