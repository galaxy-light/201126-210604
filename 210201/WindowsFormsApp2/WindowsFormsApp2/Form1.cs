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
            if (checkBox1.Checked == true) { // 체크박스에 체크가 되어있을 때
                label1.Text = textBox1.Text;
                listBox1.Items.Add(textBox1.Text); // 리스트박스에 추가
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("첫번째");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택된 내용이 없습니다.");
            }
            else {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
