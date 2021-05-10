using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth.DB
{
    public partial class manager_form : Form
    {
        int count = 0;

        public manager_form()
        {
            InitializeComponent();

            this.manageInput_btn.BackColor = System.Drawing.Color.SteelBlue;           
            this.manageInput_btn.ForeColor = Color.White;
        }

        private void manageInput_btn_Click(object sender, EventArgs e)
        {
            if (textBox_managerPw.Text == "1234")
            {
                new totalInfo().ShowDialog();
                Close();
            }
            else
            {
                count++;
                MessageBox.Show("암호가 틀렸습니다. \n"+ count + "회 입력실패! 5회 오입력시 종료됩니다.");
                if (count == 5)
                {
                    Close();
                }
            }
        }
    }
}
