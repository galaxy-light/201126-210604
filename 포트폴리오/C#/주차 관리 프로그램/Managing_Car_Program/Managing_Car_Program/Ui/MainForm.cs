using Managing_Car_Program.Control;
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
    public partial class MainForm : MaterialForm
    {       
        private DateTime parkingin;
        private DateTime parkingout;

        public MainForm()
        {
            InitializeComponent();
            starttimer();

            // MySQL DB셋팅 초기화
            DB.DB_mysql.OpenConnection();

            /*List<ParkingCar> cars = new List<ParkingCar>();
            cars.Add(new ParkingCar() { parkingSpot = 1, carNumber = "30고1234",
                driverName = "홍길동", phoneNumber = "010-1234-9876", parkingTime = DateTime.Now });

            // 이렇게 실행했을 때 결과값으로 데이터그리드뷰에 2줄이 나오는 이유는
            dataGridView1.DataSource = cars; // 여기가 cars가 주소지이기 때문에 두 줄로 나옴
            
            cars.Add(new ParkingCar()); // cars는 두 줄*/

            //DataManager.Load();
            dataGridView_main.DataSource = DataManager.Cars;

            textBox_num.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox_carnum.Text = DataManager.Cars[0].carNumber.ToString();
            /*textBox_cust_start.Text = DataManager.Cars[0].driverName.ToString();
            textBox_cust_end.Text = DataManager.Cars[0].phoneNumber.ToString();*/

            // datagridview 셀클릭입력편집 방지
            dataGridView_main.ReadOnly = true;            
        }

        ~MainForm() // 소멸자(프로그램의 안정성을 위해 사용)
        {
            DataManager.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            timertext();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            timenow();
        }

        private void timenow()
        {
            Label_Current_Time.Text = "현재 시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        int count = 0;
        private void timertext()
        {
            count = count + 1;           
            textBox_cust_start.Text = "";
            textBox_cust_end.Text = "";
            //label_money_result.Text = "-";
        }

        private void starttimer()
        {
            timer1.Interval = 10000;
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_spotnum.Text == "")
            {
                MessageBox.Show("번호를 입력해주세요.");
                return;
            }
            //writeLog("조회 버튼 클릭");
            //writeLog("3번 버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
            // 3번 버튼 클릭은 내용이 되고 DateTime.Now.ToString("yyyy_MM_dd")은 파일 이름이 됨
            //writeLog("무", "야호"); // 확인용 writeLog()
            try
            {              
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox_spotnum.Text)
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
            listBox.Items.Insert(0, logContents); // Insert(0, logContents) : 0번째 인덱스에 logContents을 넣겠다는 뜻
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
            listBox.Items.Insert(0, logContents); // Insert(0, logContents) : 0번째 인덱스에 logContents을 넣겠다는 뜻
            // Insert : 내가 원하는 위치에 저장

            DataManager.printLog(logContents, date);
        }        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("프로그램이 종료됩니다. \r이용해주셔서 감사합니다.");
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {            
            Autoclosingmbox.showmbox("관리자 모드로 진입합니다.", "알림", 500); // 0.5초뒤 자동 소멸 메세지박스
            //Autoclosingmbox.showmbox("관리자 모드로 진입합니다.", "알림", 1000);
            // 관리자 모드로 진입합니다. : 내용 / 알림 : 타이틀 / 500ms : 500밀리초
            new LogForm().ShowDialog(); // ShowDialog : 데이터 연결 가능 / show : 데이터 연결 불가
            dataGridView_main.DataSource = null;
            dataGridView_main.DataSource = DataManager.Cars;
        }               

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tooltip();
        }

        private void tooltip()
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip1.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip1.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip1.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip1.SetToolTip(uiSymbolButton_other, "다른 주차장 보기");

            ToolTip tooltip2 = new ToolTip();
            tooltip2.ShowAlways = true;
            tooltip2.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip2.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip2.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip2.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip2.SetToolTip(uiSymbolButton_cust_add, "정기권 구매");

            ToolTip tooltip3 = new ToolTip();
            tooltip3.ShowAlways = true;
            tooltip3.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip3.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip3.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip3.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip3.SetToolTip(uiSymbolButton_help, "도움말");

            ToolTip tooltip4 = new ToolTip();
            tooltip4.ShowAlways = true;
            tooltip4.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip4.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip4.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip4.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip4.SetToolTip(Button_adminlog, "관리자 로그인");
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            //writeLog("주차 버튼 클릭");
            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                string str = textBox_carnum.Text;
                str = string.Concat(str.Where(x => !char.IsWhiteSpace(x))); // 모든 공백 삭제               
                if (str == DataManager.Cars[i].carNumber)
                {
                    MessageBox.Show("이미 주차된 차량입니다.");
                    return;
                }
            }            
            if (textBox_num.Text.Trim() == "") // Trim : 공백 제거 함수 / 공간 번호가 공백일 경우
            {
                MessageBox.Show("주차 공간을 입력하세요.");
                writeLog("주차 공간을 입력하세요.");
            }
            else if (textBox_carnum.Text.Trim() == "") // 차량 번호를 입력하지 않은 경우
            {
                MessageBox.Show("차량 번호를 입력하세요.");
                writeLog("차량 번호를 입력하세요.");
                return;
            }            
            else
            {
                try
                {
                    // 참조 변수와 람다 개념
                    ParkingCar car = DataManager.Cars.Single((x) => x.parkingSpot.ToString() == textBox_num.Text);
                    // => : 람다 : 함수의 변수화
                    // Single이라는 변수에 (x)=>x.parkingSpot.ToString() == textBox1.Text의 함수가 들어간 것
                    // x : Cars의 각각의 요소
                    // Single : parkingSpot의 텍스트와 textBox1의 텍스트가 일치하는 값하나를 car에 던져줌
                    // car : 데이터가 들어가는게 아니고 값의 주소를 가져옴
                    if (car.carNumber.Trim() != "") // 이미 차량 정보가 저장되어있음
                    {
                        MessageBox.Show("해당 공간에는 이미 차량이 있습니다. " + "공간 번호 : " + textBox_num.Text);
                        writeLog("해당 공간에는 이미 차량이 있습니다. " + "공간 번호 : " + textBox_num.Text);
                    }
                    else // 아직 차량 정보가 없음
                    {
                        DateTime Now = DateTime.Now;
                        parkingin = Now;
                        label_in_time.Text = parkingin.ToString("HH:mm:ss");

                        for (int i = 0; i < VipData.vips.Count; i++)
                        {
                            if (textBox_carnum.Text == VipData.vips[i].custcarnum)
                            {
                                textBox_cust_start.Text = VipData.vips[i].custstart;
                                textBox_cust_end.Text = VipData.vips[i].custend;                                                          
                            }                            
                        }

                        // 참조 변수
                        // car : 주소값 : 리스트에 있는 해당하는 주소값을 변경하기 때문에 그 주소의 데이터값만 변경됨
                        car.parkingSpot = int.Parse(textBox_num.Text);
                        car.carNumber = textBox_carnum.Text;
                        /*car.driverName = textBox_cust_start.Text;
                        car.phoneNumber = textBox_cust_end.Text;*/
                        car.parkingTime = Now;

                        dataGridView_main.DataSource = null;
                        dataGridView_main.DataSource = DataManager.Cars;

                        // MySql 저장
                        DB.DB_mysql.insert_in_DB(textBox_num.Text, textBox_carnum.Text, label_in_time.Text);

                        string contents = $"주차공간 : {textBox_num.Text}에 차량번호 : {textBox_carnum.Text}을 주차합니다. (DB 저장 완료)";                        
                        writeLog(contents, Now.ToString("yyyy_MM_dd")); // 두번째 파라미터값(DateTime.Now.ToString("yyyy_MM_dd"))은 적어도 되고 안적어도 되고
                        
                        DataManager.Save();
                    }
                }
                catch (Exception ex) // 형변환(문자열 -> 정수)이 안되기 때문에 예외처리
                {
                    string contents = "주차할 수 없습니다. " + "공간 번호 : " + textBox_num.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                    //throw;
                }
            }
        }

        private void button_out_Click(object sender, EventArgs e)
        {           
            //new ParkingCheckForm().ShowDialog();
            //writeLog("출차 버튼 클릭");
            // 참조 변수 개념X
            if (textBox_num.Text.Trim() == "")
            {
                MessageBox.Show("주차 공간 번호를 입력해주세요.");
                return;
            }           
            // Single없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox_num.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            MessageBox.Show("주차 공간에 차량이 없습니다.");
                            writeLog("주차 공간에 차량이 없습니다.");
                            break;
                        }                        
                        else
                        {
                            VipData.Load();
                            Boolean isThisJungGiGwon = false;
                            for (int j = 0; j < VipData.vips.Count; j++)
                            {
                                if (textBox_carnum.Text == VipData.vips[j].custcarnum)
                                {
                                    textBox_cust_start.Text = VipData.vips[j].custstart;
                                    textBox_cust_end.Text = VipData.vips[j].custend;
                                   
                                    isThisJungGiGwon = true;

                                    string contents1 = null;
                                    contents1 = $"주차공간 : {textBox_num.Text} 차량번호 : {textBox_carnum.Text}을 출차합니다.";
                                    //MessageBox.Show(contents);                            
                                    writeLog(contents1);
                                    dataGridView_main.DataSource = null; // dataGridView1의 데이터를 한 번 지워주고
                                    dataGridView_main.DataSource = DataManager.Cars; // 다시 리셋
                                    DataManager.Save();

                                    break;
                                }                                
                            }

                            DateTime Now = DateTime.Now;
                            parkingout = Now;
                            label_out_time.Text = parkingout.ToString("HH:mm:ss");
                            
                            DataManager.Cars[i].parkingTime = checkExpire(Now, out isThisJungGiGwon, DataManager.Cars[i].parkingTime);
                            if (isThisJungGiGwon == false)
                            {
                                VipData.Savetxt();
                            }

                            // 이용시간 메서드
                            Timetxt(DataManager.Cars[i].parkingTime, Now);
                            
                            if(isThisJungGiGwon) // isThisJungGiGwon = true일 때
                            {
                                label_money_result.Text = "정기권"; // 실행
                            }
                            else
                            {
                                // 정산요금 메서드
                                resultmoney(DataManager.Cars[i].parkingTime, Now);
                            }

                            DataManager.Cars[i].carNumber = "";
                            /*DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";*/
                            DataManager.Cars[i].parkingTime = Now;

                            // MySql 저장
                            DB.DB_mysql.insert_out_DB(textBox_num.Text, textBox_carnum.Text, label_out_time.Text);

                            string contents = $"주차공간 : {textBox_num.Text} 차량번호 : {textBox_carnum.Text}을 출차합니다.";
                            //MessageBox.Show(contents);                            
                            writeLog(contents);
                            dataGridView_main.DataSource = null; // dataGridView1의 데이터를 한 번 지워주고
                            dataGridView_main.DataSource = DataManager.Cars; // 다시 리셋
                            DataManager.Save();
                            break;
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                writeLog("출차가 되지 않았습니다.");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                //throw;
            }
        }

        #region 정기권 체크
        //정기권이 있는가?
        //없다면 아무것도 변경하지 않고 그대로 끝내면 된다.
        //하지만 있다면?
        //있는 데 주차할 때부터 기간이 지난 경우 그대로 끝냄
        //있는 데 기간을 지나지 않았다면 이 때도 그대로 보낸다.(정기권 소멸일 전에 주차해서 출차함)
        //있는 데 기간을 지나서 출차한 것이라면 정기권은 소멸되고 대신 입차 시간을 정기권 소멸시점으로 바꿔줘야 한다.
        public DateTime checkExpire(DateTime outDate, out Boolean isThisJungGiGwon, DateTime inDate)
        {
            try
            {
                VipData.Load();
                for (int i = 0; i < VipData.vips.Count; i++)
                {
                    if (textBox_carnum.Text == VipData.vips[i].custcarnum)
                    {
                        String[] YMD = VipData.vips[i].custend.Split('-'); //2021-04-29에서 - 삭제
                        DateTime expireDate = new DateTime(int.Parse(YMD[0]), int.Parse(YMD[1]), int.Parse(YMD[2]));
                        TimeSpan diff = expireDate - outDate;
                        TimeSpan diff_already_expired = expireDate - inDate; //너무 옛날꺼라서 주차할 때부터 이미 만기된 상태
                        int already_total = (int)diff_already_expired.TotalSeconds;
                        if (already_total < 0) //아무런 연산을 할 게 없다. 정기권 없는 상태랑 똑같다.
                        {
                            VipData.vips.RemoveAt(i);
                            break;
                        }

                        if (diff.TotalSeconds < 0) //만기 이후 출차함!
                        {
                            isThisJungGiGwon = false;
                            VipData.vips.RemoveAt(i);
                            int totalSecond = (int)diff.TotalSeconds; // 전체 시간
                            int totalHour = totalSecond / 60 / 60; // 시
                            inDate = expireDate; //주차일시를 만기권 일시로 변경한다. 어차피 만기된 시점부터 계산할거고 그 계산은 밑에서부터 한다.
                            return inDate;
                        }
                        else //만기 이전 출차
                        {
                            isThisJungGiGwon = true;
                            return inDate; //받아온 값을 그대로 리턴함. 왜냐면 어차피 정기권 상태니까. 뭘 해도 됨...
                        }
                    }
                }
                //정기권이 없을 경우
                isThisJungGiGwon = false;
                return inDate; //받아온 값 그대로 리턴함
            }
            catch (Exception ex)
            {
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
                throw new Exception("정기권 만료 체크 실패 예외 메시지 확인해주세요.");
            }
        }
        #endregion

        public void Timetxt(DateTime incar, DateTime outcar)
        {

            //DateTime intime = Convert.ToDateTime(label_in_time.Text);
            //DateTime outtime = Convert.ToDateTime(label_out_time.Text);

            TimeSpan timeDiff = outcar - incar;          

            int hourDiff = timeDiff.Hours; //시간 차이는 이 값 이용
            int DayDiff = timeDiff.Days;
            double totalHourDiff = timeDiff.TotalHours;
            double totalSecondDiff = timeDiff.TotalSeconds;
            writeLog("출차시간 : "+ outcar.Hour.ToString());
            writeLog("주차시간 : " + incar.Hour.ToString());
            writeLog("주차일자 : " + incar.Day.ToString());
            writeLog("출차일자 : " + outcar.Day.ToString());
            writeLog("출차-주차 시간차이 : " + hourDiff.ToString());
            writeLog("출차-주차 날짜차이 : " + DayDiff.ToString());
            writeLog("출차-주차 전체시간차이 : " + totalHourDiff.ToString());
            //string timeresult = string.Format("{0:hh:mm:ss}", timeDiff.ToString());
            string timeresult = timeDiff.Hours + ":" + timeDiff.Minutes + ":" + timeDiff.Seconds;

            //잘 안 됨! (10시에 주차하고 14시 출차시... 다음날14시인지 당일14시인지 모름)
            //if (dataresult.Equals("24:00:00"))
            //{
            //    label_in_out_result.Text = "24:00:00";
            //}
            //else
            //{
            //    label_in_out_result.Text = (string.Format("{0:HH:mm:ss}", timeresult));
            //}

                /*if (totalHourDiff >= 24)
                {
                    //MessageBox.Show("24시간 이용하셨습니다.");
                    label_in_out_result.Text = "1일 이용";
                }
                else
                {
                    //label_in_out_result.Text = (string.Format("{0:HH:mm:ss}", timeresult));                  
                    writeLog("totalsecond : " + totalSecondDiff.ToString());
                    //label_in_out_result.Text = timeresult;

                    int totalsecond = (int)totalSecondDiff; //소수점 버림
                    int sec = totalsecond % 60 % 60;
                    int min = totalsecond / 60;
                    int hour = min / 60;
                    label_in_out_result.Text = hour.ToString("00") + ":" + (min % 60).ToString("00") + ":" + sec.ToString("00");
                }*/


            if (totalHourDiff <= 24)
            {
                //label_in_out_result.Text = (string.Format("{0:HH:mm:ss}", timeresult));                  
                writeLog("totalsecond : " + totalSecondDiff.ToString());
                //label_in_out_result.Text = timeresult;

                int totalsecond = (int)totalSecondDiff; //소수점 버림
                int sec = totalsecond % 60 % 60;
                int min = totalsecond / 60;
                int hour = min / 60;
                label_in_out_result.Text = hour.ToString("00") + ":" + (min % 60).ToString("00") + ":" + sec.ToString("00");
            }
            else if (totalHourDiff > 24 && totalHourDiff <= 48)
            {
                //MessageBox.Show("24시간 이용하셨습니다.");
                label_in_out_result.Text = "1일 이용";
            }
            else if (totalHourDiff > 48 && totalHourDiff <= 60)
            {
                label_in_out_result.Text = "2일 이용";
            }
            else if (totalHourDiff > 60 && totalHourDiff <= 96)
            {
                label_in_out_result.Text = "3일 이용";
            }                
            else if (totalHourDiff > 1440)
            {
                label_in_out_result.Text = "두달 초과";
            }
           
            string contents = $"이용시간 : {label_in_out_result.Text}";
            //MessageBox.Show(contents);           
            writeLog(contents);
        }

        private void resultmoney(DateTime parkIn, DateTime parkOut)
        {
            // 계산법 = (주차시간/단위시간)*요금
            //TimeSpan ts = parkingout - parkingin;    
            string totalMoney = calctime(parkOut - parkIn);
            writeLog("resultmoney :" + totalMoney);            
            label_money_result.Text = totalMoney;
        }

        private string calctime(TimeSpan ts)
        {
            writeLog("calctime " + "label_in_out_result " + ((Convert.ToInt32((int)ts.TotalMinutes / Convert.ToInt32(label_time.Text)))
                    * Convert.ToInt32(label_money.Text)));
            writeLog("" + (int)ts.TotalMinutes);
            writeLog(label_time.Text);
            writeLog(label_money.Text);

            if (label_in_out_result.Text == "1일 이용")
            {
                return "10000원";
            }
            else if (label_in_out_result.Text == "2일 이용")
            {
                return "20000원";
            }
            else if (label_in_out_result.Text == "3일 이용")
            {
                return "30000원";
            }           
            else if (label_in_out_result.Text == "두달 초과")
            {
                return "견인";
            }
            else if (label_in_out_result.Text == "정기권")
            {
                return "정기권";
            }
            else
            {
                return ((Convert.ToInt32((int)ts.TotalMinutes / Convert.ToInt32(label_time.Text)))
                    * Convert.ToInt32(label_money.Text)).ToString();
            }
        }

        private void button_check2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < DataManager.Cars.Count; i++)
            {
                if (DataManager.Cars[i].carNumber.Equals(""))
                {
                    count += 1;
                }
            }
            label_spot_num.Text = count.ToString() + "칸";
        }

        private void dataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    // CurrentRow : 클릭한 행의 전체 줄
                    // DataBoundItem : 클릭한 리스트의 저장된 데이터
                    ParkingCar temp = dataGridView_main.CurrentRow.DataBoundItem as ParkingCar; // ParkingCar를 형변환해서 temp에 넣음
                    textBox_num.Text = temp.parkingSpot.ToString();
                    textBox_carnum.Text = temp.carNumber;
                    //textBox_carnm.Text = temp.driverName;
                    //textBox_carph.Text = temp.phoneNumber;

                    // 조회 기능에 바로 공간 번호를 넣고 싶으면
                    textBox_spotnum.Text = temp.parkingSpot.ToString();
                    
                    label_in_time.Text = temp.parkingTime.ToString("HH:mm:ss");
                    label_out_time.Text = DateTime.Now.ToString("HH:mm:ss");
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
        }

        private void uiSymbolButton_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램 오류시 관리자에게 연락주세요.\r" +
                "관리자 : 000-0000-0000");
        }

        private void uiSymbolButton_cust_add_Click(object sender, EventArgs e)
        {
            new Cust_cu_add_Form().Show();
        }

        private void uiSymbolButton_other_Click(object sender, EventArgs e)
        {
            new Other_parking_view_Form().Show();
        }
    }
}
