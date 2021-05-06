using AddressTest0222;
using AddressTest0222.control;
using Address0324.DB;
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

namespace Address0303.Ui
{
    partial class UpdateForm : MaterialForm
    {
        AddressCtrl sc;

        DataSet ds = new DataSet();

        int nowselect;

        // 오버로딩
        public UpdateForm(AddressCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            datarefresh();
            exnameBox.Enabled = false;       
        }

        private void datarefresh()
        {
            ds = Address0324.DB.MYSQL.Query_Select("My_Address");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "My_Address";
        }        

        private void updateExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            Upaddrinfo();            
        }

        private void Upaddrinfo()
        {
            if (exnameBox.Text != "" && extelBox.Text != "" && exaddressBox.Text != "" && extelBox.Text != "")
            {
                Address0324.DB.MYSQL.UpdateDB(exnameBox.Text, extelBox.Text, exaddressBox.Text, exemailBox.Text);
                MessageBox.Show("정보가 수정되었습니다.");
                datarefresh();
                cleartext();
            }
            else
            {
                MessageBox.Show("정보가 수정되지 않았습니다.");
                return;
            }            
        }  
                
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var list = dataGridView1.CurrentRow;                
                exnameBox.Text = list.Cells[0].Value.ToString();
                extelBox.Text = list.Cells[1].Value.ToString();
                exaddressBox.Text = list.Cells[2].Value.ToString();
                exemailBox.Text = list.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }

        private void idDelete_Click(object sender, EventArgs e)
        {
            if (exnameBox.Text != "" && extelBox.Text != "" && exaddressBox.Text != "" && extelBox.Text != "")
            {
                Address0324.DB.MYSQL.DeleteDB(exnameBox.Text);
                MessageBox.Show("정보가 삭제되었습니다.");
                datarefresh();
                cleartext();
            }
            else
            {
                MessageBox.Show("정보가 삭제되지 않았습니다.");
                return;
            }           
        }

        private void cleartext()
        {
            exnameBox.Text = "";
            extelBox.Text = "";
            exaddressBox.Text = "";
            exemailBox.Text = "";
        }
    }
}
