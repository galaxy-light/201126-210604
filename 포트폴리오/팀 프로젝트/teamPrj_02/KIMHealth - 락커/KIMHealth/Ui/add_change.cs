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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_change_Load(object sender, EventArgs e)
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
        }
    }
}
