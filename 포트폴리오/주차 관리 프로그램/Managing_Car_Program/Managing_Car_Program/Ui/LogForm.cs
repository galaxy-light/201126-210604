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
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == adminid)
            {
                if (textBox_pw.Text == adminpw)
                {
                    new AdminForm().Show();
                    textBox_id.Text = "";
                    textBox_pw.Text = "";
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

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox_pw.Focus();
            }
        }

        private void textBox_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                button_login.Focus();
            }
        }        
    }
}
