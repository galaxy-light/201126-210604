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
using System.Drawing.Text;
using AddressTest0222;

namespace Address0303
{
    public partial class MainForm : MaterialForm
    {
        MyMenu menu = new MyMenu();
        AddressCtrl sc = new AddressCtrl(); // 객체 생성

        public MainForm()
        {
            InitializeComponent();            
        }

        private void initFont() // 폰트 변경
        {
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("nanumsongeulssibut.ttf");
            Font font = new Font(pFont.Families[0], 20f);
            addrAdd.Font = font;
            addrView.Font = font;
            //addrRand.Font = font;
            //addrDel.Font = font;
            addrUpdate.Font = font;
        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("최신 버전입니다.");
        }

        private void arrExit_Click(object sender, EventArgs e)
        {
            // Application.Exit();
        }

        private void addrAdd_Click(object sender, EventArgs e)
        {
            // sc.addItem();
            // new AddForm().ShowDialog();
            new AddForm(sc).ShowDialog();            
        }

        private void addrView_Click(object sender, EventArgs e)
        {
            // sc.viewItem();
            // StudentCtrl.getInst().viewItem(); // 콘솔 / 싱글톤 -> StudentCtrl.getInst() : 클래스 / viewItem(); : 객체
            new ViewForm(sc).ShowDialog(); // Winform           
            //if (sc.getList().Count == 0)
            //{
            //    MessageBox.Show("데이터가 없습니다.");
            //    return;
            //}
        }

        /*private void addrRand_Click(object sender, EventArgs e)
        {
            string cnt = myInputBox("랜덤 데이터 생성", "랜덤하게 데이터를 생성할 개수를 입력하세요.", "0");
            // StudentCtrl.getInst().randData(Convert.ToInt32(cnt));
            sc.randData(Convert.ToInt32(cnt));
            if (cnt == "")
            {

            }
            // return;
            // sc.randData(50);
            *//*Random r = new Random();
            new RandData(r);    *//*            
        }*/

        /*private void addrDel_Click(object sender, EventArgs e)
        {
            // sc.delItem("홍길동");
            // StudentCtrl.getInst().delItem("홍길동"); // 싱글톤 -> StudentCtrl.getInst() : 클래스 / delItem("홍길동"); : 객체 
            new DelForm(sc).ShowDialog();
        }*/

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            // sc.updateItem(1);            
            // StudentCtrl.getInst().updateItem(1); // 싱글톤 -> StudentCtrl.getInst() : 클래스 / updateItem(1); : 객체
            new UpdateForm(sc).ShowDialog();
        }

        private string myInputBox(string title, string body, string prompt)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1); // 참조-참조 추가-어셈블리-마이크로소프트비주얼베이직 체크
            return input;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initFont();
        }
    }
}
