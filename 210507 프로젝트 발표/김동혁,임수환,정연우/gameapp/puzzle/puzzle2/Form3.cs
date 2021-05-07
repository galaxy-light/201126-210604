using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle2
{
    
    public partial class Form3 : Form
    {
     private   int Counter;
        
       

        public Form3(int Counter)
        { 
            InitializeComponent();
            this.Counter = Counter;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("이름이 뭐니");
                return;
            }
            Counter = Counter + 1;
            Ranking temp = new Ranking();
            temp.Name = textBox1.Text;
            temp.Score = Counter-1;
            temp.Rank = int.MaxValue;
            data.rankings.Add(temp);
            //MessageBox.Show(this.score.ToString());
            data.rankings.Reverse();
            for (int i = 0; i < data.rankings.Count; i++)
            {
                data.rankings[i].Rank = (i + 1);
            }

            data.Save();
            Dispose();
        }
        }
    
}