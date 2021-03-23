using CarManager0323.DB;
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
    }
}
