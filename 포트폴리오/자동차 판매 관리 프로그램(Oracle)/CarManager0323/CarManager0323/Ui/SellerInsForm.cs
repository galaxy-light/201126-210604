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
    partial class SellerInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public SellerInsForm()
        {
            InitializeComponent();
        }
        public SellerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public SellerInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void SellerInsForm_Load(object sender, EventArgs e)
        {

        }

        private void addOkay_Click(object sender, EventArgs e)
        {
            if (AddSellerName.Text == "" || AddSellerTel.Text == ""
                || AddSellerEmail.Text == "" || AddSellerRank.Text == "" || AddSellerPlace.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                return;
            }

            List<Deal> list = dHandler.GetDealList();

            try
            {
                Seller sel = new Seller(
                    AddSellerName.Text,
                    AddSellerTel.Text,
                    AddSellerEmail.Text,
                    AddSellerRank.Text,
                    AddSellerPlace.Text);
                list[0].Seller = sel;
                oracle.insertSeller(sel);
                Close();
                Console.WriteLine("판매자 정보 추가 완료");
                MessageBox.Show("판매자 정보 추가 완료");
            }
            catch(FormatException)
            {
                MessageBox.Show("올바른 문자로 입력하세요.");
                Console.WriteLine("올바른 문자로 입력하세요.");
            }
        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
