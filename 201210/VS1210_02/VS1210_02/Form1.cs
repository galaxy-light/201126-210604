using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS1210_02
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            MessageBox.Show($"내가 빈칸에 적은 말은 {message}이다.");

            // snake 표기법 : 단어 사이에 밑줄이 들어감
            int anajiwgkodfw_dmfwpfm = 0;
            // 카멜리안 표기법(낙타표기법) : 소문자로 시작하고 단어와 단어 사이에 대문자 들어감
            int daljfwKcsfkejGpgkp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년{DateTime.Now.Month}월{DateTime.Now.Day}일" +
                $"{DateTime.Now.Hour}시{DateTime.Now.Minute}분{DateTime.Now.Second}초";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_Second_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 내가 지정한 Interval에 한 번씩 동작
            // 여기에선 1000ms에 한 번 동작
            label_Second.Text = countTime.ToString();
            countTime++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.naver.com");            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }
    }
}
