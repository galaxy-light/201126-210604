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

            checkedListBox_membership.CheckOnClick = true;
            checkedListBox_lent.CheckOnClick = true;
            checkedListBox_pt.CheckOnClick = true;

            textBox_membership.Enabled = false;
            textBox_lent.Enabled = false;
            textBox_pt.Enabled = false;

            // 버튼 배경색
            this.button_okay1.BackColor = System.Drawing.Color.SteelBlue;
            this.button_okay1.ForeColor = Color.White;

            this.input_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.input_btn.ForeColor = Color.White;

            // 글씨 정렬
            textBox_membership.TextAlign = HorizontalAlignment.Center;
            textBox_lent.TextAlign = HorizontalAlignment.Center;
            textBox_pt.TextAlign = HorizontalAlignment.Center;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox_membership.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox_membership.SetItemChecked(i, false); //체크상태를 false로 둬라

                    }
                }
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox_lent.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox_lent.SetItemChecked(i, false); //체크상태를 false로 둬라
                    }
                }
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)  //내가 선택한 값이 체크 상태일때
            {
                for (int i = 0; i < checkedListBox_pt.Items.Count; i++) //체크박스에 있는만큼 포문을 도는데
                {
                    if (e.Index != i) //만약 선택한 인덱스값이 아닌것은
                    {
                        checkedListBox_pt.SetItemChecked(i, false); //체크상태를 false로 둬라
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
            if (checkedListBox_membership.SelectedIndex == 0)
            {
                checkedFirst = (int)70000;
                textBox_membership.Text = "3개월";
            }
            else if (checkedListBox_membership.SelectedIndex == 1)
            {
                checkedFirst = (int)120000;
                textBox_membership.Text = "6개월";
            }
            else
            {
                checkedFirst = (int)200000;
                textBox_membership.Text = "12개월";
            }

            //리스트박스2번
            if (checkedListBox_lent.SelectedIndex == 0)
            {
                checkedSecond = (int)30000;
                textBox_lent.Text = "3개월";
            }
            else if (checkedListBox_lent.SelectedIndex == 1)
            {
                checkedSecond = (int)60000;
                textBox_lent.Text = "6개월";
            }
            else if (checkedListBox_lent.SelectedIndex == 2)
            {
                checkedSecond = (int)120000;
                textBox_lent.Text = "12개월";
            }
            else
            {
                checkedSecond = 0;
                textBox_lent.Text = "해당사항 없음";
            }

            //리스트박스3번
            if (checkedListBox_pt.SelectedIndex == 0)
            {
                checkedThird = (int)180000;
                textBox_pt.Text = "10회";
            }
            else if (checkedListBox_pt.SelectedIndex == 1)
            {
                checkedThird = (int)350000;
                textBox_pt.Text = "20회";
            }
            else if (checkedListBox_pt.SelectedIndex == 2)
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

        private void button_okay1_MouseHover(object sender, EventArgs e)
        {
            button_okay1.BackColor = Color.LightSkyBlue;
        }

        private void button_okay1_MouseLeave(object sender, EventArgs e)
        {
            button_okay1.BackColor = Color.SteelBlue;
        }

        private void input_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_name.Text.Trim() == "" || textBox_membership.Text.Trim() == "" || textBox_lent.Text.Trim() == "" ||
                    textBox_lent.Text.Trim() == "" || textBox_pt.Text.Trim() == "" || text_trainer.Text.Trim() == "" || textBox_start.Text.Trim() == "" || textBox_end.Text.Trim() == "")
                {
                    MessageBox.Show("가입하기 위해 정보를 입력하세요.");
                    return;
                }
                else
                {
                    DB.DaoMs.DB_Insert(textBox_name.Text, textBox_phone.Text, textBox_addr.Text, textBox_age.Text,
                                       textBox_gender.Text, textBox_height.Text, textBox_weight.Text, textBox_bmi.Text,
                                       textBox_membership.Text, textBox_lent.Text, textBox_pt.Text, text_trainer.Text,textBox_start.Text, textBox_end.Text);

                    MessageBox.Show(textBox_name.Text + "님 등록 완료되었습니다.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void combo_trainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_trainer.Text= combo_trainer.SelectedItem.ToString();

       
        }
    }
}
