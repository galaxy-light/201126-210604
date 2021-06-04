using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap05Answer2
{
    enum Scissors_Rock_Paper
    {
        Gawi, Bawi, Bo
    }
    enum Fruit
    {
        Banana,Kiwi,Apple=3,ddalgi
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] product = {"바나나","키위",
                                "고구마","감자",
                                "사과","딸기"};
            MessageBox.Show(product[0]);
            MessageBox.Show(product[(int)Fruit.Banana]);
            MessageBox.Show(Fruit.Banana.ToString());
            if((Fruit)0 == Fruit.Banana)
                MessageBox.Show("숫자 0은 Banana, Banana는 0");


            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myChoice = 0; //0=가위, 1=바위, 2=보 라고 약속
            int pcChoice = new Random().Next(3);
            label_myResult.Text = "가위";
            if(pcChoice == 0)
            {
                label_pcResult.Text = "가위";
                label_result.Text = "비김";
            }
            else if(pcChoice ==1)
            {
                label_pcResult.Text = "바위";
                label_result.Text = "짐";
            }
            else
            {
                label_pcResult.Text = "보";
                label_result.Text = "이김";
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scissors_Rock_Paper mychoice = Scissors_Rock_Paper.Bawi;
            Scissors_Rock_Paper pcChoice = 
                (Scissors_Rock_Paper)new Random().Next(3);

            label_myResult.Text = mychoice.ToString();
            label_pcResult.Text = pcChoice.ToString();

            if(mychoice==pcChoice) //바위
            {
                label_result.Text = "비김";
            }
            else if(pcChoice == Scissors_Rock_Paper.Bo) //보
            {
                label_result.Text = "짐";
            }
            else //가위
            {
                label_result.Text = "이김";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] GBB = { "가위", "바위", "보" };
            Scissors_Rock_Paper mychoice = 
                Scissors_Rock_Paper.Bo;

            Scissors_Rock_Paper pcChoice = 
                (Scissors_Rock_Paper)new Random().Next(3);

            label_myResult.Text = GBB[(int)mychoice];
            label_pcResult.Text = GBB[(int)pcChoice];

            if(mychoice == pcChoice) //보
            {
                label_result.Text = "비김";
            }
            else if (pcChoice == Scissors_Rock_Paper.Gawi)//가위
            {
                label_result.Text = "짐";
            }
            else //바위
            {
                label_result.Text = "이김";
            }

        }
    }
}
