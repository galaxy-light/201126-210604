using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppfxanswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox1.Text);
            double answer = read_inch_Write_cm(param);
            label1.Text = answer.ToString();
        }

        // 1번
        private double read_inch_Write_cm(int inch)
        {
            return inch * 2.54;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox2.Text);
            double answer = read_kg_Write_pound(param);
            label2.Text = answer.ToString();
        }

        // 2번
        private double read_kg_Write_pound(int kg)
        {
            return kg * 2.20462262;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            int r = int.Parse(textBox3.Text); // r이라는 변수에 textBox3의 텍스트 값을 저장
            double grith_answer = grith(r);
            if (grith_answer == -1)
            {                
                return; // 입력값이 -1일 경우 메세지박스를 띄우고 프로그램이 바로 끝남(void를 반환)
            }
            double area_answer = area(r);
            if (area_answer == -1)
            {
                
                return; // 입력값이 -1일 경우 메세지박스를 띄우고 프로그램이 바로 끝남(void를 반환)
            }

            label3.Text = grith_answer.ToString();
            label4.Text = area_answer.ToString();
        }

        // 3번
        private double grith(int r) // int r은 매개변수
        {
            if (r < 0)
            {
                MessageBox.Show(r + "은 음수입니다.");
                return -1; // 음수일 경우 -1을 리턴해줌 / void(공허)면 return;을 쓸 수 있음(void를 반환하기 때문에)
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }

        private double area(int r) // int r은 매개변수
        {
            if (r < 0)
            {
                MessageBox.Show(r + "은 음수입니다.");
                return -1; // 음수일 경우 -1을 리턴해줌 / void(공허)면 return;을 쓸 수 있음(void를 반환하기 때문에)
            }
            else
            {
                return r * r * 3.14;
            }
        }
    }
}
