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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.co.kr");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // String item = checkedListBox1.SelectedIndex.ToString();
            // textBox1.Text += item + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] items = new string[] { "복숭아", "파인애플", "오렌지" };
            checkedListBox1.Items.AddRange(items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1) {
                MessageBox.Show("목록중 선택한 항목이 없습니다.");
                return;
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] items = new string[] {"콜라", "사이다", "주스", "물"};
            comboBox1.Items.AddRange(items);

            comboBox1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("콤보박스 목록중 선택한 항목이 없습니다.");
                return;
            }

            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // String item = checkedListBox1.SelectedItem.ToString();
            // textBox1.Text += item + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
