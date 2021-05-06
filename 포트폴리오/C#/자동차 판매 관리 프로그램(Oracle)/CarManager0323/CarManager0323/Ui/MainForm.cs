using CarManager0323.DB;
using CarManager0323.Model;
using CarManager0329.Ui;
using CarManager0330.Handler;
using CarManager0331.Ui;
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

namespace CarManager0323
{
    partial class MainForm : MaterialForm
    {
        DaoOracle db = new DaoOracle(); // 여기서 객체 생성해도 됨
        //DaoOracle db;
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(DaoOracle oracle) // 오버로딩(매개 변수가 있는 생성자)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //db = new DaoOracle(); // 여기서 객체 생성해도 됨
            //db.dbConnect();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //db.dbClose();
        }

        private void createTB_Click(object sender, EventArgs e)
        {
            //db.createTable()
            db.makeAllTB();
            MessageBox.Show("테이블, 시퀀스 생성 성공");
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            //db.dropTable();
            db.dropAllTB();
            MessageBox.Show("테이블, 시퀀스 삭제 성공");
        }

        private void insertAll_Click(object sender, EventArgs e)
        {
            //db.insertCar();
            //db.insertCustomer();
            db.insertSeller();
            db.insertDeal();
            Console.WriteLine("데이터 추가 완료");
            MessageBox.Show("모든 데이터가 추가되었습니다.");
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            //new CarInsForm(db).Show();
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Car != null) // 이미 객체가 있을 때
            {
                MessageBox.Show("차량 정보가 이미 저장되어 있습니다.");
                return;
            }
            new CarInsForm(db, dHandler).ShowDialog(); // 싱글톤
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            //new CusInsForm(db).Show();
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Customer != null) // 이미 객체가 있을 때
            {
                MessageBox.Show("고객 정보가 이미 저장되어 있습니다.");
                return;
            }
            new CusInsForm(db, dHandler).ShowDialog();
        }

        private void insesrtSeller_Click(object sender, EventArgs e)
        {
            //new SellerInsForm(db).Show();
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Seller != null) // 이미 객체가 있을 때
            {
                MessageBox.Show("판매자 정보가 이미 저장되어 있습니다.");
                return;
            }
            new SellerInsForm(db, dHandler).ShowDialog();
        }

        private void pro_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ : 테이블 생성" + "\r" + "- : 테이블 삭제"); // \r : 줄바꿈           
        }

        private void insertDeal_Click(object sender, EventArgs e)
        {            
            List<Deal> list = dHandler.GetDealList();
            if (list[0].Car == null || list[0].Customer == null || list[0].Seller == null) // 정보 추가없이 거래 버튼 눌렀을 때 오류 메세지 해결
            {
                MessageBox.Show("구매 내역 정보가 누락되었습니다.");
                return;
            }
            else
            {
                MessageBox.Show("거래 정보가 추가되었습니다.");            
            }            
            //db.insertDeal(list[0]); // Deal클래스의 객체 정보
            db.insertDeal(list[0].Customer, list[0].Car, list[0].Seller); // 매개 변수의 순서와 일치해야 됨
            dHandler.dealListClear();
        }

        private void DateView_Click(object sender, EventArgs e)
        {
            new DealViewForm(db, dHandler).ShowDialog();            
        }

        private void DateView_MouseHover(object sender, EventArgs e)
        {
            /*this.DateView.ToolTipTitle = "ToolTip";
            this.DateView.IsBalloon = true;
            this.DateView.SetToolTip(this.button1, "Button");*/
        }
    }
}
