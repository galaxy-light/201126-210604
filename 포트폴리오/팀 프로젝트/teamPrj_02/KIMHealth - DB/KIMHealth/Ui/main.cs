using KIMHealth.DB;
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

            this.enterButton.BackColor = System.Drawing.Color.SteelBlue;
            this.enterButton.ForeColor = Color.White;
            this.outButton.BackColor = System.Drawing.Color.SteelBlue;
            this.outButton.ForeColor = Color.White;
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
            MessageBox.Show(textBox_id.Text + "님 오늘도 수고하셨습니다!");
            textBox_id.Text = "";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_id.Text + "님 오늘도 열심히 하세요!");
            textBox_id.Text = "";
        }

        private void btn_click()
        {            
            int[] numarr = new int[100];
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.LightSkyBlue;
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.SteelBlue;
        }

        private void outButton_MouseEnter(object sender, EventArgs e)
        {
            outButton.BackColor = Color.LightSkyBlue;
        }

        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            outButton.BackColor = Color.SteelBlue;
        }

        
    }
}
