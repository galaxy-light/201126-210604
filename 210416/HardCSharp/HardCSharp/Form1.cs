using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            MessageBox.Show("Test"); // 모달 : 뒤에 있는 창 선택 불가능
            // MessageBox.Show() -> 무조건 모달이라는 문제가 있음
            // MessageBox.Show()가 띄워져있는 상태라면 MessageBox.Show에서 프로그램이 멈춰있음(F5키 눌러서 출력부분 확인)
            Console.WriteLine("하세요");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            Form2 f = new Form2();
            f.Show(); // Modeless 모달리스 : 뒤에 있는 창이 선택 가능함
            Console.WriteLine("하세요");
            // 프로그램이 멈춰있지 않음
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(); // Modal 모달 : 뒤에 있는 창 선택 불가능
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat(); // Eat()은 Animal에서 구현되지 않았기 때문에 Cat클래스에서 구현한 메서드를 호출
            c.sleep(); // sleep()은 Animal에 구현되어 있어서 바로 가져옴

            Dog g = new Dog();
            g.Eat();
            g.sleep();

            // 다형성 : 하나의 객체가 여러 가지 타입을 가질 수 있는 것
            Animal a = new Dog();
            Animal b = new Cat();
            a.Eat(); // a에는 Dog의 Eat()가 들어가있음
            b.Eat(); // b에는 Cat의 Eat()가 들어가있음
        }
    }
}
