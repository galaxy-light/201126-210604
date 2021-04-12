using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strmix
{
    public partial class Form1 : Form
    {
        // 문제2. Random 함수를 이용하여 가위 바위 보 게임을 만들어보시오.(Form 이용)

        Random r = new Random();          

        public Form1()
        {
            InitializeComponent();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            List<string> slist = new List<string>();
            slist.Add("가위");
            slist.Add("바위");
            slist.Add("보");

            int randnum = r.Next(slist.Count);
            label2.Text = slist[randnum];
            if (textBox1.Text == label2.Text)
            {
                Console.WriteLine("비겼습니다.");
                label3.Text = "비겼습니다.";
            }
            if (textBox1.Text == "가위")
            {
                if (label2.Text == "바위")
                {
                    Console.WriteLine("졌습니다.");
                    label3.Text = "졌습니다.";
                }
                else if (label2.Text == "보")
                {
                    Console.WriteLine("이겼습니다.");
                    label3.Text = "이겼습니다.";
                }
            }
            if (textBox1.Text == "바위")
            {
                if (label2.Text == "가위")
                {
                    Console.WriteLine("이겼습니다.");
                    label3.Text = "이겼습니다.";
                }
                else if (label2.Text == "보")
                {
                    Console.WriteLine("졌습니다.");
                    label3.Text = "졌습니다.";
                }
            }
            if (textBox1.Text == "보")
            {
                if (label2.Text == "가위")
                {
                    Console.WriteLine("졌습니다.");
                    label3.Text = "졌습니다.";
                }
                if (label2.Text == "바위")
                {
                    Console.WriteLine("이겼습니다.");
                    label3.Text = "이겼습니다.";
                }
            }
        }
    }
}
