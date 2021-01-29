using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.checkedlistbox?view=netframework-4.7.2&f1url=%3FappId%3DDev16IDEF1%26l%3DKO-KR%26k%3Dk(System.Windows.Forms.CheckedListBox);k(Designer_System.Windows.Forms.Design.FormDocumentDesigner);k(VisualSelection);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv4.7.2);k(DevLang-csharp)%26rd%3Dtrue
// 예제 참고
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 불형 : 참과 거짓

            // checkBox1.Checked = true;

            /*if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }*/

            /*if (checkBox1.Checked)
            {
             checkBox1.Checked = false;
             }
            else
            {
             checkBox1.Checked = true;
            }*/

            // checkBox1.Checked = !checkBox1.Checked;

            Console.WriteLine("checkBox1.checked : " + checkBox1.Checked);

            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
             }
            else
            {
                // 상태에 따라 메세지 추가
                checkBox1.Checked = true;
                MessageBox.Show("checked...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sets up initial object in the Check
            string[] myFruit = {"Apples", "Oranges", "Tomato"};
            checkedListBox1.Items.AddRange(myFruit);

            // CheckOnClick : 한번 클릭할 때 될건지
            checkedListBox1.CheckOnClick = true; // 주석처리하면 실행했을 때 두번 클릭해야 체크됨
        }

        // 자동완성 : CheckedListBox1 클릭-이벤트-ItemCheck 빈칸 더블클릭
        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Unchecked)
            //{
            //    if (checkedListBox1.CheckedItems.Count == 1)
            //    {
            //        button2.Enabled = false;
            //    }
            //    else
            //    {
            //        button2.Enabled = true;
            //    }                
            //}
            textBox1.Text = "e.NewValue : " + e.NewValue + "\r\n"; // \r : 개행문자 / \r\n : 줄바꿈
        }

        // 자동완성 : CheckedListBox1 클릭-이벤트-SelectedIndexChanged 빈칸 더블클릭
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string curItem = checkedListBox1.SelectedItem.ToString();
            // textBox1.Text = "curItem : " + curItem + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "selected index : " + checkedListBox1.SelectedIndex + "\r\n";
            if (checkedListBox1.SelectedIndex != -1) { // 선택이 되어 있지 않다면 메세지박스 출력
                MessageBox.Show("Item is not avilable in box");
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }
    }
}
