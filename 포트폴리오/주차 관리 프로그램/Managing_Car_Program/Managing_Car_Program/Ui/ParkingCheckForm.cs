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
    public partial class ParkingCheckForm : MaterialForm
    {
        private DateTime parkingin;
        private DateTime parkingout;

        public ParkingCheckForm()
        {
            InitializeComponent();          
        }

        private void ParkingCheckForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }                      

        private void button_in_Click_1(object sender, EventArgs e)
        {
            parkingin = DateTime.Now;
            label_in_time.Text = parkingin.ToString("HH:mm:ss");
        }

        private void button_out_Click1(object sender, EventArgs e)
        {
            parkingout = DateTime.Now.AddMinutes(1);
            label_out_time.Text = parkingout.ToString("HH:mm:ss");

            // 계산법 = (주차시간/단위시간)*요금
            //TimeSpan ts = parkingout - parkingin;
            label_result.Text = calctime(parkingout - parkingin) + "원";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_now_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private string calctime(TimeSpan ts)
        {
            return ((Convert.ToInt32(ts.Minutes / Convert.ToInt32(label_time.Text)))
                * Convert.ToInt32(label_money.Text)).ToString();             
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }    
}
