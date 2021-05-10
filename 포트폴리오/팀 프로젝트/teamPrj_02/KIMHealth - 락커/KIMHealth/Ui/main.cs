using KIMHealth.Model;
using KIMHealth.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMHealth
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            textBox_id.Text = "";
        }

        private void bnt_number_Click(object sender, EventArgs e)
        {
            Sunny.UI.UIButton btn;
            btn = (Sunny.UI.UIButton)sender;
            this.textBox_id.Text += btn.Text;
        }

        private void manage_Click(object sender, EventArgs e)
        {
            manage_member mm = new manage_member();
            mm.ShowDialog();            
        }

        private void add_change_Click(object sender, EventArgs e)
        {
            add_change ac = new add_change();
            ac.ShowDialog();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕히가세염");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("님 하이");
        }

        private void btn_click()
        {            
            int[] numarr = new int[100];
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            new LockerForm().ShowDialog();
        }
    }
}
