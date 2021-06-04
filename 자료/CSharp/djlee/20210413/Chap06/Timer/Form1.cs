using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = "프로그램 시작한 지 " + time + "초 입니다.";
        }
    }
}
