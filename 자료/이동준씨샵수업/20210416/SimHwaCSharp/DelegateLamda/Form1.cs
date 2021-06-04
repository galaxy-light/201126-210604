using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();
        public Form1()
        {
            InitializeComponent();

            Button button2 = new Button();
            button2.Text = "코드로 만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(100, 100);
            button2.Click += Button2_Click;
            button2.Click += Button2_Click_222;
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Test delegate");
            };
            button2.Click +=
                (object sender, EventArgs e) => { MessageBox.Show("lamda"); };
            Controls.Add(button2);
        }

        private void Button2_Click_222(object sender, EventArgs e)
        {
            MessageBox.Show("Test2222222");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello;
            TestDelegate b = delegate () 
                { MessageBox.Show("안녕 난 민이라고 해"); };
            TestDelegate c = () => { MessageBox.Show("안녕 난 민이라고 해"); };

            a();
            b();
            c();
            exCallBack(a);
        }
        private void Hello()
        {
            MessageBox.Show("안녕 난 민이라고 해");
        }
        private void exCallBack(TestDelegate t)
        {
            for (int i = 0; i < 3; i++)
            {
                t();
            }
        }
    }
}
