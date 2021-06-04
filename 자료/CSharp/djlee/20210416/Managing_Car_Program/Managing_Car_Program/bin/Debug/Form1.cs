using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleParkingProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

#if(DEBUG)
            //MessageBox.Show("Test");
#else
            //global::System.Windows.Forms.MessageBox.Show("Test2");
#endif

            //DataManager.Load();
            textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();
            textBox_carNumber.Text = DataManager.Cars[0].CarNumber;
            textBox_driverName.Text = DataManager.Cars[0].DriverName;
            textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber;
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        private void button_parkingAdd_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "") //Trim = 공백제거 함수
            {
                MessageBox.Show("주차 공간을 입력해주세요.");
            }
            else if (textBox_carNumber.Text.Trim() == "")//차량 번호도 필수
            {
                MessageBox.Show("차량 번호 입력해주세요.");
            }
            else //공간번호와 차량 번호를 전부 다 입력한 경우
            {
                //해당 공간에 차가 있는지 먼저 조회
                //foreach (var item in DataManager.Cars)
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].ParkingSpot.ToString() == textBox_parkingSpot.Text)
                    {
                        if (DataManager.Cars[i].CarNumber != "")
                        {
                            MessageBox.Show("이미 차가 있습니다!");
                            break; //button_parkingAdd_Click 함수를 끝내버림
                        }
                        else
                        {
                            //없으면 주차하기!
                            /*  <parkingSpot>1</parkingSpot>
                                <carNumber></carNumber>
                                <driverName></driverName>
                                <phoneNumber></phoneNumber>
                                <parkingTime></parkingTime>
                            */


                            DataManager.Cars[i].CarNumber = textBox_carNumber.Text;
                            DataManager.Cars[i].DriverName = textBox_driverName.Text;
                            DataManager.Cars[i].PhoneNumber = textBox_phoneNumber.Text;
                            DataManager.Cars[i].ParkingTime = DateTime.Now;
                            MessageBox.Show($"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text} 차량이 주차하였습니다.");
                            dataGridView_parkingManager.DataSource = null;
                            dataGridView_parkingManager.DataSource = DataManager.Cars;
                            DataManager.Save();
                            break;
                        }
                    }
                }
                //이걸 더 심플하게 하는 버전(Single 메서드는 book Manager 할 때 소개하기)
            }
        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "") //Trim = 공백제거 함수
            {
                MessageBox.Show("주차 공간을 입력해주세요.");
                return;
            }

            //해당 공간에 차가 있는지 먼저 조회
            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                if (DataManager.Cars[i].ParkingSpot.ToString() == textBox_parkingSpot.Text)
                {
                    if (DataManager.Cars[i].CarNumber == "")
                    {
                        MessageBox.Show("아직 차가 없습니다!");
                        break;
                    }
                    else
                    {
                        //있으면 출차하기!
                        /*  <parkingSpot>1</parkingSpot>
                            <carNumber></carNumber>
                            <driverName></driverName>
                            <phoneNumber></phoneNumber>
                            <parkingTime></parkingTime>
                        */


                        DataManager.Cars[i].CarNumber = "";
                        DataManager.Cars[i].DriverName = "";
                        DataManager.Cars[i].PhoneNumber = "";
                        DataManager.Cars[i].ParkingTime = DateTime.Now; //이건 알아서 정의할 것
                        MessageBox.Show($"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text} 차량이 출차되었습니다.");
                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;
                        DataManager.Save();
                        break;
                    }
                }
            }
            //이걸 더 심플하게 하는 버전(Single 메서드는 book Manager 할 때 소개하기)

        }

        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "") //Trim = 공백제거 함수
            {
                MessageBox.Show("주차 공간을 입력해주세요.");
                return;
            }
            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                if (DataManager.Cars[i].ParkingSpot.ToString() == textBox_parkingSpot.Text)
                {
                    if (DataManager.Cars[i].CarNumber == "")
                    {
                        MessageBox.Show("해당 공간에 주차된 차가 없습니다.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text} 차량이 주차되어 있습니다.");
                        break;
                    }
                }
            }
        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;

                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.CarNumber;
                textBox_driverName.Text = car.DriverName;
                textBox_phoneNumber.Text = car.PhoneNumber;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
