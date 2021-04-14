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
                

        private void addOkay_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CusDetailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
