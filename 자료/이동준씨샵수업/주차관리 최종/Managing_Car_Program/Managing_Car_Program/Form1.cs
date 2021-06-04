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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Datamanger.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar() { parkingSpot=1, 
            //    carNumber="30고9484",
            //driverName = "이동준",
            //phoneNumber="010-2940-1613",
            //parkingTime = DateTime.Now});

            dataGridView1.DataSource = Datamanager.Cars;
            textBox1.Text = Datamanager.Cars[0].parkingSpot.ToString();
            textBox2.Text = Datamanager.Cars[0].carNumber.ToString();
            textBox3.Text = Datamanager.Cars[0].driverName.ToString();
            textBox4.Text = Datamanager.Cars[0].phoneNumber.ToString();

            //cars.Add(new ParkingCar());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : "
                + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+
                "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차 버튼 클릭");
            //공간번호 
            if(textBox1.Text.Trim() == "") //Trim 공백 제거 함수
            {
                MessageBox.Show("주차공간을 입력해라");
                writeLog("주차공간을 입력해라");
            }
            else if(textBox2.Text.Trim() == "") //차량 번호를 입력하지 않은 경우
            {
                MessageBox.Show("차번호를 입력해라");
                writeLog("차번호를 입력해라");
            }
            else
            {
                try
                {

                    //본격적으로 입력하는 작업 고고씽

                    //참조변수와 람다개념을 알고 있는 경우!
                    ParkingCar car = Datamanager.Cars.Single
                        ((x) => x.parkingSpot.ToString() == textBox1.Text);
                    if (car.carNumber.Trim() != "") //이미 차 정보가 저장되어있음
                    {
                        MessageBox.Show("해당 공간에는 이미 차 있어요." + textBox1.Text);
                        writeLog("해당 공간에는 이미 차 있어요." + textBox1.Text);
                    }
                    else //아직 차 정보가 없음
                    {
                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Datamanager.Cars;
                        Datamanager.Save();

                        string contents = $"주차 공간 {textBox1.Text}에 {textBox2.Text}차를 주차함";
                        MessageBox.Show(contents);
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch (Exception ex)
                {
                    string contents = "주차 할 수 없습니다." + textBox1.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("출차 버튼 클릭");
            
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력해주세요!");
                return;
            }
            //Single 없이 조회하고 해당하는 데이터 변경 
            try
            {
                for (int i = 0; i < Datamanager.Cars.Count; i++)
                {
                    if(Datamanager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if(Datamanager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("아직 차 없음");
                            writeLog("아직 차 없음");
                            break;
                        }
                        else
                        {
                            Datamanager.Cars[i].carNumber = "";
                            Datamanager.Cars[i].driverName = "";
                            Datamanager.Cars[i].phoneNumber = "";
                            Datamanager.Cars[i].parkingTime = DateTime.Now;//알아서 처리
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; //dataGridView1의 데이터를 한 번 지워주고
                            dataGridView1.DataSource = Datamanager.Cars;//다시 리셋
                            Datamanager.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차 안 됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //writeLog("3번 버튼 클릭");
                //writeLog("3번 버튼 클릭",DateTime.Now.ToString("yyyy_MM_dd"));
                writeLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
                int parkingSpot = int.Parse(textBox5.Text);
                string parkedCar = lookUpParkingFunction(parkingSpot);
                string contents = string.Empty;
                if (parkedCar.Trim() != "")
                {
                    contents = $"주차공간 {textBox5.Text}에 주차된 차는 {parkedCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {textBox5.Text}에 주차된 차가 없습니다.";
                }
                writeLog(contents);
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("주차 공간 번호가 이상합니다."+textBox5.Text);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }


        }
        private string lookUpParkingFunction(int parkingSpot) //조회하는 함수(연계 필요 데이터 식별)
        {
            try
            {
                // 공간 번호를 받는다, Single로 조회를 한다.(ver1)
                //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot == parkingSpot);
                //string ParkedCarNumber = car.CarNumber;
                //return ParkedCarNumber;

                //ver2
                // foreach문으로 조회한다.(single이 어려울 경우)
                string ParkedCarNumber = "";
                foreach (var item in Datamanager.Cars)
                {
                    if (item.parkingSpot == parkingSpot)
                        ParkedCarNumber = item.carNumber;
                }
                return ParkedCarNumber;

            }
            catch (Exception e)
            {
                throw;
            }
        }
        private void writeLog(string contents)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00")); 
            //01이라고 출력됨. 3자리 이상 입력하면 그대로 출력됨
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            //옛날 것이 가장 위에 올라가는 방식
            //새로운 내용이 뒤에 추가가 되어서, 새로운 내용을 보려면
            //밑으로 내려가야 함!
            //listBox1.Items.Add(logContens);

            //새로운 것이 가장 위에 올라가는 방식
            //새로운 내용이 가장 앞에 있게 되는 것!
            listBox1.Items.Insert(0, logContens);
            //List<int> list = new List<int>();
            //list.Insert(0, 1);
            Datamanager.printLog(logContens);
        }
        //writeLog 함수를 오버로딩
        private void writeLog(string contents, string date)
        {
            
            string logContens = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]" +
                $"{contents}";

            listBox1.Items.Insert(0, logContens);
            Datamanager.printLog(logContens, date);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                // 클릭해서 조회하고 싶은 경우
                textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
