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
    partial class Vip_Customer : MaterialForm
    {
        VipData vc;

        public Vip_Customer()
        {
            InitializeComponent();
        }

        public Vip_Customer(VipData vc)
        {
            InitializeComponent();
            this.vc = vc;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton_add_Click(object sender, EventArgs e)
        {
            new Ad_cu_Form().Show();
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
        }

        private void infonull()
        {
            List<VipCust> Vips = vc.getVips();
            for (int i = 0; i < Vips.Count; i++)
            {
                if (Vips[i].custnm == "")
                {
                    MessageBox.Show("이름 정보가 없습니다.");
                    return;
                }
                else if (Vips[i].custcarnum == "")
                {
                    MessageBox.Show("차량번호 정보가 없습니다.");
                    return;
                }
                else if (Vips[i].custph == "")
                {
                    MessageBox.Show("전화번호 정보가 없습니다.");
                    return;
                }
                else if (Vips[i].custstart == "")
                {
                    MessageBox.Show("시작일 정보가 없습니다.");
                    return;
                }
                else if (Vips[i].custend == "")
                {
                    MessageBox.Show("종료일 정보가 없습니다.");
                    return;
                }
            }
        }

        private void initListView() // 이 클래스에서만 사용해서 private
        {
            string[] data = { "1", "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" };
            listView1.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                listView1.Items.Add(new ListViewItem(
                    new string[] { (i + 2).ToString(), "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" }));
            }
            setRowColor(listView1, Color.White, Color.LightBlue);
            int index = listView1.Items.Count - 1;
            // listView.Items[index].Selected = true;
            listView1.Items[index].Focused = true;
            listView1.EnsureVisible(index);
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
            int count = vc.getVips().Count;
            for (int i = 0; i < count; i++)
            {
                List<VipCust> Vips = vc.getVips();
                listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    Vips[i].custnm,
                    Vips[i].custcarnum,
                    Vips[i].custph,
                    Vips[i].custstart,
                    Vips[i].custend}));
            }
            setRowColor(listView1, Color.White, Color.LightBlue);
            int index = listView1.Items.Count - 1;
            // listView.Items[index].Selected = true;
            // listView.Items[index].Focused = true;
            // listView.EnsureVisible(index);
        }
    }
}
