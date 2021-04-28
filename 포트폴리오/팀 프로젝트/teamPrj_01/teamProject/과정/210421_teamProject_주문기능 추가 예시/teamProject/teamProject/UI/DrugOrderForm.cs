using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.model;

namespace teamProject
{
    partial class DrugOrderForm : Form
    {
        public static List<DrugOrder> orders = new List<DrugOrder>();

        public DrugOrderForm()
        {
            InitializeComponent();
        }

        private void DrugOrderForm_Load(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                drugOrder_dtGridView.Rows.Add(item.Drug.MedName, item.Entp.entpName, item.Count);
            }
        }
    }
}
