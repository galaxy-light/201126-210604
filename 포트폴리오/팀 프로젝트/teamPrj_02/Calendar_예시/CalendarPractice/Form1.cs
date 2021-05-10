using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarPractice
{
    public partial class Form1 : Form
    {
        DateTime nowTime = DateTime.Now;
        public SqlConnection conn = new SqlConnection();
        Label[] labelDay;
        int nowMonth;
        public Form1()
        {
            InitializeComponent();
            labelDay = new Label[] {
                label1, label2, label3, label4, label5, label6, label7, label8, label9, label10,
                label11, label12, label13, label14, label15, label16, label17, label18, label19, label20,
                label21, label22, label23, label24, label25, label26, label27, label28, label29, label30,
                label31, label32, label33, label34, label35, label36, label37, label38, label39, label40,
                label41, label42
            };
            foreach (var item in labelDay)
            {
                item.Text = null;
            }
            nowMonth = Convert.ToInt32(nowTime.Month);
            setCalendar();
        }



        private void setCalendar()
        {
            if (nowMonth == 0)
                nowMonth = 12;
            else if (nowMonth == 13)
                nowMonth = 1;
            switch (nowMonth)
            {
                case 1:
                case 10:
                    set31Days(6);
                    break;
                case 2:
                    set28Days(2);
                    break;
                case 3:
                    set31Days(2);
                    break;
                case 11:
                    set30Days(2);
                    break;
                case 4:
                    set30Days(5);
                    break;
                case 7:
                    set31Days(5);
                    break;
                case 5:
                    set31Days(7);
                    break;
                case 6:
                    set30Days(3);
                    break;
                case 8:
                    set31Days(1);
                    break;
                case 9:
                    set30Days(4);
                    break;
                case 12:
                    set31Days(4);
                    break;
            }
            
            foreach (var item in labelDay)
            {
                if (item.Text != "")
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.Transparent;
                }
                if (item.Text == nowTime.Day.ToString() && nowMonth == DateTime.Now.Month)
                {
                    item.BackColor = Color.DarkSeaGreen;
                }
            }
            Month.Text = nowMonth + "월";
        }

        private void set30Days(int startDay)
        {
            for (int i = 0; i < labelDay.Length; i++)
            {
                if (Convert.ToInt32(labelDay[i].Tag) >= startDay && Convert.ToInt32(labelDay[i].Tag) <= startDay+29)
                {
                    labelDay[i].Text = (i - (startDay-2)).ToString();
                }
            }
        }

        private void set31Days(int startDay)
        {
            for (int i = 0; i < labelDay.Length; i++)
            {
                if (Convert.ToInt32(labelDay[i].Tag) >= startDay && Convert.ToInt32(labelDay[i].Tag) <= startDay + 30)
                {
                    labelDay[i].Text = (i - (startDay - 2)).ToString();
                }
            }
        }

        private void set28Days(int startDay)
        {
            for (int i = 0; i < labelDay.Length; i++)
            {
                if (Convert.ToInt32(labelDay[i].Tag) >= startDay && Convert.ToInt32(labelDay[i].Tag) <= startDay + 27)
                {
                    labelDay[i].Text = (i - (startDay - 2)).ToString();
                }
            }
        }

        private void BeforeBtn_Click(object sender, EventArgs e)
        {
            nowMonth -= 1;
            foreach (var item in labelDay)
            {
                item.Text = null;
            }
            setCalendar();
        }

        private void afterBtn_Click(object sender, EventArgs e)
        {
            nowMonth += 1;
            foreach (var item in labelDay)
            {
                item.Text = null;
            }
            setCalendar();
        }
    }
}