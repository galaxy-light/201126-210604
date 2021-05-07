using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaseballEx
{
    public partial class Form4 : Form
    {
        List<Rank> rankList = new List<Rank>();
        Form1 parent = null;
        Timer parentTimer = null;

        public Form4(Form1 parent)
        {
            InitializeComponent();

            this.parent = parent;
            rankList = parent.rankList;
            parentTimer = parent.timer;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 0; i < rankList.Count(); i++)
            {
                listBox1.Items.Add(rankList[i].Rank1);
            }
            if (listBox1.SelectedItems.Count != 0)
            {
                while (listBox1.SelectedIndex == 10)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
