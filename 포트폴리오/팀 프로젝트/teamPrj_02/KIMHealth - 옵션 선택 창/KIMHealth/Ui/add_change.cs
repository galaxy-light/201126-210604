using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth
{
    public partial class add_change : Form
    {
        public add_change()
        {
            InitializeComponent();

            checkedListBox1.CheckOnClick = true;
            checkedListBox2.CheckOnClick = true;
            checkedListBox3.CheckOnClick = true;

            textBox_month.Enabled = false;
            textBox_option.Enabled = false;
            textBox_pt.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox1.SetItemChecked(i, false); //체크상태를 false로 둬라
                       
                    }
                }
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox2.SetItemChecked(i, false); //체크상태를 false로 둬라
                    }
                }
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox3.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox3.SetItemChecked(i, false); //체크상태를 false로 둬라
                    }
                }
            }
        }

        private void button_okay1_Click(object sender, EventArgs e)
        {
            pay_name.Text = textBox_name.Text;
            int checkedFirst = 0;
            int checkedSecond = 0;
            int checkedThird = 0;
          


            //리스트박스1번
            if (checkedListBox1.SelectedIndex == 0)
            {
                checkedFirst = (int)70000;
                textBox_month.Text = "3개월";
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                checkedFirst = (int)120000;
                textBox_month.Text = "6개월";
            }
            else
            {
                checkedFirst = (int)200000;
                textBox_month.Text = "12개월";
            }

            //리스트박스2번
            if (checkedListBox2.SelectedIndex == 0)
            {
                checkedSecond = (int)30000;
                textBox_option.Text = "3개월";
            }
            else if (checkedListBox2.SelectedIndex == 1)
            {
                checkedSecond = (int)60000;
                textBox_option.Text = "6개월";
            }
            else if (checkedListBox2.SelectedIndex == 2)
            {
                checkedSecond = (int)120000;
                textBox_option.Text = "12개월";
            }
            else
            {
                checkedSecond = 0;
                textBox_option.Text = "해당사항 없음";
            }

            //리스트박스3번
            if (checkedListBox3.SelectedIndex == 0)
            {
                checkedThird = (int)180000;
                textBox_pt.Text = "10회";
            }
            else if (checkedListBox3.SelectedIndex == 1)
            {
                checkedThird = (int)350000;
                textBox_pt.Text = "20회";
            }
            else if (checkedListBox3.SelectedIndex == 2)
            {
                checkedThird = (int)500000;
                textBox_pt.Text = "30회";
            }
            else
            {
                checkedThird = 0;
                textBox_pt.Text = "해당사항 없음";
            }

            pay_price.Text = Convert.ToInt32((checkedFirst + checkedSecond + checkedThird)).ToString();            
        }

       
    }
}
