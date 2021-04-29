using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program.Ui
{
    public partial class Cust_cu_add_Form : MaterialForm
    {
        public Cust_cu_add_Form()
        {
            InitializeComponent();

            // 달력
            uiTextBox_start_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            uiTextBox_end_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        private void button_okay_Click(object sender, EventArgs e)
        {
            if (uiTextBox_name_text.Text.Trim() == "")
            {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }
            else if (uiTextBox_car_text.Text.Trim() == "")
            {
                MessageBox.Show("차량번호를 입력하세요.");
                return;
            }
            else if (uiTextBox_ph_text.Text.Trim() == "")               
            {
                MessageBox.Show("전화번호를 입력하세요.");
                return;
            }
            else if (uiTextBox_start_text.Text.Trim() == "")
            {
                MessageBox.Show("정기권 시작일을 입력하세요.");
                return;
            }
            else if (uiTextBox_end_text.Text.Trim() == "")
            {
                MessageBox.Show("정기권 종료일을 입력하세요.");
                return;
            }

            // 차량 번호 중복 확인
            for (int i = 0; i < VipData.vips.Count; i++)
            {
                if (uiTextBox_car_text.Text == VipData.vips[i].custcarnum)
                {
                    MessageBox.Show("이미 등록된 차량 번호입니다.");
                    return;
                }
            }

            if (uiTextBox_name_text.Text.Trim() != "" && uiTextBox_car_text.Text.Trim() != "" &&
                uiTextBox_ph_text.Text.Trim() != "" && uiTextBox_start_text.Text.Trim() != "" && uiTextBox_end_text.Text.Trim() != "")
            {                
                VipData.vips.Add(new VipCust(uiTextBox_name_text.Text, uiTextBox_car_text.Text, uiTextBox_ph_text.Text,
                    uiTextBox_start_text.Text, uiTextBox_end_text.Text));
                
                MessageBox.Show("정기권 구매에 성공했습니다.");
                VipData.Savetxt();               

                string str = $"사용자 - 이름 : {uiTextBox_name_text.Text}, 차량번호 : {uiTextBox_car_text.Text}," +
                    $"전화번호 : {uiTextBox_ph_text.Text}, 정기권 시작일 : {uiTextBox_start_text.Text}, 정기권 종료일 : {uiTextBox_end_text.Text}를 구매했습니다.";
                                
                custwritelog(str);
                DataManager.Save();
                Close();
            }
            else
            {
                MessageBox.Show("정기권 구매에 실패했습니다.\r 입력창을 다시 확인해주세요.");
                return;
            }
        }

        private void custwritelog(string custcontents)
        {
            string custbuycontents = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}]{custcontents}";
            DataManager.printLog(custbuycontents);
        }

        private void uiTextBox_name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_carnum.Focus();                
            }
        }

        private void uiTextBox_car_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_phone.Focus();
            }
        }

        private void uiTextBox_ph_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_start.Focus();
            }
        }

        private void uiTextBox_start_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_end.Focus();
            }
        }

        private void uiTextBox_end_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                button_okay.Focus();
            }
        }

        private void uiSymbolButton_help2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정기권 문의 : 000-0000-000");
        }

        private void uiSymbolButton_help5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("월정기주차권 금액 : 150,000원");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //selectcalendar();

            uiTextBox_start_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            uiTextBox_end_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        private void selectcalendar()
        {
            // 이 코드 사용X : 시작일과 종료일 캘린더 동기화 해제 안됨
            /*if (uiTextBox_start_text.Focused)
            {
                uiSymbolLabel_start.Enabled = true;
                uiTextBox_start_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }          

            if (uiTextBox_end_text.Focused)
            {
                uiTextBox_end_text.Enabled = true;
                uiTextBox_end_text.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }*/
        }
    }
}
