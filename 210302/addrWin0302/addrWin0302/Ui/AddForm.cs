using AddressTest0222;
using AddressTest0222.control;
using AddressTest0222.util;
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

namespace addrWin0302.ui
{
    // public partial class AddForm : MaterialForm
    partial class AddForm : MaterialForm
    {
        StudentCtrl sc;

        public AddForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void addOkay_Click(object sender, EventArgs e)
        {
            // 공백
            if (addName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }
            if (addTel.Text == "")
            {
                MessageBox.Show("전화 번호를 입력하세요.");
            }
            if (addAddress.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }
            if (addEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }

            Random r = new Random();
            sc.getList().Add(new Student(new RandData(r).getId(), addName.Text, addTel.Text, addAddress.Text, addEmail.Text));
            // Console.WriteLine("정보가 정상적으로 입력되었습니다.");           
            Close();
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
