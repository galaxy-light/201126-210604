using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { // 체크박스에 체크를 하고 버튼을 누르면
                label1.Text = textBox1.Text; // 라벨에 적힌 텍스트와 텍스트박스 연동
                listBox1.Items.Add(textBox1.Text); // 텍스트박스에 적힌 내용을 리스트박스에 추가                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) // 삭제 버튼을 눌렀을 때
            {
                MessageBox.Show("목록에 선택된 항목이 없습니다."); // 아무것도 선택하지 않은 상태일 때
            }
            else {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // 선택을 하고 삭제 버튼을 눌렀을 때 삭제
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("기본값"); // 프로그램을 실행했을 때
        }
    }
}
