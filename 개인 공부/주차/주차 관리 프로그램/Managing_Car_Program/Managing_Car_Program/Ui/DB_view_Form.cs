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
    public partial class DB_view_Form : MaterialForm
    {
        public DB_view_Form()
        {
            InitializeComponent();

            uiTextBox_start.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            uiTextBox_end.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (uiRadioButton1.Checked == true)
            {
                uiTextBox_start.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }
            else if (uiRadioButton2.Checked == true)
            {
                uiTextBox_end.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            }
        }
    }
}
