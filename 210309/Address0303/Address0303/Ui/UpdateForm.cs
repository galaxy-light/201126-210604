using AddressTest0222;
using AddressTest0222.control;
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

namespace Address0303.Ui
{
    partial class UpdateForm : MaterialForm
    {
        StudentCtrl sc;        

        // 오버로딩
        public UpdateForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            showupListView();
            if (sc.getList().Count == 0)
            {
                MessageBox.Show("데이터가 없습니다.");
                return;
            }
            exnamech.Checked = false;
            extelch.Checked = false;
            exaddressch.Checked = false;
            exemailch.Checked = false;
        }

        private void updateExit_Click(object sender, EventArgs e)
        {
            Close();
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

        private void showupListView()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                uplistView.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    addrList[i].Name,
                    addrList[i].Tel,
                    addrList[i].Address,
                    addrList[i].Email}));
            }
            setRowColor(uplistView, Color.White, Color.LightGray);
            int index = uplistView.Items.Count - 1;
            // listView.Items[index].Selected = true;
            // uplistView.Items[index].Focused = true;
            // uplistView.EnsureVisible(index);
        }

        private void uplistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uplistView.SelectedItems.Count != 0)
            {
                int n = uplistView.SelectedItems[0].Index;
                string name = uplistView.Items[n].SubItems[1].Text;
                string tel = uplistView.Items[n].SubItems[2].Text;
                string addr = uplistView.Items[n].SubItems[3].Text;
                string email = uplistView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름 : {0}", name);
                Console.WriteLine("전화 번호 : {0}", tel);
                Console.WriteLine("주소 : {0}", addr);
                Console.WriteLine("이메일 : {0}", email);
                Console.WriteLine("--------------------------");
                exnameBox.Text = name;
                extelBox.Text = tel;
                exaddressBox.Text = addr;
                exemailBox.Text = email;
            }
        }

        private void addrUpdate_Click(object sender, EventArgs e)
        {
            Upaddrinfo();            
        }

        private void Upaddrinfo()
        {
            List<Student> addrList = sc.getList();

            string a;
            string b;
            string c;
            string d;
            string e;
            a = redataBox.Text;
            b = exnameBox.Text;
            c = extelBox.Text;
            d = exaddressBox.Text;
            e = exemailBox.Text;

            if (exnamech.Checked == true)
            {
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Name.Equals(b))
                    {
                        addrList[i].Name = redataBox.Text;
                        MessageBox.Show("이름 정보가 변경되었습니다.");
                        break;
                    }
                }
            }

            else if (extelch.Checked == true)
            {
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Tel.Equals(c))
                    {
                        {
                            addrList[i].Tel = redataBox.Text;
                            MessageBox.Show("전화 번호 정보가 변경되었습니다.");
                            break;
                        }
                    }
                }
            }

            else if (exaddressch.Checked == true)
            {
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Address.Equals(d))
                    {
                        {
                            addrList[i].Address = redataBox.Text;
                            MessageBox.Show("주소 정보가 변경되었습니다.");
                            break;
                        }
                    }
                }
            }

            else if (exemailch.Checked == true)
            {
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Email.Equals(e))
                    {
                        addrList[i].Email = redataBox.Text;
                        MessageBox.Show("이메일 정보가 변경되었습니다.");
                        break;
                    }
                }
            }

            else
            {
                MessageBox.Show("수정할 항목을 체크해주세요.");
            }
        }

       

        private void redata_Click(object sender, EventArgs e)
        {

        }

        private void redataBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수정할 항목을 체크를 하고 데이터 입력 후 변경 버튼을 눌러주세요.");
        }

        private void extelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exaddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exemailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exnamech_ValueChanged(object sender, bool value)
        {
            
        }

        private void extelch_ValueChanged(object sender, bool value)
        {

        }

        private void exaddressch_ValueChanged(object sender, bool value)
        {

        }

        private void exemailch_ValueChanged(object sender, bool value)
        {

        }
    }
}
