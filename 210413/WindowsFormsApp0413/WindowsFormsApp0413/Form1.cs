using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0413
{
    // enum : 열거형
    // enum의 각 요소는 별도의 지정없이는 첫번째 요소가 0, 두번째 요소가 1, 세번째 요소가 2 등과 같이 1씩 증가된 값들을 할당받음
    enum Scissors_Rock_Paper
    { 
        Gawi, Bawi, BO
    }
    enum Fruit
    {
        //Banana, Kiwi, Apple, Grape
        Banana, Kiwi, Apple=3, Grape
        // 한글도 가능하지만 관례적으로는 사용X
    }

    public partial class Form1 : Form
    {
        int answer = 0;

        List<string> numlist = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Random r = new Random();

            // enum
            string[] product = { "바나나", "키위", "고구마", "감자", "사과", "포도" };
            MessageBox.Show(product[0]); // 바나나 출력
            MessageBox.Show(product[(int)Fruit.Banana]); // 바나나 출력
            MessageBox.Show(Fruit.Banana.ToString()); // Banana 출력
            // enum(열거형)은 숫자로 변환 가능하며 숫자 비교가 가능함
            if ((Fruit)0 == Fruit.Banana)
            {
                MessageBox.Show("숫자 0은 Bananam, Banana는 0");
            }

            // 문제1
            answer = r.Next(10) + 1; // 0 ~ 10   

            // 문제2
            button_F.Text = "가위";
            button_P.Text = "바위";
            button_S.Text = "보";

            // 문제4           
            label_textnum.AutoSize = true;
        }

        // 문제1
        private void test_button1_Click(object sender, EventArgs e)
        {
            int mychoice1 = int.Parse(A_Box1.Text);
            if (mychoice1 == answer)
            {
                //MessageBox.Show("정답!");
                label_result_1.Text = "정답!";
                answer = new Random().Next(10) + 1; // answer 초기화
                //return; // return;이 없다면 if를 끝내지 않고 31라인에서 answer에 새로운 값이 들어오고 밑의 if문으로 내려감
            }
            // return;을 안쓰려면 else 쓰면 됨
            else
            {
                if (mychoice1 < answer)
                {
                    label_result_1.Text = "정답보다 작다.";
                }
                if (mychoice1 > answer)
                {
                    label_result_1.Text = "정답보다 크다.";
                }
            }
            //MessageBox.Show("정답 : " + answer);
        }

        // 문제2
        private void button_F_Click(object sender, EventArgs e)
        {
            int mychoice2 = 0; // 0 = 가위
            int pcchoice = new Random().Next(3);
            textBox_myresult.Text = "가위";
            if (pcchoice == 0)
            {
                textBox_compresult.Text = "가위";
                label_result_2.Text = "비겼음";
            }
            else if (pcchoice == 1)
            {
                textBox_compresult.Text = "바위";
                label_result_2.Text = "졌음";
            }
            else
            {
                textBox_compresult.Text = "보";
                label_result_2.Text = "이겼음";
            }
        }

        private void button_P_Click(object sender, EventArgs e)
        {            
            Scissors_Rock_Paper mychoice2 = Scissors_Rock_Paper.Bawi;
            Scissors_Rock_Paper pcchoice = (Scissors_Rock_Paper)new Random().Next(3); // 형변환(숫자 -> 문자열)

            textBox_myresult.Text = mychoice2.ToString();
            textBox_compresult.Text = pcchoice.ToString();

            if (mychoice2 == pcchoice) // 바위
            {
                label_result_2.Text = "비겼음";
            }
            else if (pcchoice == Scissors_Rock_Paper.BO) // 보
            {
                label_result_2.Text = "졌음";
            }
            else // 가위
            {
                label_result_2.Text = "이겼음";
            }
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            string[] GBB = { "가위", "바위", "보" };
            Scissors_Rock_Paper mychoice2 = Scissors_Rock_Paper.BO;
            Scissors_Rock_Paper pcchoice = (Scissors_Rock_Paper)new Random().Next(3);
            textBox_myresult.Text = GBB[(int)mychoice2];
            textBox_compresult.Text = GBB[(int)pcchoice];
            if (mychoice2 == pcchoice) // 보
            {
                label_result_2.Text = "비겼음";
            }
            else if (pcchoice == Scissors_Rock_Paper.Gawi) // 가위
            {
                label_result_2.Text = "졌음";
            }
            else // 바위
            {
                label_result_2.Text = "이겼음";
            }
        }

        // 문제3
        private void button_okay_Click(object sender, EventArgs e)
        {
            List<string> textlist = new List<string>();
            textlist.Add("안녕");
            textlist.Add("헬로우");
            textlist.Add("올라");
            textlist.Add("봉쥬르");
            textlist.Add("쿠텐탁");

            label_result_3.Text = ""; // 없어도 되는데 초기화해주기 위해 사용
            label_result_3.Text = textlist[new Random().Next(textlist.Count)];
        }

        private void button_add_12_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Add(button_add_12.Text);                        
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";   
            }
        }

        private void button_add_44_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Add(button_add_44.Text);            
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_add_27_Click(object sender, EventArgs e)
        {            
            label_textnum.Text = "";
            numlist.Add(button_add_27.Text);            
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_add_16_Click(object sender, EventArgs e)
        {           
            label_textnum.Text = "";
            numlist.Add(button_add_16.Text);           
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_del_12_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Remove(button_add_12.Text);
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_del_44_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Remove(button_add_44.Text);
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_del_27_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Remove(button_add_27.Text);
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }

        private void button_del_16_Click(object sender, EventArgs e)
        {
            label_textnum.Text = "";
            numlist.Remove(button_add_16.Text);
            foreach (var item in numlist)
            {
                label_textnum.Text += item + " ";
            }
        }
    }
}
