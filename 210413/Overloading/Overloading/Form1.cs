using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            black();
        }

        // 오버로딩 : 매개변수의 개수와 타입이 다르다면 같은 이름의 함수 사용 가능
        private void black()
        {
            MessageBox.Show("홍길동");
        }
       
        private void black(string name)
        {
            MessageBox.Show(name);
        }

        private void black(string name, string name2)
        {
            MessageBox.Show(name + name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            black(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            black(button2.Text, button1.Text);
        }
    }
}
