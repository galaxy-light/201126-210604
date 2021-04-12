using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberCheck
{
    public partial class Form1 : Form
    {
        // Random 함수를 이용하여 숫자 맞추기 프로그램을 Form 형태로 만들어보시오.

        Random r = new Random();
        int[] numc = new int[10];       

        public Form1()
        {
            InitializeComponent();
        }

        int mix = 0;
        private void check_button_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < numc.Length; i++)
            {
                mix = r.Next(1, 11);
                numc[i] = mix;               
                Console.WriteLine(numc[i]);

                /*if (textBox.Text == numc[i].ToString())
                {
                    Console.WriteLine("정답입니다.");
                    MessageBox.Show("정답");
                    break;
                }*/
                /*else if (textBox.Text != numc[i].ToString())
                {
                    Console.WriteLine("정답이 아닙니다.");
                    MessageBox.Show("오답");
                    break;
                }*/
                if (Convert.ToInt32(textBox.Text) == Convert.ToInt32(numc[i].ToString()))
                {
                    Console.WriteLine("정답입니다.");
                    MessageBox.Show("정답");
                    break;
                }
                else if (Convert.ToInt32(textBox.Text) > Convert.ToInt32(numc[i].ToString()))
                {
                    Console.WriteLine("입력값이 정답보다 큽니다.");
                    MessageBox.Show("입력값이 정답보다 큽니다.");
                    break;
                }
                else if (Convert.ToInt32(textBox.Text) < Convert.ToInt32(numc[i].ToString()))
                {
                    Console.WriteLine("입력값이 정답보다 작습니다.");
                    MessageBox.Show("입력값이 정답보다 작습니다.");
                    break;
                }
            }                    
        }
    }
}
