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
    partial class VipCustViewForm : MaterialForm
    {
        VipData vc;

        public VipCustViewForm()
        {
            InitializeComponent();
        }

        public VipCustViewForm(VipData vc)
        {
            InitializeComponent();
            this.vc = vc;
        }

        private void Vip_Customer_Load(object sender, EventArgs e)
        {
            showListView();           
            if (vc.getVips().Count == 0)
            {
                MessageBox.Show("등록된 고객이 없습니다.");
                return;
            }
            infonull();           
            timer1.Start();
            TimeFunction();
        }

        private void TimeFunction()
        {
            if (timer1.Interval == 3000) 
            {
                //rebinding();
                Console.WriteLine("test");
            }           
        }

        private void rebinding()
        {
            listView1.Items.Clear();
            listView1.Refresh();
        }

        private void uiSymbolButton_add_Click(object sender, EventArgs e)
        {
            new Cust_ma_Form(vc).Show();           
        }        

        private void infonull()
        {
            List<VipCust> vips = vc.getVips();
            for (int i = 0; i < vips.Count; i++)
            {
                if (vips[i].custnm == "")
                {
                    MessageBox.Show("이름 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custcarnum == "")
                {
                    MessageBox.Show("차량번호 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custph == "")
                {
                    MessageBox.Show("전화번호 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custstart == "")
                {
                    MessageBox.Show("시작일 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custend == "")
                {
                    MessageBox.Show("종료일 정보가 없습니다.");
                    return;
                }
            }
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

        private void showListView()
        {
            int temp = vc.getVips().Count;
            for (int i = 0; i < temp; i++)
            {
                List<VipCust> vips = vc.getVips();
                listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    vips[i].custnm,
                    vips[i].custcarnum,
                    vips[i].custph,
                    vips[i].custstart,
                    vips[i].custend}));
            }
            setRowColor(listView1, Color.White, Color.LightBlue);
            int index = listView1.Items.Count - 1;
            // listView.Items[index].Selected = true;
            // listView.Items[index].Focused = true;
            // listView.EnsureVisible(index);
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int count = listView1.SelectedItems[0].Index;
                string name = listView1.Items[count].SubItems[1].Text;
                string carnum = listView1.Items[count].SubItems[2].Text;
                string phone = listView1.Items[count].SubItems[3].Text;
                string start = listView1.Items[count].SubItems[4].Text;
                string end = listView1.Items[count].SubItems[5].Text;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton_refresh_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }       
    }
}
