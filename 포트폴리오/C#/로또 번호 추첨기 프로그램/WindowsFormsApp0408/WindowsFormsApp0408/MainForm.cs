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

namespace WindowsFormsApp0408
{
    public partial class MainForm : MetroForm
    {        
        public MainForm()
        {
            InitializeComponent();           
            //button_test.Text = "12시";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.ShowAlways = true;

            toolTip1.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게

            toolTip1.AutoPopDelay = 0;

            toolTip1.InitialDelay = 0;

            toolTip1.ReshowDelay = 500;

            //toolTip1.SetToolTip(linkbutton, "Insert space");

            toolTip1.SetToolTip(linkbutton, "동행복권");
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Hello World"); // 자동완성 : mbox + tab + tab

            Random r = new Random();
            // 0 이상 10미만의 숫자 하나 출력 : Next(10)
            //MessageBox.Show(r.Next(10).ToString()); // MessageBox.Show의 괄호 안에는 string 타입만 들어가기 때문에 변환시킴

            // 1이상 46미만의 숫자 하나 출력 : Next(1,46)
            //MessageBox.Show(r.Next(1,46).ToString());

            int[] lotto = new int[6];            
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto[i] = r.Next(1,46);
                Console.WriteLine(lotto[i]);                              
                for (int j = 0; j < lotto.Length; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        lotto[i] += lotto[j];
                        Console.WriteLine(lotto[j]);
                    }
                    else
                    {
                        j--;
                        break;                                            
                    }                    
                }                
            }            

            *//*label_num1.Text = r.Next(1,46).ToString();
            label_num2.Text = r.Next(1,46).ToString();
            label_num3.Text = r.Next(1,46).ToString();
            label_num4.Text = r.Next(1,46).ToString();
            label_num5.Text = r.Next(1,46).ToString();
            label_num6.Text = r.Next(1,46).ToString();*/
        }

        private void randombutton_Click(object sender, EventArgs e)
        {
            new ViewForm().ShowDialog();
        }              

        private void linkbutton_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.dhlottery.co.kr/common.do?method=main");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("프로그램이 종료됩니다.");
        }
    }
}
