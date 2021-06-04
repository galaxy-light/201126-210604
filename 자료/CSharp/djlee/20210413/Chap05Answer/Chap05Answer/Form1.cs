using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap05Answer
{
    public partial class Form1 : Form
    {
        int answer = 0;
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            answer = r.Next(10) + 1;
            Console.WriteLine("정답:"+answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myChoice = int.Parse(textBox1.Text);
            if(myChoice == answer)
            {
                MessageBox.Show("정답~!");
                answer = new Random().Next(10) + 1;
                Console.WriteLine("정답:" + answer);
            }
            else
            {
                if (myChoice < answer)
                {
                    MessageBox.Show("정답보다 작다");
                }
                if (myChoice > answer)
                {
                    MessageBox.Show("정답보다 크다");
                }
            }
        }
    }
}
