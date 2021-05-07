using System;
using System.Windows.Forms;

namespace BaseballEx
{
    public partial class Form3 : Form
    {
        Form1 parent = null;
        Timer parentTimer = null;
        int[] baseball2 = new int[3];
        public Form3(Form1 parent, int[] baseball2)
        {
            InitializeComponent();
            this.parent = parent;
            this.parentTimer = parent.timer;
            this.baseball2 = baseball2;

        }
        //StreamWriter w = new StreamWriter(@"D:\blacksheep\starloge2020\c#\BaseballEx\a.b");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = $"정답은 {baseball2[0]} {baseball2[1]} {baseball2[2]} 입니다.";
        }


        //     for (int i = 0; i<form1.; i++)
        //{

        //}
    }
}
