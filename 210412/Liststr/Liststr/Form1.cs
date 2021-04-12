using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liststr
{
    public partial class Form1 : Form
    {
        // 문제4. List를 이용하여 문자열을 추가 및 제거하는 화면을 만드시오.

        List<string> nlist = new List<string>();        

        public Form1()
        {
            InitializeComponent();

           
            nlist.Remove(button_del_44.Text);
            nlist.Remove(button_del_27.Text);
            nlist.Remove(button_del_16.Text);
        }

        private void button_add_12_Click(object sender, EventArgs e)
        {
            nlist.Add(button_add_12.Text);
            text_label.Text = ""; // 라벨의 텍스트를 먼저 공백처리
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_add_44_Click(object sender, EventArgs e)
        {
            nlist.Add(button_add_44.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_add_27_Click(object sender, EventArgs e)
        {
            nlist.Add(button_add_27.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_add_16_Click(object sender, EventArgs e)
        {
            nlist.Add(button_add_16.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_del_12_Click(object sender, EventArgs e)
        {
            nlist.Remove(button_del_12.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_del_44_Click(object sender, EventArgs e)
        {
            nlist.Remove(button_del_44.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_del_27_Click(object sender, EventArgs e)
        {
            nlist.Remove(button_del_27.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }

        private void button_del_16_Click(object sender, EventArgs e)
        {
            nlist.Remove(button_del_16.Text);
            text_label.Text = "";
            foreach (var item in nlist) // foreach : 배열 인덱스 끝 번호까지 반복
            {
                text_label.Text += item + " ";
            }
        }
    }
}
