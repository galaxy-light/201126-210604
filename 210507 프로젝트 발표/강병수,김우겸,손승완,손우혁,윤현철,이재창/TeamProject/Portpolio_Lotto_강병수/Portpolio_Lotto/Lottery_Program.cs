using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portpolio_Lotto
{
    public partial class Lottery_Program : Form
    {
        public Lottery_Program()
        {
            InitializeComponent();
        }
        // 지난 회차 당첨 번호, 이번 회차 예상 번호 배열 초기화 및 랜덤 클래스 생성
        int[] previous = new int[6];
        Random r = new Random();
        int[] Week = new int[6];

        // 이전 회차 당첨 번호 저장
        private void Prev_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //번호 입력칸에 빈 칸이 존재하는 경우
                if (Prev_Num1.Text == "" || Prev_Num2.Text == "" || Prev_Num3.Text == "" 
                    || Prev_Num4.Text == "" || Prev_Num5.Text == "" || Prev_Num6.Text == "")
                {
                    MessageBox.Show("입력하지 않은 번호가 존재합니다.", "오류: 입력한 번호가 존재하지않음", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                previous[0] = Convert.ToInt32(Prev_Num1.Text);
                previous[1] = Convert.ToInt32(Prev_Num2.Text);
                previous[2] = Convert.ToInt32(Prev_Num3.Text);
                previous[3] = Convert.ToInt32(Prev_Num4.Text);
                previous[4] = Convert.ToInt32(Prev_Num5.Text);
                previous[5] = Convert.ToInt32(Prev_Num6.Text);

                // 부적절한 번호가 존재하는 경우

                if (previous[0] > 45 || previous[0] <= 0 ||
                        previous[1] > 45 || previous[1] <= 0 ||
                        previous[2] > 45 || previous[2] <= 0 ||
                        previous[3] > 45 || previous[3] <= 0 ||
                        previous[4] > 45 || previous[4] <= 0 ||
                        previous[5] > 45 || previous[5] <= 0)
                {
                    MessageBox.Show("번호를 잘못 입력하였습니다.", "오류: 잘못 입력된 번호가 존재함", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    previous = Enumerable.Repeat(0, 6).ToArray();
                    return;
                }

                // 번호를 중복해서 입력하였을 경우
                for (int i = 0; i < previous.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (previous[i] == previous[j])
                        {
                            MessageBox.Show("중복되는 번호가 존재합니다.", "오류: 번호 중복", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            previous = Enumerable.Repeat(0, 6).ToArray();
                            return;
                        }
                    }
                }

                if (Prev_Num1.Text != "" && Prev_Num2.Text != "" && Prev_Num3.Text != "" 
                    && Prev_Num4.Text != "" && Prev_Num5.Text != "" && Prev_Num6.Text != "")
                {

                    // 우선 배열에 이전 회차 당첨 번호 저장
                    previous[0] = Convert.ToInt32(Prev_Num1.Text);
                    previous[1] = Convert.ToInt32(Prev_Num2.Text);
                    previous[2] = Convert.ToInt32(Prev_Num3.Text);
                    previous[3] = Convert.ToInt32(Prev_Num4.Text);
                    previous[4] = Convert.ToInt32(Prev_Num5.Text);
                    previous[5] = Convert.ToInt32(Prev_Num6.Text);


                    // 배열 오름차순 정렬
                    Array.Sort(previous);
                    MessageBox.Show("이전 회차 번호가 저장되었습니다.");
                }
            }
            // 문자 입력하였을 때 오류 발생창 뜨도록
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생하였습니다: " + "숫자가 아닌 문자를 입력하였습니다.", "오류: 문자 입력", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Week_Number_Click(object sender, EventArgs e)
        {
            // 이전 회차 번호 저장을 안했을 때 오류 뜨게
            if (previous[0] == 0 || previous[1] == 0 || previous[2] == 0 ||
                previous[3] == 0 || previous[4] == 0 || previous[5] == 0)
            {
                MessageBox.Show("이전 회차의 번호가 저장되지 않았습니다.", "오류: 이전 회차 번호 입력", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else // 예상 번호 버튼 누르면 돌아가는 알고리즘(이전 회차 번호와 중복이 되지않게)
            {   Reroll:
                for (int j = 0; j < Week.Length; j++)
                {
                    Week[j] = r.Next(1, 46);
                    for (int k = 0; k < j; k++)
                    {
                        if (Week[j] == Week[k])
                        {
                            j--;
                            break;
                        }
                    }
                }

                // 번호가 일단 만들어졌으니 정렬 후 이전 회차와 중복되는 번호가 있는지 확인
                Array.Sort(Week);
                for (int i = 0; i<Week.Length; i++)
                {
                    for(int j = 0; j<Week.Length; j++)
                    {
                        if(previous[i] == Week[j])
                        {
                            goto Reroll;
                        }
                    }
                }
            }

            // 번호 완성
            MessageBox.Show("★☆당첨 번호☆★" + "\n" + "첫번째 번호: " + Week[0] + "\n" + "두번째 번호: " + Week[1] + "\n" +
                    "세번째 번호: " + Week[2] + "\n" + "네번째 번호: " + Week[3] + "\n" + "다섯번째 번호: " + Week[4] + "\n" +
                    "여섯번쨰 번호: " + Week[5]);
        }
    }
}
