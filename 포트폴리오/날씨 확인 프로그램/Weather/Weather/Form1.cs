using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather
{
    public partial class Form1 : MetroForm
    {
        string url = "http://www.kma.go.kr/weather/forecast/mid-term-xml.jsp";
        string city = "";

        public Form1()
        {
            InitializeComponent();
            comboBox_city.SelectedIndex = 0;            
            label_nowtime.Text = DateTime.Now.ToString("yyyy-MM-dd");
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

                    string[] strtemp2 = strtemp[2].Split(',');
                    label_day2.Text = strtemp2[0];
                    label_low_text2.Text = strtemp2[2] + "℃";
                    label_high_text2.Text = strtemp2[3] + "℃";
                    label_weather_text2.Text = strtemp2[1];

                    string[] strtemp3 = strtemp[3].Split(',');
                    label_day3.Text = strtemp3[0];
                    label_low_text3.Text = strtemp3[2] + "℃";
                    label_high_text3.Text = strtemp3[3] + "℃";
                    label_weather_text3.Text = strtemp3[1];

                    string[] strtemp4 = strtemp[4].Split(',');
                    label_day4.Text = strtemp4[0];
                    label_low_text4.Text = strtemp4[2] + "℃";
                    label_high_text4.Text = strtemp4[3] + "℃";
                    label_weather_text4.Text = strtemp4[1];

                    string[] strtemp5 = strtemp[5].Split(',');
                    label_day5.Text = strtemp5[0];
                    label_low_text5.Text = strtemp5[2] + "℃";
                    label_high_text5.Text = strtemp5[3] + "℃";
                    label_weather_text5.Text = strtemp5[1];

                    string[] strtemp6 = strtemp[6].Split(',');
                    label_day6.Text = strtemp6[0];
                    label_low_text6.Text = strtemp6[2] + "℃";
                    label_high_text6.Text = strtemp6[3] + "℃";
                    label_weather_text6.Text = strtemp6[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }
    }
}
