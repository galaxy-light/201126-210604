using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk1220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm");
            all_menu_visible(false);
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
        }

        private void all_menu_visible(bool isVisible)
        {
            if(isVisible) //visible을 true로 설정할건데...
            {
                if (hansik1.Visible && junsik1.Visible && yangsik1.Visible && lisik1.Visible && boonsik1.Visible) //이미 보이고 있다면 생략
                    return;
            }

            hansik1.Visible = isVisible;
            junsik1.Visible = isVisible;
            yangsik1.Visible = isVisible;
            lisik1.Visible = isVisible;
            boonsik1.Visible = isVisible;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            all_menu_visible(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            all_menu_visible(true);
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            hansik1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            all_menu_visible(true);

            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            junsik1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            all_menu_visible(true);

            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            yangsik1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            all_menu_visible(true);
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            lisik1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            all_menu_visible(true);

            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            boonsik1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm");
        }
    }
}
