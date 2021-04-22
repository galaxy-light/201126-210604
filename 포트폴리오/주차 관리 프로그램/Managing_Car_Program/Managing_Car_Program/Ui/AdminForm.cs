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
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView_parkingAd.DataSource = DataManager.Cars;
        }
        
        private void button_logout_Click(object sender, EventArgs e)
        {
            Close();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VipCustViewForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("최신버전입니다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("현재 연결된 CCTV가 없습니다.");
            MessageBox.Show("연결되는 메모장에서 parkingHistory폴더의 parkingHistory파일을 열어주세요.");
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_parkingAd.DataSource = null;

            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                DataManager.Cars[i].carNumber = "";
                DataManager.Cars[i].driverName ="";
                DataManager.Cars[i].parkingTime = DateTime.Now;
                DataManager.Cars[i].phoneNumber = "";
            }
            DataManager.Save();
        }
    }
}
