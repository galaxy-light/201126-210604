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
using WindowsFormsApp0409;

namespace WindowsFormsApp0408
{
    public partial class ViewForm : MetroForm
    {
        Random r = new Random();

        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {

        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            /*int rand;
            int[] lotto = new int[7];
            for (int i = 0; i < lotto.Length; i++)
            {
                rand = r.Next(1, 46);
                lotto[i] = rand;
                Console.WriteLine(lotto[i]);
                // 중복 제거
                for (int j = 0; j < i; j++)
                {
                    if (lotto[i] == lotto[j])
                    {
                        i--;
                        break;
                    }
                }
            }
            // 텍스트박스에 넣기
            for (int i = 0; i < lotto.Length; i++)
            {
                NumBox_1.Text = lotto[0].ToString();
                NumBox_2.Text = lotto[1].ToString();
                NumBox_3.Text = lotto[2].ToString();
                NumBox_4.Text = lotto[3].ToString();
                NumBox_5.Text = lotto[4].ToString();
                NumBox_6.Text = lotto[5].ToString();
                NumBox_7.Text = lotto[6].ToString();
            }*/

            randctrl();
        }

        private void randctrl()
        {
            /*int[] rct = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            14, 15 ,16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };*/

            /*var rctl = new Random();
            var rcbool = rctl.Next(1, 46) < 50.0;
            Console.WriteLine(rcbool);*/

            int rand;
            int sum = 0;            
            int[] lotto = new int[7];
            for (int i = 0; i < lotto.Length; i++)
            {
                rand = r.Next(1, 46);
                lotto[i] = rand; // 배열에 랜덤값 넣기
                //Console.WriteLine(lotto[i]);
                sum += lotto[i];
                for (int j = 0; j < i; j++)
                {
                    // 중복 처리
                    if (lotto[i] == lotto[j])
                    {
                        i--;
                        sum -= lotto[i];
                    }
                    // 확률1
                    // 첫번째 자리는 1 ~ 34
                    if (lotto[0] > 34)
                    {
                        i = -1;
                        sum = 0;                        
                        Console.WriteLine("첫번째 : " + lotto[0]);
                        break;
                    }
                    // 두번째 자리는 2 ~ 36
                    if ((lotto[1] < 2) || (lotto[1] > 36))
                    {
                        i = 0;
                        sum = 0;
                        Console.WriteLine("두번째 : " + lotto[1]);
                        break;
                    }
                    // 세번째 자리는 3 ~ 39
                    if ((lotto[2] < 3) || (lotto[2] > 39))
                    {
                        i = 1;
                        sum = 0;
                        Console.WriteLine("세번째 : " + lotto[2]);
                        break;
                    }
                    if ((lotto[3] < 4) || (lotto[3] > 41))
                    {
                        i = 2;
                        sum = 0;
                        Console.WriteLine("네번째 : " + lotto[3]);
                        break;
                    }
                    if ((lotto[4] < 5) || (lotto[2] > 42))
                    {
                        i = 3;
                        sum = 0;
                        Console.WriteLine("다섯번째 : " + lotto[4]);
                        break;
                    }
                    if ((lotto[5] < 3) || (lotto[5] > 43))
                    {
                        i = 4;
                        sum = 0;
                        Console.WriteLine("여섯번째 : " + lotto[5]);
                        break;
                    }
                    if ((lotto[6] < 3) || (lotto[6] > 46))
                    {
                        i = 5;
                        sum = 0;
                        Console.WriteLine("보너스 : " + lotto[6]);
                        break;
                    }
                    // 확률2 : 전체의 합이 48보다 작거나 238보다 큰 당첨번호는 없었음
                    if (i == 6 && sum < 48)
                    {
                        i = -1;
                        sum = 0;
                        break;
                    }
                    if (sum > 238)
                    {
                        i = -1;
                        sum = 0;
                        break;
                    }                    
                }
            }

            for (int i = 0; i < lotto.Length; i++)
            {
                NumBox_1.Text = lotto[0].ToString();
                NumBox_2.Text = lotto[1].ToString();
                NumBox_3.Text = lotto[2].ToString();
                NumBox_4.Text = lotto[3].ToString();
                NumBox_5.Text = lotto[4].ToString();
                NumBox_6.Text = lotto[5].ToString();
                NumBox_7.Text = lotto[6].ToString();
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            new ListForm().ShowDialog();
        }
    }
}
