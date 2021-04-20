﻿using MaterialSkin.Controls;
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
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            /*List<ParkingCar> cars = new List<ParkingCar>();
            cars.Add(new ParkingCar() { parkingSpot = 1, carNumber = "30고1234",
                driverName = "홍길동", phoneNumber = "010-1234-9876", parkingTime = DateTime.Now });

            // 이렇게 실행했을 때 결과값으로 데이터그리드뷰에 2줄이 나오는 이유는
            dataGridView1.DataSource = cars; // 여기가 cars가 주소지이기 때문에 두 줄로 나옴
            
            cars.Add(new ParkingCar()); // cars는 두 줄*/

            //DataManager.Load();
            dataGridView1.DataSource = DataManager.Cars;

            textBox1.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].carNumber.ToString();
            textBox3.Text = DataManager.Cars[0].driverName.ToString();
            textBox4.Text = DataManager.Cars[0].phoneNumber.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "현재 시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("주차 버튼 클릭");
            if (textBox1.Text.Trim() == "") // Trim : 공백 제거 함수 / 공간 번호가 공백일 경우
            {
                MessageBox.Show("주차 공간을 입력하세요.");
                writeLog("주차 공간을 입력하세요.");
            }
            else if (textBox2.Text.Trim() == "") // 차량 번호를 입력하지 않은 경우
            {
                MessageBox.Show("차량 번호를 입력하세요.");
                writeLog("차량 번호를 입력하세요.");
            }            
            else
            {
                try
                {
                    // 참조 변수와 람다 개념
                    ParkingCar car = DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox1.Text);
                    // => : 람다 : 함수의 변수화
                    // Single이라는 변수에 (x)=>x.parkingSpot.ToString() == textBox1.Text의 함수가 들어간 것
                    // x : Cars의 각각의 요소
                    // Single : parkingSpot의 텍스트와 textBox1의 텍스트가 일치하는 값하나를 car에 던져줌
                    // car : 데이터가 들어가는게 아니고 값의 주소를 가져옴
                    if (car.carNumber.Trim() != "") // 이미 차량 정보가 저장되어있음
                    {
                        MessageBox.Show("해당 공간에는 이미 차량이 있습니다. " + "공간 번호 : " + textBox1.Text);
                        writeLog("해당 공간에는 이미 차량이 있습니다. " + "공간 번호 : " + textBox1.Text);
                    }
                    else // 아직 차량 정보가 없음
                    {
                        // 참조 변수
                        // car : 주소값 : 리스트에 있는 해당하는 주소값을 변경하기 때문에 그 주소의 데이터값만 변경됨
                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();

                        string contents = $"주차공간 : {textBox1.Text}에 차량번호 : {textBox2.Text}을 주차합니다.";
                        writeLog(contents, DateTime.Now.ToString("yyyy_MM_dd")); // 두번째 파라미터값(DateTime.Now.ToString("yyyy_MM_dd"))은 적어도 되고 안적어도 되고
                    }
                }
                catch (Exception ex) // 형변환(문자열 -> 정수)이 안되기 때문에 예외처리
                {
                    string contents = "주차할 수 없습니다. " + "공간 번호 : " + textBox1.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                    //throw;
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ParkingCheckForm().ShowDialog();
            writeLog("출차 버튼 클릭");
            // 참조 변수 개념X
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력해주세요.");
                return;
            }
            // Single없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("주차 공간에 차량이 없습니다.");
                            writeLog("주차 공간에 차량이 없습니다.");
                            break;
                        }
                        else
                        {
                            DataManager.Cars[i].carNumber = "";
                            DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";
                            DataManager.Cars[i].parkingTime = DateTime.Now; // 알아서 처리
                            string contents = $"주차공간 : {textBox1.Text} 차량번호 : {textBox2.Text}을 출차합니다.";
                            //MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView1.DataSource = null; // dataGridView1의 데이터를 한 번 지워주고
                            dataGridView1.DataSource = DataManager.Cars; // 다시 리셋
                            DataManager.Save();
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
                //throw;
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("조회 버튼 클릭");
            //writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
            // 3번 버튼 클릭은 내용이 되고 DateTime.Now.ToString("yyyy_MM_dd")은 파일 이름이 됨
            //writeLog("무", "야호"); // 확인용 writeLog()
            try
            {              
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox5.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("해당 공간에 주차된 차량이 없습니다.");
                            writeLog("해당 공간에 주차된 차량이 없습니다.");
                            break;
                        }
                        else
                        {
                            string contents = $"공간번호 : {DataManager.Cars[i].parkingSpot}에 차량번호 : {DataManager.Cars[i].carNumber}이 있습니다.";
                            MessageBox.Show(contents);
                            writeLog($"{contents}");                           
                        }
                    }                                                                                               
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                //throw;
            }
        }

        private void writeLog(string contents)
        {
            /*int a = 1;
            MessageBox.Show(a.ToString("00")); // 01이 출력됨 -> 두자리로 바뀜
            a = 100;
            MessageBox.Show(a.ToString("00")); // 100이 출력됨 -> 3자리 이상 입력하면 그대로 출력됨*/

            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contents}"; // 현재 시간을 스트링화

            //listBox1.Items.Add(logContents); // 과거의 기록이 맨 위로 올라가는 방식(새로운 내용이 추가가 되면 밑으로 내려야 함)
            // Add : 내용이 추가가 되는 형식

            // 새로운 것이 맨 위로 올라가는 방식(새로운 내용이 가장 앞에 있게 되는 것)
            listBox1.Items.Insert(0, logContents); // Insert(0, logContents) : 0번째 인덱스에 logContents을 넣겠다는 뜻
            // Insert : 내가 원하는 위치에 저장

            DataManager.printLog(logContents);
        }

        // writeLog 함수를 오버로딩
        private void writeLog(string contents, string date)
        {
            /*int a = 1;
            MessageBox.Show(a.ToString("00")); // 01이 출력됨 -> 두자리로 바뀜
            a = 100;
            MessageBox.Show(a.ToString("00")); // 100이 출력됨 -> 3자리 이상 입력하면 그대로 출력됨*/

            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{contents}"; // 현재 시간을 스트링화

            //listBox1.Items.Add(logContents); // 과거의 기록이 맨 위로 올라가는 방식(새로운 내용이 추가가 되면 밑으로 내려야 함)
            // Add : 내용이 추가가 되는 형식

            // 새로운 것이 맨 위로 올라가는 방식(새로운 내용이 가장 앞에 있게 되는 것)
            listBox1.Items.Insert(0, logContents); // Insert(0, logContents) : 0번째 인덱스에 logContents을 넣겠다는 뜻
            // Insert : 내가 원하는 위치에 저장

            DataManager.printLog(logContents, date);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CurrentRow : 클릭한 행의 전체 줄
                // DataBoundItem : 클릭한 리스트의 저장된 데이터
                ParkingCar temp = dataGridView1.CurrentRow.DataBoundItem as ParkingCar; // ParkingCar를 형변환해서 temp에 넣음
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                // 조회 기능에 바로 공간 번호를 넣고 싶으면
                //textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                //throw;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("프로그램이 종료됩니다. \r이용해주셔서 감사합니다.");
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            new LogForm().ShowDialog();
        }
    }
}
