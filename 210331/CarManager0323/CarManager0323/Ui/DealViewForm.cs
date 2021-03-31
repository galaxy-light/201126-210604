using CarManager0323.DB;
using CarManager0330.Handler;
using CarManager0331.Model;
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
    partial class DealViewForm : MaterialForm
    {        
        private DaoOracle oracle;
        private DealHandler dHandler;

        public DealViewForm()
        {
            InitializeComponent();
        }

        // 오버로딩 -> 클래스의 public 삭제(16라인)
        public DealViewForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void DealViewForm_Load(object sender, EventArgs e)
        {
            initDealView();
            //oracle.selectDeal();
        }

        private void DealList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void initDealView() // 이 클래스에서만 사용해서 private
        {
            List<DealResult> list = oracle.selectDeal();

            if (list == null)
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
                return;
            }

            /*string[] data = { "1", "홍길동", "그랜저", "40000000", "전우치", "21/3/21" };
            DealList.Items.Add(new ListViewItem(data));*/

            for (int i = 0; i < list.Count; i++)
            {
               /* DealList.Items.Add(new ListViewItem(
                    new string[] { (i + 2).ToString(), "홍길동", "그랜저", "40000000", "전우치", "21/3/21" }));*/

                DealList.Items.Add(new ListViewItem(new string[] {
                        list[i].Count.ToString(),
                        list[i].CusName,
                        list[i].Carmodel,
                        list[i].Price,
                        list[i].SellName,
                        list[i].Date }));
            }
            setRowColor(DealList, Color.White, Color.LightBlue);
            int index = DealList.Items.Count - 1;
            DealList.Items[index].Selected = true;
            DealList.Items[index].Focused = true;
            DealList.EnsureVisible(index);
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

        private void CusDetailView_Click(object sender, EventArgs e)
        {
            new CusDetailView().ShowDialog();
        }
    }
}
