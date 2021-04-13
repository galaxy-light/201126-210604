using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_test_1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmconv(textBox_test_1.Text));
            label_test_1.Text = cmconv(textBox_test_1.Text) + "cm";
        }

        // 문제1
        private string cmconv(string inputnum1)
        {
            return "" + int.Parse(textBox_test_1.Text) * 2.54;
        }

        private void button_test_2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pouconv(textBox_test_2.Text));
            label_test_2.Text = pouconv(textBox_test_2.Text) + "pound";
        }

        // 문제2
        private string pouconv(string inputnum2)
        {
            return "" + int.Parse(textBox_test_2.Text) * 2.20462262;
        }

        private void button_test_3_Click(object sender, EventArgs e)
        {
            label_test_3.Text = cirg(textBox_test_3.Text);
            label_test_4.Text = cira(textBox_test_3.Text);
        }

        // 문제3
        private string cirg(string inputnum3)
        {
            double pi = 3.14;
            double cirgirth = 2 * pi * int.Parse(textBox_test_3.Text); // 둘레            
            return "" + cirgirth;            
        }

        private string cira(string inputnum3)
        {
            double pi = 3.14;
            double area = pi * int.Parse(textBox_test_3.Text) * int.Parse(textBox_test_3.Text); // 넓이
            return "" + area;
        }
    }
}
