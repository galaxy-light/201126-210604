﻿using MaterialSkin.Controls;
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
    partial class Cust_ma_add_Form : MaterialForm
    {
        public Cust_ma_add_Form()
        {
            InitializeComponent();
        }              

        private void button_okay_Click(object sender, EventArgs e)
        {
            if (uiTextBox_nm.Text.Trim() == "")
            {
                MessageBox.Show("이름을 입력하세요.");
                return;
            }
            if (uiTextBox_carnum.Text.Trim() == "")
            {
                MessageBox.Show("차량번호를 입력하세요.");
                return;
            }
            if (uiTextBox_ph.Text.Trim() == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
                return;
            }
            if (uiTextBox_start.Text.Trim() == "")
            {
                MessageBox.Show("시작일을 입력하세요.");
                return;
            }
            if (uiTextBox_end.Text.Trim() == "")
            {
                MessageBox.Show("종료일을 입력하세요.");
                return;
            }

            if (uiTextBox_nm.Text != "" && uiTextBox_carnum.Text != "" && uiTextBox_ph.Text != "" &&
                uiTextBox_start.Text != "" && uiTextBox_end.Text != "")
            {
                VipData.vips.Add(new VipCust(uiTextBox_nm.Text, uiTextBox_carnum.Text, uiTextBox_ph.Text,
                    uiTextBox_start.Text, uiTextBox_end.Text));
                
                MessageBox.Show("정기권을 등록했습니다.");
                VipData.Savetxt();

                string str = $"관리자 - 이름 : {uiTextBox_nm.Text}, 차량번호 : {uiTextBox_carnum.Text}, 전화번호 : {uiTextBox_ph.Text}," +
                        $"정기권 시작일 : {uiTextBox_start.Text}, 정기권 종료일 : {uiTextBox_end.Text}이 등록되었습니다.";
                txtwriteLog(str);
                DataManager.Save();
                Close();
            }
            else
            {
                MessageBox.Show("정기권을 등록하지 못했습니다.");
                return;
            }
        }

        private void txtwriteLog(string txtcontents)
        {
            string txtlogcontents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{txtcontents}";
            DataManager.printLog(txtlogcontents);
        }

        private void uiTextBox_nm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiTextBox_nm.Focus();
            }
        }

        private void uiTextBox_carnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiTextBox_carnum.Focus();
            }
        }

        private void uiTextBox_ph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_start.Focus();
            }
        }

        private void uiTextBox_start_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                uiSymbolLabel_end.Focus();
            }
        }

        private void uiTextBox_end_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_okay.Focus();
            }
        }
    } 
}
