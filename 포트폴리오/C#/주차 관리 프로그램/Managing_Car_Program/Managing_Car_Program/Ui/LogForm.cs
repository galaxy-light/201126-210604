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

namespace Managing_Car_Program
{
    partial class LogForm : MaterialForm
    {
        string adminid = "admin";
        string adminpw = "wnck";

        public LogForm()
        {
            InitializeComponent();

            tooltip();
        }

        private void tooltip()
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip1.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip1.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip1.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip1.SetToolTip(uiSymbolButton_help3, "도움말");
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            loginsec();
        }

        private void loginsec()
        {            
            if (textBox_id.Text == adminid)
            {
                if (textBox_pw.Text == adminpw)
                {
                    new AdminForm().ShowDialog();
                    textBox_id.Text = "";
                    textBox_pw.Text = "";

                    string str = $"관리자로 로그인했습니다.";
                    loginwriteLog(str);
                    DataManager.Save();
                    Close();
                }
                else
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("일치하는 회원정보가 없습니다.");
            }
        }

        private void uiSymbolButton_help3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("관리자 ID/PW 문의 : 000-0000-0000");
        }

        private void loginwriteLog(string txtcontents)
        {
            string logcontents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{txtcontents}";
            DataManager.printLog(logcontents);
        }

        private void textBox_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_pw.Focus();
            }
        }

        private void textBox_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.Focus();
            }
        }
    }
}
