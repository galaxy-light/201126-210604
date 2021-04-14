using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0414_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rect rec = new Rect();
            int.TryParse(textBox1.Text, out rec.w);
            int.TryParse(textBox2.Text, out rec.h);
            MessageBox.Show("사각형의 넓이 : " + rec.getArea());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rect rec = new Rect();
            int.TryParse(textBox1.Text, out int width);
            int.TryParse(textBox2.Text, out int height);

            rec.setWidth(width);
            rec.setHeight(height);

            if (rec.getWidth() == 0 || rec.getHeight() == 0)
            {
                MessageBox.Show("넓이나 높이에 오류값이 들어감!");
                return;
            }
            MessageBox.Show("사각형의 넓이 : " + rec.getArea_with_getset());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.R = 100; // set 호출해서 value에 100을 넣고 private int r의 r에 100을 저장
            //MessageBox.Show(c.R + "입니다.");

            //c.radi = -100;
            int radi;
            int.TryParse(textBox3.Text, out radi); // out c.radi는 사용할 수 없음
            c.radi = radi; // radi = value
            if (c.radi == 0)
            {
                MessageBox.Show("양수를 입력하세요.");
            }
            else
            { 
                MessageBox.Show(c.R + "입니다.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Person p = new Person();
            // Person에 오류가 뜬다면 생성자 오버로딩을 해주면 됨
            Person p = new Person("홍길동", 25);
            //p.name = textBox4.Text;
            MessageBox.Show(p.name + ", " + p.age);

            Person p2 = new Person(textBox4.Text); // 이름만 아는 경우
            int.TryParse(textBox5.Text, out int age);
            p2.age = age;
            MessageBox.Show(p2.name + ", " + p2.age);

            Person p3 = new Person(); // 아무것도 모르는 경우
            p3.name = textBox4.Text;
            p3.age = int.Parse(textBox5.Text);
            MessageBox.Show(p3.name + ", " + p3.age);

            // 상수 : 변하지 않는 값
            int yourAge = 300;
            yourAge = 30; // 변수는 선언 이후 값이 변할 수 있음
            const int myAge = 33;
            //myAge = 23; // 상수는 한 번 값이 선언되면 안 바뀜
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 일반변수
            string name = "홍길동";
            string name2 = "아무개";
            name2 = "전우치";
            MessageBox.Show(name + "VS" + name2);

            // 참조변수 : 사용자 정의 변수
            Person p = new Person("김이박", 200);
            Person p2 = p;
            p2.name = "최권임";
            p2.age = 500;
            MessageBox.Show(p.name + "VS" + p2.name);
        }
    }
}
