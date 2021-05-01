﻿using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
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
        /*MySqlConnection connection = new MySqlConnection("Server=localhost;Database=vipdata;Uid=root;Pwd:1126;");
        // localhost : 서버 / vipdata : DB / root : 유저이름 / 1126 : 비밀번호*/

        public MySqlConnection connection;

        public Cust_ma_add_Form()
        {
            InitializeComponent();

            InitializeDB();

            // 달력
            uiTextBox_start.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            uiTextBox_end.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        // MySQL DB셋팅 초기화
        private void InitializeDB()
        {
            Console.WriteLine("DB 초기화");
            string connectionString;
            connectionString = $"SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;";

            connection = new MySqlConnection(connectionString);
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

            // 차량 번호 중복 확인
            for (int i = 0; i < VipData.vips.Count; i++)
            {
                if (uiTextBox_carnum.Text == VipData.vips[i].custcarnum)
                {
                    MessageBox.Show("이미 등록된 차량 번호입니다.");
                    return;
                }
            }            

            if (uiTextBox_nm.Text != "" && uiTextBox_carnum.Text != "" && uiTextBox_ph.Text != "" &&
                uiTextBox_start.Text != "" && uiTextBox_end.Text != "")
            {
                VipData.vips.Add(new VipCust(uiTextBox_nm.Text, uiTextBox_carnum.Text, uiTextBox_ph.Text,
                    uiTextBox_start.Text, uiTextBox_end.Text));

                // SQL
                // 칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO viplist(name, carnumber, phone, start, end) VALUES ('" + uiTextBox_nm.Text + "', '" + uiTextBox_carnum.Text + "', '" + uiTextBox_ph.Text + "', '" + uiTextBox_start.Text + "', '" + uiTextBox_end.Text + "')";
                // 텍스트 박스에 입력한 내용이 테이블 viplist에 추가됨

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1) // 정상적으로 들어갔다면
                    {
                        //MessageBox.Show("DB에 저장되었습니다.");
                    }
                    else
                    {
                        //MessageBox.Show("DB 저장에 실패했습니다.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    //throw;
                }
                connection.Close();

                MessageBox.Show("정기권을 등록했습니다.(DB 저장 완료)");
                VipData.Savetxt();

                string str = $"관리자 - 이름 : {uiTextBox_nm.Text}, 차량번호 : {uiTextBox_carnum.Text}, 전화번호 : {uiTextBox_ph.Text}," +
                        $"정기권 시작일 : {uiTextBox_start.Text}, 정기권 종료일 : {uiTextBox_end.Text}이 등록되었습니다. (DB 저장 완료)";
                txtwriteLog(str);
                DataManager.Save();
                Close();
            }
            else
            {
                MessageBox.Show("정기권을 등록하지 못했습니다. (DB 저장 실패)");
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //uiTextBox_start.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            //uiTextBox_end.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");

            if (uiRadioButton_start.Checked == true)
            {
                uiTextBox_start.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }
            else
            {
                uiTextBox_end.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }           
        }
    } 
}
