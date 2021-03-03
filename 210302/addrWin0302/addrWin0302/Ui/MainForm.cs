using AddressTest0222.control;
using AddressTest0222.view;
using addrWin0302.ui;
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

namespace addrWin0302
{
    public partial class MainForm : MaterialForm // : : 상속 -> Form(부모)로부터 상속
    {
        MyMenu menu = new MyMenu();
        StudentCtrl sc = new StudentCtrl();

        public MainForm() // Form1() : 기본 생성자 -> Form이 만들어지면서 제일 먼저 호출
        {
            InitializeComponent(); // Form이 만들어지면서 초기화하는 메서드(사용자가 건들 필요X)            
        }

        private void addrExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // JAVA의 system.exit();
        }

        private void addrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년 3월 2일 by y");
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            // sc.addItem();
            new AddForm(sc).ShowDialog();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            sc.viewItem();
        }

        private void addrRandadd_Click(object sender, EventArgs e)
        {
            sc.randData(50);
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            sc.delItem("홍길동");
        }

        private void addrAlldel_Click(object sender, EventArgs e)
        {
            sc.delItemAll();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
