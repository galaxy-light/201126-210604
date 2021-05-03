using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
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
        }

        private void DB_view_Form_Load(object sender, EventArgs e)
        {
            List<VipCust> dbList = DB.DB_mysql.SelectDB(); // dbList : 참조변수(주소값)
            int count = 1;
            foreach (var item in dbList)
            {
                listView1.Items.Add(new ListViewItem(new String[] {
                    (count).ToString(),
                    item.custnm,
                    item.custcarnum,
                    item.custph,
                    item.custstart,
                    item.custend}));
                count++;
            }
            setRowColor(listView1, Color.White, Color.LightBlue);
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0) // 짝수 행
                {
                    item.BackColor = color1;
                }
                else // 홀수 행
                {
                    item.BackColor = color2;
                }
            }
        }
    }
}
