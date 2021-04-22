using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Managing_Car_Program.Ui
{
    partial class VipCustViewForm : MaterialForm
    {

        public VipCustViewForm()
        {
            InitializeComponent();
        }

        private void Vip_Customer_Load(object sender, EventArgs e)
        {
            VipData.Load();
            showListView();           
            if (VipData.vips.Count == 0)
            {
                MessageBox.Show("등록된 고객이 없습니다.");
                return;
            }
            infonull();
        }

        private void uiSymbolButton_add_Click(object sender, EventArgs e)
        {
            txtwriteLog("추가 버튼 클릭");
            new Cust_ma_Form().ShowDialog();
            showListView();
            VipData.Savetxt();
        }        

        private void infonull()
        {
            List<VipCust> vips = VipData.vips;
            for (int i = 0; i < vips.Count; i++)
            {
                if (vips[i].custnm.Trim() == "")
                {
                    MessageBox.Show("이름 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custcarnum.Trim() == "")
                {
                    MessageBox.Show("차량번호 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custph.Trim() == "")
                {
                    MessageBox.Show("전화번호 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custstart.Trim() == "")
                {
                    MessageBox.Show("시작일 정보가 없습니다.");
                    return;
                }
                else if (vips[i].custend.Trim() == "")
                {
                    MessageBox.Show("종료일 정보가 없습니다.");
                    return;
                }
                else
                {
                    string txtcontents = $"" +
                        $"이름 : {vips[i].custnm}, " +
                        $"차량번호 : {vips[i].custcarnum}," +
                        $"전화번호 : {vips[i].custph}," +
                        $"정기권시작일 : {vips[i].custstart}," +
                        $"정기권종료일 : {vips[i].custend}";
                    txtwriteLog($"{txtcontents}");
                }
            }
        }

        private void txtwriteLog(string txtcontents)
        {
            string txtlogcontents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]{txtcontents}";
            //listView1.Items.Insert(0, txtcontents);          
            VipData.printlogtxt(txtlogcontents);
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
            listView1.Items.Clear();
            for (int i = 0; i < VipData.vips.Count; i++)
            {
                List<VipCust> vips = VipData.vips;
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

        private void uiSymbolButton_del_Click(object sender, EventArgs e)
        {
            txtwriteLog("삭제 버튼 클릭");
        }

        private void uiCheckBox_start_1_ValueChanged(object sender, bool value)
        {
            listView1.Items.Clear();
            if (uiCheckBox_start_1.Checked == true)
            {
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_1.Checked = false;
                uiCheckBox_end_2.Checked = false;

            }
        }

        private void uiCheckBox_start_2_ValueChanged(object sender, bool value)
        {
            if (uiCheckBox_start_2.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_end_1.Checked = false;
                uiCheckBox_end_2.Checked = false;
            }
        }

        private void uiCheckBox_end_1_ValueChanged(object sender, bool value)
        {
            if (uiCheckBox_end_1.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_2.Checked = false;
            }
        }

        private void uiCheckBox_end_2_ValueChanged(object sender, bool value)
        {
            if (uiCheckBox_end_2.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_1.Checked = false;
            }
        }
    }
}
