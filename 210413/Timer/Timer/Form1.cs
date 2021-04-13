using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            time++;
            label1.Text = "프로그램 실행 경과 : " + time + "초 입니다.";

            if (time == 10)
            {
                MessageBox.Show("시간 초과!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numcheck();
        }

        private void numcheck()
        {            
            int a = 0;
            a = r.Next(10) + 1;            
            if (a == int.Parse(textBox1.Text))
            {                
                label2.Text = "정답!";
                a = r.Next(10) + 1; // 정답 다시 부여
                time = 0; // 시간 초기화
            }
            else
            {
                if (a < int.Parse(textBox1.Text))
                {
                    
                    label2.Text = "정답보다 큽니다.";
                }
                if (a > int.Parse(textBox1.Text))
                {                    
                    label2.Text = "정답보다 작습니다.";
                }
            }      
        }
    }
}
