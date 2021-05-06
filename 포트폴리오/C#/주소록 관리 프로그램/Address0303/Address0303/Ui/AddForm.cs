using AddressTest0222;
using AddressTest0222.control;
using MaterialSkin.Controls;
using AddressTest0222.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address0303.Ui
{
    partial class AddForm : MaterialForm // 상속
    {
        AddressCtrl sc;

        // 생성자 오버로딩
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(AddressCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void addrOkay_Click(object sender, EventArgs e)
        {
            // 공백
            if (AddName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }
            if (AddTel.Text == "")
            {
                MessageBox.Show("전화 번호를 입력하세요.");
            }
            if (AddAddress.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }
            if (AddEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }

            Random r = new Random();

            // 싱글톤
            // StudentCtrl.getInst().getList().Add(new Student(new RandData(r).getId(), AddName.Text, AddTel.Text, AddAddress.Text, AddEmail.Text));
            // 싱글톤X
            // sc.getList().Add(new Student(new RandData(r).getId(), AddName.Text, AddTel.Text, AddAddress.Text, AddEmail.Text));

            if (AddName.Text != "" && AddTel.Text != "" && AddAddress.Text != "" && AddEmail.Text != "")
            {                
                Address0324.DB.MYSQL.InsertDB(AddName.Text, AddTel.Text, AddAddress.Text, AddEmail.Text);
                MessageBox.Show("정보 등록에 성공했습니다.");
            }
            else
            {
                MessageBox.Show("정보 등록에 실패했습니다.");
            }                                        
            Close();
        }

        private void addrCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("모든 항목에 데이터를 입력하세요.");
        }
    }
}
