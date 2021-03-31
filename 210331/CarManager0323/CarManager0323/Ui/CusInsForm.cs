using CarManager0323.DB;
using CarManager0323.Model;
using CarManager0330.Handler;
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

namespace CarManager0329.Ui
{
    partial class CusInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        
        public CusInsForm()
        {
            InitializeComponent();
        }

        public CusInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CusInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void CusInsForm_Load(object sender, EventArgs e)
        {

        }

        private void addOkay_Click(object sender, EventArgs e)
        {
            // if예외처리(공백 오류 처리)
            if (AddCusName.Text == "" || AddCusTel.Text == "" || AddCusAddr.Text == "" || AddCusEmail.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.GetDealList();

            // try/catch 예외처리(입력 문자 오류 처리)
            try
            {
                Customer cus = new Customer(
                    AddCusName.Text,
                    AddCusTel.Text,
                    AddCusAddr.Text,
                    AddCusEmail.Text);
                list[0].Customer = cus;
                oracle.insertCustomer(cus); // cus 매개 변수를 받는 메서드를 생성하면 오류 해결
                Close();
                Console.WriteLine("고객 정보 추가 완료");
                MessageBox.Show("고객 정보 추가 완료");
            }
            catch(NullReferenceException)
            {
                //MessageBox.Show("객체 정보를 확인하세요.");
                MessageBox.Show("올바른 문자로 입력하세요.");
                //Console.WriteLine("객체 정보를 확인하세요.");
                Console.WriteLine("올바른 문자로 입력하세요.");
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
