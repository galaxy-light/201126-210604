using System;
using System.Windows.Forms;

namespace teamProject
{
    public partial class DrugCompInfo_Form : Form
    {
        public DrugCompInfo_Form()
        {
            InitializeComponent();
        }

        private void DrugCompInfo_Form_Load(object sender, EventArgs e)
        {
            drugComp_dtGridView.DataSource = DataManager.Comps;
            DataManager.Save();
        }

        private void btn_DrugComp_Add_Click(object sender, EventArgs e)
        {
            DataManager.Comps.Add(new Entp(compName_txtBox.Text, compTel_txtBox.Text, compAddr_txtBox.Text, compEmail_txtBox.Text));
            resetList();
            MessageBox.Show("추가되었습니다.", "추가 완료");
            compName_txtBox.Text = "";
            compTel_txtBox.Text = "";
            compAddr_txtBox.Text = "";
            compEmail_txtBox.Text = "";
        }

        private void drugComp_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Entp temp = drugComp_dtGridView.CurrentRow.DataBoundItem as Entp;
                compName_txtBox.Text = temp.entpName;
                compTel_txtBox.Text = temp.entpTel;
                compAddr_txtBox.Text = temp.entpAddr;
                compEmail_txtBox.Text = temp.entpEmail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_DrugComp_Edit_Click(object sender, EventArgs e)
        {
            int n = drugComp_dtGridView.CurrentCell.RowIndex;
            //MessageBox.Show(n.ToString());
            DataManager.Comps[n].entpName = compName_txtBox.Text;
            DataManager.Comps[n].entpTel = compTel_txtBox.Text;
            DataManager.Comps[n].entpAddr = compAddr_txtBox.Text;
            DataManager.Comps[n].entpEmail = compEmail_txtBox.Text;
            resetList();
        }

        private void resetList()
        {
            DataManager.Save();
            drugComp_dtGridView.DataSource = null;
            drugComp_dtGridView.DataSource = DataManager.Comps;
        }

        private void btn_DrugComp_Del_Click(object sender, EventArgs e)
        {
            int n = drugComp_dtGridView.CurrentCell.RowIndex;
            DataManager.Comps.RemoveAt(n);
            resetList();
        }
    }
}

