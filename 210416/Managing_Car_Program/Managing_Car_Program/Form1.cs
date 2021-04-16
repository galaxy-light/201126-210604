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
            WhatTime.Text = "현재 시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번 버튼 클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번 버튼 클릭");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //writeLog("3번 버튼 클릭");
            writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
            // 3번 버튼 클릭은 내용이 되고 DateTime.Now.ToString("yyyy_MM_dd")은 파일 이름이 됨
            //writeLog("무", "야호");
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
    }
}
