using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather
{
    public partial class MainForm : MetroForm
    {
        string url = "http://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";
        string city = "";
        static int avg1;
        static int avg2;
        static int avg3;
        static int avg4;
        static int avg5;
        static int avg6;

        public MainForm()
        {
            InitializeComponent();

            comboBox_city.SelectedIndex = 0;            
            label_nowday.Text = "오늘은 "+ DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader xr = XmlReader.Create(url))
                {
                    string msg = "";
                    XmlWriterSettings ws = new XmlWriterSettings();
                    ws.Indent = true;
                    bool check = false;
                    int count = 0;
                    city = comboBox_city.Text;

                    while (xr.Read())
                    {
                        switch (xr.NodeType)
                        {
                            case XmlNodeType.CDATA:
                                {
                                    textBox1.Text = xr.Value.ToString().Replace("<br />", "");
                                    break;
                                }
                            /*case XmlNodeType.None:                                
                                break;*/
                            case XmlNodeType.Element:
                                break;
                            /*case XmlNodeType.Attribute:
                                break;*/
                            case XmlNodeType.Text:
                                {
                                    if (xr.Value.Equals(city))
                                    {
                                        check = true;
                                    }
                                    if (check)
                                    {
                                        DateTime ti;
                                        bool b = DateTime.TryParse(xr.Value.ToString(), out ti);
                                        if (b)
                                        {
                                            msg += "/";
                                        }
                                        msg += xr.Value + ",";
                                        count += 1;
                                        if (count > 36)
                                        {
                                            check = false;
                                        }
                                    }
                                    break;
                                }                                                                   
                            /*case XmlNodeType.EntityReference:
                                break;*/
                            /*case XmlNodeType.Entity:
                                break;*/
                            case XmlNodeType.ProcessingInstruction:
                                break;
                            case XmlNodeType.Comment:
                                break;
                            /*case XmlNodeType.Document:
                                break;*/
                            /*case XmlNodeType.DocumentType:
                                break;*/
                            /*case XmlNodeType.DocumentFragment:
                                break;*/
                            /*case XmlNodeType.Notation:
                                break;*/
                            /*case XmlNodeType.Whitespace:
                                break;*/
                           /* case XmlNodeType.SignificantWhitespace:
                                break;*/
                            case XmlNodeType.EndElement:
                                break;
                            case XmlNodeType.EndEntity:
                                break;
                            case XmlNodeType.XmlDeclaration:
                                break;
                            default:
                                break;
                        }
                    }
                    // 요일별
                    string[] strtemp = msg.Split('/');

                    //요일별 데이터
                    string[] strtemp1 = strtemp[1].Split(',');
                    label_day1.Text = strtemp1[0];
                    label_low_text1.Text = strtemp1[2] + "℃";
                    label_high_text1.Text = strtemp1[3] + "℃";
                    label_weather_text1.Text = strtemp1[1];                
                    avg1 = (int.Parse(strtemp1[2]) + int.Parse(strtemp1[3])) / 2;
                    Console.WriteLine($"{label_day1.Text} 평균 기온 : " + avg1);                 

                    string[] strtemp2 = strtemp[2].Split(',');
                    label_day2.Text = strtemp2[0];
                    label_low_text2.Text = strtemp2[2] + "℃";
                    label_high_text2.Text = strtemp2[3] + "℃";
                    label_weather_text2.Text = strtemp2[1];
                    avg2 = (int.Parse(strtemp2[2]) + int.Parse(strtemp2[3])) / 2;
                    Console.WriteLine($"{label_day2.Text} 평균 기온 : " + avg2);

                    string[] strtemp3 = strtemp[3].Split(',');
                    label_day3.Text = strtemp3[0];
                    label_low_text3.Text = strtemp3[2] + "℃";
                    label_high_text3.Text = strtemp3[3] + "℃";
                    label_weather_text3.Text = strtemp3[1];
                    avg3 = (int.Parse(strtemp3[2]) + int.Parse(strtemp3[3])) / 2;
                    Console.WriteLine($"{label_day3.Text} 평균 기온 : " + avg3);

                    string[] strtemp4 = strtemp[4].Split(',');
                    label_day4.Text = strtemp4[0];
                    label_low_text4.Text = strtemp4[2] + "℃";
                    label_high_text4.Text = strtemp4[3] + "℃";
                    label_weather_text4.Text = strtemp4[1];
                    avg4 = (int.Parse(strtemp4[2]) + int.Parse(strtemp4[3])) / 2;
                    Console.WriteLine($"{label_day4.Text} 평균 기온 : " + avg4);

                    string[] strtemp5 = strtemp[5].Split(',');
                    label_day5.Text = strtemp5[0];
                    label_low_text5.Text = strtemp5[2] + "℃";
                    label_high_text5.Text = strtemp5[3] + "℃";
                    label_weather_text5.Text = strtemp5[1];
                    avg5 = (int.Parse(strtemp5[2]) + int.Parse(strtemp5[3])) / 2;
                    Console.WriteLine($"{label_day5.Text} 평균 기온 : " + avg5);

                    string[] strtemp6 = strtemp[6].Split(',');
                    label_day6.Text = strtemp6[0];
                    label_low_text6.Text = strtemp6[2] + "℃";
                    label_high_text6.Text = strtemp6[3] + "℃";
                    label_weather_text6.Text = strtemp6[1];
                    avg6 = (int.Parse(strtemp6[2]) + int.Parse(strtemp6[3])) / 2;
                    Console.WriteLine($"{label_day6.Text} 평균 기온 : " + avg6);

                    /*if (panel1.)
                    {
                        choice1(label_day1.Text, avg1);
                    }
                    else if (panel2.Enabled == true)
                    {
                        choice2(label_day2.Text, avg2);
                    }
                    else if (panel3.)
                    {
                        choice3(label_day3.Text, avg3);
                    }
                    else if (panel4)
                    {
                        choice4(label_day4.Text, avg4);
                    }
                    else if (panel5)
                    {
                        choice5(label_day5.Text, avg5);
                    }
                    else if (panel6)
                    {
                        choice6(label_day6.Text, avg6);
                    } */                   

                    //choice1(label_day1.Text, avg1);
                    //choice2(label_day2.Text, avg1);
                    //choice3(label_day3.Text, avg1);
                    //choice4(label_day4.Text, avg1);
                    //choice5(label_day5.Text, avg1);
                    //choice6(label_day6.Text, avg1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);               
                //throw;
            }
        }        

        private void choice1(string day1, int avg1)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day1} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");                
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day1} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day1} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day1} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day1} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day1} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day1} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day1} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day1} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private void choice2(string day2, int avg2)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day2} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day2} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day2} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day2} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day2} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day2} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day2} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day2} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day2} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private void choice3(string day3, int avg3)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day3} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day3} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day3} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day3} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day3} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day3} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day3} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day3} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day3} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private void choice4(string day4, int avg4)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day4} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day4} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day4} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day4} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day4} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day4} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day4} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day4} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day4} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private void choice5(string day5, int avg5)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day5} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day5} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day5} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day5} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day5} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day5} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day5} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day5} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day5} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private void choice6(string day6, int avg6)
        {
            if (avg1 <= 5)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품");
                label_avg.Text = $"{day6} 추천 옷차림 : 패딩, 두꺼운 코트, 목도리, 기모제품";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778529/460x-");
            }
            else if (6 <= avg1 && avg1 <= 9)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스");
                label_avg.Text = $"{day6} 추천 옷차림 : 코트, 가죽자켓, 니트, 레깅스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778370/460x-");
            }
            else if (10 <= avg1 && avg1 <= 11)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹");
                label_avg.Text = $"{day6} 추천 옷차림 : 자켓, 트렌치코트, 야상, 니트, 청바지, 스타킹";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778318/460x-");
            }
            else if (12 <= avg1 && avg1 <= 16)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지");
                label_avg.Text = $"{day6} 추천 옷차림 : 가디건, 자켓, 야상, 스타킹, 청바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778275/460x-");
            }
            else if (17 <= avg1 && avg1 <= 19)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지");
                label_avg.Text = $"{day6} 추천 옷차림 : 맨투맨, 얇은 니트, 가디건, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778153/460x-");
            }
            else if (20 <= avg1 && avg1 <= 22)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지");
                label_avg.Text = $"{day6} 추천 옷차림 : 긴팔, 얇은 가디건, 면바지, 청바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19778003/460x-");
            }
            else if (23 <= avg1 && avg1 <= 26)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지");
                label_avg.Text = $"{day6} 추천 옷차림 : 얇은 셔츠, 반팔, 반바지, 면바지";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777989/460x-");
            }
            else if (27 <= avg1)
            {
                Console.WriteLine($"{day6} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스");
                label_avg.Text = $"{day6} 추천 옷차림 : 반팔, 민소매, 반바지, 원피스";
                pictureBox1.Image = Webimage("https://usercontents-d.styleshare.io/images/19777949/460x-");
            }
        }

        private Bitmap Webimage(string link)
        {
            try
            {
                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(link);
                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
                return DownloadImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                return null;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {

        }
    }
}
