using CarManager0323.DB;
using CarManager0329.Ui;
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
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            //db.dropTable();
            db.dropAllTB();
        }

        private void insertAll_Click(object sender, EventArgs e)
        {
            //db.insertCar();
            db.insertCustomer();
            db.insertSeller();
            db.insertDeal();
            Console.WriteLine("데이터 추가 완료");
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new CarInsForm(db).Show();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            new CusInsForm().Show();
        }

        private void insesrtSeller_Click(object sender, EventArgs e)
        {
            new SellerInsForm().Show();
        }

        private void pro_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+ : 테이블 생성" + "\r" + "- : 테이블 삭제"); // \r : 줄바꿈           
        }
    }
}
