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
                //exName.Text = name;
                //exTel.Text = tel;
                //exAddress.Text = addr;
                //exEmail.Text = email;               
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
            a = exdataBox.Text;
            b = redataBox.Text;

            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Name.Equals(a))
                {
                    addrList[i].Name = b;
                    MessageBox.Show("이름 정보가 변경되었습니다.");
                    break;
                }

                /*else      
                {
                    MessageBox.Show("일치하는 정보가 없습니다.");
                    break;
                }*/
            }

            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Tel.Equals(a))
                {
                    {
                        addrList[i].Tel = b;
                        MessageBox.Show("전화 번호 정보가 변경되었습니다.");
                        break;
                    }
                }

                /*else
                {
                    MessageBox.Show("일치하는 정보가 없습니다.");
                    break;
                }*/
            }

            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Address.Equals(a))
                {
                    {
                        addrList[i].Address = b;
                        MessageBox.Show("주소 정보가 변경되었습니다.");
                        break;
                    }
                }

                /*else
                {
                    MessageBox.Show("일치하는 정보가 없습니다.");
                    break;
                }*/
            }

            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Email.Equals(a))
                {
                    addrList[i].Email = b;
                    MessageBox.Show("이메일 정보가 변경되었습니다.");
                    break;
                }

                /*else
                {
                    MessageBox.Show("일치하는 정보가 없습니다.");
                    break;
                }*/
            }
        }

        private void exdata_Click(object sender, EventArgs e)
        {

        }

        private void exdataBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void redata_Click(object sender, EventArgs e)
        {

        }

        private void redataBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("변경 버튼을 먼저 눌러주세요.");
        }
    }
}
