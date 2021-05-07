using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Who : Form
    {
        private int score = 0;
        public Who(int score)
        {
            InitializeComponent();
            this.score = score;
        }

        private void Who_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("이름이 뭐니");
                return;
            }
            Ranking1 temp = new Ranking1();
            temp.Name = textBox1.Text;
            temp.Score = this.score;
            temp.Rank = int.MaxValue;
            data.rankings.Add(temp);
            //MessageBox.Show(this.score.ToString());
            data.rankings.Sort();
            for (int i = 0; i < data.rankings.Count; i++)
            {
                data.rankings[i].Rank = (i + 1);
            }

            data.Save();
            Dispose();
        }
    }
}
