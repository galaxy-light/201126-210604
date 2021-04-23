using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Managing_Car_Program.Ui
{
    partial class VipCustViewForm : MaterialForm
    {
        static int n;
        public VipCustViewForm()
        {
            InitializeComponent();
        }

        private void Vip_Customer_Load(object sender, EventArgs e)
        {
            textBox_name.Enabled = false;
            textBox_carnum.Enabled = false;
            textBox_phnum.Enabled = false;
            textBox_start.Enabled = false;
            textBox_end.Enabled = false;

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
                if (vips[i].custnm.Trim() == "" && vips[i].custcarnum.Trim() == "" &&
                    vips[i].custph.Trim() == "" && vips[i].custstart.Trim() == "" && vips[i].custend.Trim() == "")
                {
                    MessageBox.Show("정보가 없습니다.");
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

            if (VipData.vips.Count > 0)
            {
                for (int j = 0; j < VipData.vips.Count; j++)
                {
                    List<VipCust> vips = VipData.vips;
                    listView1.Items.Add(new ListViewItem(new String[] {
                    (j+1).ToString(),
                    vips[j].custnm,
                    vips[j].custcarnum,
                    vips[j].custph,
                    vips[j].custstart,
                    vips[j].custend}));
                }
                setRowColor(listView1, Color.White, Color.LightBlue);
                int index = listView1.Items.Count - 1;
                // listView.Items[index].Selected = true;
                // listView.Items[index].Focused = true;
                // listView.EnsureVisible(index);
            }
            else
            {
                return;
            }
        }

        private void uiSymbolButton_update_on_Click(object sender, EventArgs e)
        {            
            infoupdate();
        }

        private void infoupdate()
        {
            if (listView1.SelectedIndices.Count > 0) // 선택됐을 때
            {
                n = listView1.SelectedIndices[0]; // n에 선택한 인덱스 저장                
            }
            txtwriteLog("수정 버튼 클릭");

            listView1.Items.Clear();
            List<VipCust> vips = VipData.vips;

            VipCust temp = vips[n];
            temp.custnm = textBox_name.Text;
            temp.custcarnum = textBox_carnum.Text;
            temp.custph = textBox_phnum.Text;
            temp.custstart = textBox_start.Text;
            temp.custend = textBox_end.Text;

            VipData.Savetxt();
            showListView();
        }

        private void uiSymbolButton_del_Click(object sender, EventArgs e)
        {         
            try
            {
                if (listView1.SelectedIndices.Count > 0) // 선택됐을 때
                {
                    n = listView1.SelectedIndices[0]; // n에 선택한 인덱스 저장
                }
                txtwriteLog("삭제 버튼 클릭");
                listView1.Items.Clear();
                List<VipCust> vips = VipData.vips;

                VipData.vips.RemoveAt(n);
                VipData.Savetxt();
                showListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제할 데이터가 없습니다.");
                VipData.printlogtxt(ex.Message);
                VipData.printlogtxt(ex.StackTrace);
                VipData.Savetxt();
                //throw;
            }
        }

        private void uiCheckBox_start_1_ValueChanged(object sender, bool value)
        {
            listView1.Items.Clear();
            if (uiCheckBox_start_1.Checked == true)
            {
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_1.Checked = false;
                uiCheckBox_end_2.Checked = false;

                for (int i = 0; i < VipData.vips.Count; i++)
                {
                    List<VipCust> temp = VipData.vips.OrderBy(x => x.custstart).ToList();
                    listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    temp[i].custnm,
                    temp[i].custcarnum,
                    temp[i].custph,
                    temp[i].custstart,
                    temp[i].custend}));
                }
            }
        }

        private void uiCheckBox_start_2_ValueChanged(object sender, bool value)
        {
            listView1.Items.Clear();
            if (uiCheckBox_start_2.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_end_1.Checked = false;
                uiCheckBox_end_2.Checked = false;

                for (int i = 0; i < VipData.vips.Count; i++)
                {
                    List<VipCust> temp = VipData.vips.OrderByDescending(x => x.custstart).ToList();
                    listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    temp[i].custnm,
                    temp[i].custcarnum,
                    temp[i].custph,
                    temp[i].custstart,
                    temp[i].custend}));
                }
            }
        }

        private void uiCheckBox_end_1_ValueChanged(object sender, bool value)
        {
            listView1.Items.Clear();
            if (uiCheckBox_end_1.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_2.Checked = false;

                for (int i = 0; i < VipData.vips.Count; i++)
                {
                    List<VipCust> temp = VipData.vips.OrderBy(x => x.custend).ToList();
                    listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    temp[i].custnm,
                    temp[i].custcarnum,
                    temp[i].custph,
                    temp[i].custstart,
                    temp[i].custend}));
                }
            }
        }

        private void uiCheckBox_end_2_ValueChanged(object sender, bool value)
        {
            listView1.Items.Clear();
            if (uiCheckBox_end_2.Checked == true)
            {
                uiCheckBox_start_1.Checked = false;
                uiCheckBox_start_2.Checked = false;
                uiCheckBox_end_1.Checked = false;

                for (int i = 0; i < VipData.vips.Count; i++)
                {
                    List<VipCust> temp = VipData.vips.OrderByDescending(x => x.custend).ToList();
                    listView1.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    temp[i].custnm,
                    temp[i].custcarnum,
                    temp[i].custph,
                    temp[i].custstart,
                    temp[i].custend}));
                }
            }
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
                textBox_name.Text = name;
                textBox_carnum.Text = carnum;
                textBox_phnum.Text = phone;
                textBox_start.Text = start;
                textBox_end.Text = end;
            }
        }

        private void uiSymbolButton_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보 수정 : 수정 체크 - 리스트 클릭 - 입력 - 수정(우측 상단) 버튼 클릭 \r" +
                "정보 삭제 : 수정 체크 - 리스트 클릭 - 입력 - 수정(우측 상단) 버튼 클릭");
        }

        private void uiCheckBox_update_ValueChanged(object sender, bool value)
        {
            if (uiCheckBox_update.Checked == true)
            {
                textBox_name.Enabled = true;
                textBox_carnum.Enabled = true;
                textBox_phnum.Enabled = true;
                textBox_start.Enabled = true;
                textBox_end.Enabled = true;
            }
            else
            {
                textBox_name.Enabled = false;
                textBox_carnum.Enabled = false;
                textBox_phnum.Enabled = false;
                textBox_start.Enabled = false;
                textBox_end.Enabled = false;
            }
        }
    }
}
