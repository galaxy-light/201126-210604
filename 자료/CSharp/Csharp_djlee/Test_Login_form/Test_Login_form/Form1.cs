using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string message = "Hello World";

            //1
            string one = "stsing" + 123 + "   " + 456;
            //2
            //string two = string.Format()
            //System.out.printf("%d"~~~)

            string message = $"{textBox1.Text}, {textBox2.Text}";

            int a = 123;
            int b = 456;

            string ex = $"첫 번째 숫자는 {a}이고, " +
                $"두 번째 숫자는 {b}이다.";
            string ex2 = "첫 번째 숫자는" + a +" 이고, " +
                $"두 번째 숫자는 "+ b +"이다.";


            MessageBox.Show(message);
        }
    }

}
