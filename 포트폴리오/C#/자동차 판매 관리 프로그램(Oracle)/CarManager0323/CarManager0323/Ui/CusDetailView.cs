using CarManager0323.DB;
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

namespace CarManager0331.Ui
{
    partial class CusDetailView : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHander;

        public CusDetailView()
        {
            InitializeComponent();
        }

        public CusDetailView(DaoOracle oracle, DealHandler dHander)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHander = dHander;
        }

        private void CusDetailView_Load(object sender, EventArgs e)
        {

        }

        private void initDealView() // 이 클래스에서만 사용해서 private
        {
            
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0) // 짝수 행
                {
                    item.BackColor = color1;
                }
                else // 홀수 행
                {
                    item.BackColor = color2;
                }
            }
        }


        private void addOkay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CusDetailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
