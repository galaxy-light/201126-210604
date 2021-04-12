using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textmix
{
    public partial class Form1 : Form
    {
        //  list에 임의의 문장들을 만들어 놓고 Random 함수를 이용하여 임의의 문장을 출력하도록 하시오.

        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> tlist = new List<string>();
            tlist.Add("월요일입니다.");
            tlist.Add("화요일입니다.");
            tlist.Add("수요일입니다.");
            tlist.Add("목요일입니다.");
            tlist.Add("금요일입니다.");
            tlist.Add("토요일입니다.");
            tlist.Add("일요일입니다.");

            int rand = r.Next(tlist.Count);
            label1.Text = tlist[rand];
        }
    }
}
