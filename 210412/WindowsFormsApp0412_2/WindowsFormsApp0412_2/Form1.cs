using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0412_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "홍길동", grade = 6 }); // 값을 넣는 방법1
            Student s = new Student() { name = "김길동", grade = 5 }; // 값을 넣는 방법2
            students.Add(s);
            Student ss = new Student(); // 값을 넣는 방법3
            ss.name = "이길동";
            ss.grade = 4;
            students.Add(ss);
            students.Add(new Student() { name = "박길동", grade = 1 });
            students.Add(new Student() { name = "최길동", grade = 2 });
            students.Add(new Student() { name = "권길동", grade = 3 });

            //string names = "";
            for (int i = 0; i < students.Count; i++)
            {
                //names += students[i].name + " " + students[i].grade + "\n";
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true; // 라벨의 크기를 텍스트 크기에 맞게 자동 조절
                label.Location = new Point(13, 13 + (26 * i)); // 위치
                Controls.Add(label); // Controls.Add(label); : winform에 띄움
            }
            //MessageBox.Show(names);
            // 일반적 for문
            for (int i = 0; i < students.Count; i++)
            {

            }
            // 역 for문 / indexoverflow 방지(만약에 RemoveAt로 중간 배열 요소를 지웠을 경우 일반적 for문을 쓰면 인덱스오버플로우 에러가 발생함)
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 1)
                {
                    students.RemoveAt(i);
                }
            }
            for (int i = 0; i < students.Count; i++)
            {
                //names += students[i].name + " " + students[i].grade + "\n";
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name}학생";
                label.AutoSize = true; // 라벨의 크기를 텍스트 크기에 맞게 자동 조절
                label.Location = new Point(13, 13 + (26 * i)); // 위치
                Controls.Add(label); // Controls.Add(label); : winform에 띄움
            }
        }
    }
}
