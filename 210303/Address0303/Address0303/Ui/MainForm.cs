using Address0303.Ui;
using AddressTest0222.control;
using AddressTest0222.util;
using AddressTest0222.view;
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

namespace Address0303
{
    public partial class MainForm : MaterialForm
    {
        MyMenu menu = new MyMenu();
        // StudentCtrl sc = new StudentCtrl(); // 객체 생성

        public MainForm()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update 2021년 3월 2일 by y");
        }

        private void arrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            // sc.addItem();
            // new AddrForm(sc).ShowDialog();
            new AddForm().ShowDialog();
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            // sc.viewItem();
            StudentCtrl.getInst().viewItem(); // 콘솔 / 싱글톤 -> StudentCtrl.getInst() : 클래스 / viewItem(); : 객체
            new ViewForm().ShowDialog(); // Winform
        }

        private void addrRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 개수를 입력하세요.", "0");
            StudentCtrl.getInst().randData(Convert.ToInt32(cnt));
            // sc.randData(50);
            /*Random r = new Random();
            new RandData(r);    */        
        }

        private void addrDel_Click(object sender, EventArgs e)
        {
            // sc.delItem("홍길동");
            StudentCtrl.getInst().delItem("홍길동"); // 싱글톤 -> StudentCtrl.getInst() : 클래스 / viewItem(); : 객체      
        }

        private void addrAllDel_Click(object sender, EventArgs e)
        {
            // sc.delItemAll();
            StudentCtrl.getInst().delItemAll(); // 싱글톤 -> StudentCtrl.getInst() : 클래스 / viewItem(); : 객체
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            StudentCtrl.getInst().updateItem(1); // 싱글톤 -> StudentCtrl.getInst() : 클래스 / viewItem(); : 객체
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1); // 참조-참조 추가-어셈블리-마이크로소프트비주얼베이직 체크
            return input;
        }
    }
}
