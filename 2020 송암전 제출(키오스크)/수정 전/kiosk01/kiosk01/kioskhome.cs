using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk01
{
    public partial class kioskhome : Form
    {
        public kioskhome()
        {
            InitializeComponent();
            form_menulist1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form_menulist1.Visible = true;
            form_menulist1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
