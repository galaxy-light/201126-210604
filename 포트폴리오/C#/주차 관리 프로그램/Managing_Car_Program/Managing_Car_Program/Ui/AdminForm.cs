using Managing_Car_Program.Ui;
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

namespace Managing_Car_Program
{
    partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();

            // datagridview 셀클릭입력편집 방지
            dataGridView_parkingAd.ReadOnly = true;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView_parkingAd.DataSource = DataManager.Cars;
        }        
        
        private void button2_Click(object sender, EventArgs e)
        {
            new VipCustViewForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("최신버전입니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            new Txt_view_Form().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("모든 주차 정보를 삭제하시겠습니까? 삭제 시 복구할 수 없습니다.", "경고", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB.DB_mysql.truncate_parking_in_DB();
                DB.DB_mysql.truncate_parking_out_DB();

                dataGridView_parkingAd.DataSource = null;

                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    DataManager.Cars[i].carNumber = "";
                    //DataManager.Cars[i].driverName ="";
                    DataManager.Cars[i].parkingTime = DateTime.Now;
                    //DataManager.Cars[i].phoneNumber = "";
                }

                string str = $"데이터를 전체 삭제했습니다. (DB 전체 삭제 완료)";
                txtwriteLog(str);
                DataManager.Save();

                MessageBox.Show("모든 데이터가 삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("취소되었습니다.");
            }            
        }

        private void txtwriteLog(string txtcontents)
        {
            string txtlogcontents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{txtcontents}";        
            DataManager.printLog(txtlogcontents);
        }
    }
}
