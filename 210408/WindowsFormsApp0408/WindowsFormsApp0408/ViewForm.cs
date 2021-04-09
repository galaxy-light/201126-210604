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

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            int rand;
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
            }
        }

        private void randctrl()
        {
            /*int[] rct = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            14, 15 ,16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45 };*/            
        }
    }
}
