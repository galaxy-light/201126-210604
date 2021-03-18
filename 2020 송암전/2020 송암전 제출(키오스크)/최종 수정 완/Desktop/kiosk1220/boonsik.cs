using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk1220
{
    public partial class boonsik : UserControl
    {
        public boonsik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boonsik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Text = $"{5000*numericUpDown1.Value}원";
            if (numericUpDown1.Value == 0)
                button4.Visible = false;
            else
                button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Text = $"{5000 * numericUpDown2.Value}원";
            if (numericUpDown2.Value == 0)
                button6.Visible = false;
            else
                button6.Visible = true;
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            button3.Text = $"{2000 * numericUpDown1.Value}원";
            if (numericUpDown1.Value == 0)
                button2.Visible = false;
            else
                button2.Visible = true;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            button5.Text = $"{6000 * numericUpDown3.Value}원";
            if (numericUpDown3.Value == 0)
                button4.Visible = false;
            else
                button4.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("식권이 발급되었습니다.", "확인");
        }
    }
}
