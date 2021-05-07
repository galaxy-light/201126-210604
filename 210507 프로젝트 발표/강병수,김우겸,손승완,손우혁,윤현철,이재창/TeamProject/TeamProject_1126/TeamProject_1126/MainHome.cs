using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeamProject_1126
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/강병수/Portpolio_Lotto.exe"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/손승완/Game.exe"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/윤현철/BaseballEx.exe"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/김우겸/Managing_Car_Program.exe"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/이재창/UPbitMonitoring.exe"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath("App/손우혁/Seal.exe"));
        }
    }
}
