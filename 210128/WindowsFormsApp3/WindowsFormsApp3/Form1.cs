using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = textBox1.Text;
            if (str.Trim().Length > 0) { // Trim : 공백을 제거해주는 함수
                MessageBox.Show(str);
            }
            /*if (0 < str.Length)
            {
                MessageBox.Show(str);
            }
            else {
                MessageBox.Show(str);
            }
            if (str.Length < 1) {
                MessageBox.Show(str);
            }
            if (!(1 < str.Length)) {
                MessageBox.Show(str);
            }*/

        }

    }
}
