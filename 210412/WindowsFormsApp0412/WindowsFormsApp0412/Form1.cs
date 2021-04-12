using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0412
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int[] str = new int[6];
            
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = r.Next(1, 46);
            }

            for (int i = 0; i < str.Length; i++)
            {
                label1.Text = str[0].ToString();
                label2.Text = str[1].ToString();
                label3.Text = str[2].ToString();
                label4.Text = str[3].ToString();
                label5.Text = str[4].ToString();
                label6.Text = str[5].ToString();
            }

            // 숫자 순서 정렬 방법1
            //Array.Sort(str);

            // 숫자 순서 정렬 방법2(버블 정렬)
            int temp = 0;
            for (int i = 0; i < str.Length; i++) // 배열의 길이만큼 반복
            {
                for (int j = 0; j < str.Length-1; j++) // 배열의 길이에서 하나 뺀만큼만 반복(마지막 자리가 없기 때문)
                {
                    if (str[j]>str[j+1]) // 첫번째 자리[0]와 그 옆자리[1] 비교해서 앞자리가 크다면
                    {
                        temp = str[j]; // temp에 str[0]을 저장
                        str[j] = str[j + 1]; // str[0] = str[0 + 1];
                        str[j + 1] = temp; // str[0 + 1] = temp
                    }                    
                }
            }
        }
    }
}
