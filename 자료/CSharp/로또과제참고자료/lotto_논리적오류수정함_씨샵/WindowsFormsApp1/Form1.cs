using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Random r = new Random(); //C#에서 만들어준 클래스
            //random_num = 1;
            int random_num = r.Next(1, 46); //1이상 46미만의 난수받음
            //lottoNum = "1";
            string lottoNum = random_num.ToString(); //1번째 번호
            if(random_num < 10)
            {
                lottoNum = "0" + random_num.ToString();
            }
            for (int i = 0; i < 6; i++) //2번째~7번째 번호
            {
                //random_num = 45 //중복되지 않는 경우
                //random_num = 1 //중복된 번호 나온 경우

                //중복에 대한 예외처리
                //lottoNum이 "1"인 상태인데 또 1이 나온 경우
                //"1".Contains("1")

                //하지만 이 예외처리에는 허점이 있다.
                //11이 이미 있는데 1이 들어오면, 11에도 1이 포함되어있다.
                //if (lottoNum.Contains(random_num.ToString()))
                //{
                //    i--;
                //    continue;
                //}

                //허점을 보안한 예외처리
                random_num = r.Next(1, 46);
                string temp = random_num.ToString();
                if(random_num<10)
                {
                    temp = "0" + temp;
                }

                if (lottoNum.Contains(temp))
                {
                    i--;
                    continue;
                }


                //중복되지 않은 경우->구분자와 함께 숫자를 추가한다.
                //lottoNum = "01"+"_"+"45" -> "01_45"
                lottoNum += "_" + temp;
            }
            Console.WriteLine(lottoNum);

            //그림 그리기
            //"1_2_3_4_45_16  ->   lotto배열 -> ["1"]["2"]["3"]["4"]["45"]["16"]
            string[] lotto = lottoNum.Split('_');
            Label[] lotto_display = {label_1,label_2,label_3,label_4,label_5,label_6, label_7};
            for (int i = 0; i < lotto.Length; i++)
            {
                lotto_display[i].Text = lotto[i];
            }
        }

        private void label_1_Click(object sender, EventArgs e)
        {

        }
    }
}
