using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕하세요"; // 프로그램 실행시 버튼의 텍스트 변경
            int abc = 100;
            if (abc == 100)
            {
                button1.Enabled = false; // 버튼 비활성화
            }
            // 코드로 버튼 생성
            Button b = new Button();
            b.Text = "무야호";
            b.Location = new Point(50, 50); // 위치
            Controls.Add(b); // Form1창에 띄워줌

            // 배열과 list는 다름(list는 동적으로 움직임)
            List<int> ilist = new List<int>();
            ilist.Add(10);
            ilist.Add(50);
            ilist.Add(123);
            for (int i = 0; i < ilist.Count; i++)
            {
                Console.WriteLine(ilist[i]);
            }
            ilist.Add(1000);
            MessageBox.Show(ilist.Count + "개");

            List<string> slist = new List<string>();
            slist.Add("김수한무");
            slist.Add("거북이와");
            slist.Add("두루미");
            slist.Add("삼천갑자");
            MessageBox.Show(slist.Count + "명");
            slist.Remove("거북이와"); // 삭제
            MessageBox.Show(slist.Count + "명");
            string names = string.Empty; // Empty = ""
            for (int i = 0; i < slist.Count; i++)
            {
                names += slist[i];
            }
            MessageBox.Show(names);

            Label l = new Label();
            l.Text = "절댓값 : " + Math.Abs(-1000); // Abs : 절댓값
            l.Location = new Point(100, 100);
            Controls.Add(l);

            Product p = new Product(); // new Product(); : 인스턴스
            p.name = "감자";
            p.price = 1000;
            Product.count++; // count : Product에서 공통으로 접근할 수 있는 단 하나의 변수 / static(클래스 변수이기 때문에)으로 정의된 변수는 Product.count로 밖에 접근이 안됨
            MessageBox.Show("제품명 : " + p.name);
            MessageBox.Show("제품 가격 : " + p.price);
            MessageBox.Show("제품 개수 : " + Product.count);
            Product p2 = new Product(); // new Product(); : 인스턴스
            p2.name = "고구마";
            p2.price = 5000;
            Product.count++;
            // 선언과 동시에 값 지정
            Product p3 = new Product() { name = "파", price = 50 };

            //Dog hg = new Dog();
            Dog hg = new Dog("가나", 17); // 인스턴스를 생성함과 동시에 변수의 값을 지정
            MessageBox.Show(hg.name+hg.age);
            Dog ab = new Dog("다라", 5);
            MessageBox.Show("개의 마리수 : " + Dog.theNumberofDog);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
