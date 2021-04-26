using Managing_Car_Program.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program.Ui
{
    partial class Other_view_Form : MaterialForm
    {
        public static List<Api_parking> parkinglist = new List<Api_parking>();

        public Other_view_Form()
        {
            InitializeComponent();
        }

        private void Other_view_Form_Load(object sender, EventArgs e)
        {
            showapidata();
        }

        private void showapidata()
        {
            foreach (var item in parkinglist)
            {
                dataGridView1.Rows.Add(item.Name, item.Location, item.Pcount);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
