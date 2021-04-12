using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liststr
{
    public partial class Form1 : Form
    {
        List<string> nlist = new List<string>();        

        public Form1()
        {
            InitializeComponent();

            nlist.Add(button_add_12.Text);
            nlist.Add(button_add_44.Text);
            nlist.Add(button_add_27.Text);
            nlist.Add(button_add_16.Text);

            nlist.Remove(button_del_12.Text);
            nlist.Remove(button_del_44.Text);
            nlist.Remove(button_del_27.Text);
            nlist.Remove(button_del_16.Text);
        }

        private void button_add_12_Click(object sender, EventArgs e)
        {
            foreach (var item in nlist)
            {
                if (button_add_12.Enabled)
                {
                    text_label.Text = button_add_12.Text;
                }
            }
        }
    }
}
