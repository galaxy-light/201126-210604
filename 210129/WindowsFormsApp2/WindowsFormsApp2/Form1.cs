using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] items= new string[] {"토마토", "사과", "오렌지"};
            checkedListBox1.Items.AddRange(items);
        }

        // checkedListBox1-이벤트-SelectedIndexChanged 빈칸 더블클릭
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // String item = checkedListBox1.SelectedItem.ToString();
            // textBox1.Text += item + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
            { // 아무것도 선택하지 않았을 때
                MessageBox.Show("목록에서 선택한 내용이 없습니다.");
                return; // return;을 쓰면 else를 쓰지 않아도 됨
            }         

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex); // 삭제 버튼을 누르면 체크리스트박스 안의 목록이 삭제됨

        }

        private void Form1_Load(object sender, EventArgs e) // 이 프로그램을 실행했을 때 발생하는 이벤트
        {
            String[] items = new string[] {
                "가나다", "123", "abc", "라마바", "def"
            };
            comboBox1.Items.AddRange(items);

            // 콤보박스의 초기값 설정
            // comboBox1.SelectedIndex = 0; // index는 0부터 시작
            comboBox1.SelectedIndex = 1; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다.");
                return;
            }

            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox1.Text += "index" + e.Index + ", " + "value : " + e.NewValue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 체크된 항목만 표시
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                textBox1.Text += "checked : " + checkedListBox1.CheckedItems[i] + "\r\n";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.co.kr");
        }
    }
}
