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
    partial class Cust_ma_Form : MaterialForm
    {
        public Cust_ma_Form()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_okay_Click(object sender, EventArgs e)
        {
            if (uiTextBox_nm.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }
            if (uiTextBox_carnum.Text == "")
            {
                MessageBox.Show("차량번호를 입력하세요.");
                return;
            }
            if (uiTextBox_ph.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
                return;
            }
            if (uiTextBox_start.Text == "")
            {
                MessageBox.Show("시작일을 입력하세요.");
                return;
            }
            if (uiTextBox_end.Text == "")
            {
                MessageBox.Show("종료일을 입력하세요.");
                return;
            }

            if (uiTextBox_nm.Text != "" && uiTextBox_carnum.Text != "" && uiTextBox_ph.Text != "" &&
                uiTextBox_start.Text != "" && uiTextBox_end.Text != "")
            {
                VipData.vips.Add(new VipCust(uiTextBox_nm.Text, uiTextBox_carnum.Text, uiTextBox_ph.Text,
                    uiTextBox_start.Text, uiTextBox_end.Text));
                VipData.Savetxt();
                MessageBox.Show("정보를 등록했습니다.");
                Close();
            }
            else
            {
                MessageBox.Show("정보를 등록하지 못했습니다.");
            }
        } 
    } 
}
