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

            tooltip();

            button_search.FlatAppearance.BorderSize = 0;
        }

        private void tooltip()
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.ShowAlways = true;
            tooltip1.IsBalloon = false; // true : 테두리 둥글게 / false : 테두리 각지게
            tooltip1.AutoPopDelay = 0; // 설명이 표시되는 시간
            tooltip1.InitialDelay = 0; // 설명이 나타나기까지의 시간
            tooltip1.ReshowDelay = 100; // 다음 도구 설명 창이 나타날 때까지 걸리는 시간(밀리초)
            tooltip1.SetToolTip(uiSymbolButton_refresh, "새로고침");
        }

        private void DB_view_Form_Load(object sender, EventArgs e)
        {
            showvipdata();
        }

        private void showvipdata()
        {
            listView1.Items.Clear(); // Clear() 안해주면 중복으로 뜸
            List<VipCust> dbList = DB.DB_mysql.Select_vip_DB(); // dbList : 참조변수(주소값)
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

        private void uiSymbolButton_refresh_Click(object sender, EventArgs e)
        {
            showvipdata();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); // Clear() 안해주면 중복으로 뜸
            List<VipCust> templist = DB.DB_mysql.select_vip_car(textBox.Text); // dbList : 참조변수(주소값)
            int count = 1;
            foreach (var item in templist)
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
        }
    }
}
