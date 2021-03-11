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

namespace Address0308.Ui
{
    partial class DelForm : MaterialForm
    {
        StudentCtrl sc;        

        public DelForm()
        {
            InitializeComponent();            
        }

        // 오버로딩
        public DelForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }
            
        private void DelForm_Load(object sender, EventArgs e)
        {
            allDeleteBox.Checked = false;
            showListView();
            if (sc.getList().Count == 0)
            {
                MessageBox.Show("데이터가 없습니다.");
                return;
            }
        }

        private void deleteExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dellistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dellistView.SelectedItems.Count != 0)
            {
                int n = dellistView.SelectedItems[0].Index;
                string name = dellistView.Items[n].SubItems[1].Text;
                string tel = dellistView.Items[n].SubItems[2].Text;
                string addr = dellistView.Items[n].SubItems[3].Text;
                string email = dellistView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름 : {0}", name);
                Console.WriteLine("전화 번호 : {0}", tel);
                Console.WriteLine("주소 : {0}", addr);
                Console.WriteLine("이메일 : {0}", email);
                Console.WriteLine("--------------------------");
                dellistView.Items.RemoveAt(n);
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
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                dellistView.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    addrList[i].Name,
                    addrList[i].Tel,
                    addrList[i].Address,
                    addrList[i].Email}));
            }
            setRowColor(dellistView, Color.White, Color.LightGray);
            int index = dellistView.Items.Count - 1;
            //// listView.Items[index].Selected = true;
            //// dellistView.Items[index].Focused = true;
            //// dellistView.EnsureVisible(index);
        }


        private void alladdrDel_Click(object sender, EventArgs e)
        {
            if (allDeleteBox.Checked == true)
            {
                alldeladdr();
                MessageBox.Show("주소록이 전체 삭제 되었습니다.");
            }
            else if (allDeleteBox.Checked == false)
            {
                MessageBox.Show("체크 박스에 체크가 되어있지 않습니다.");
            }
        }

        private void alldeladdr()
        {
            List<Student> addrList = sc.getList();
            addrList.Clear();
        }

        private void idDelete_Click(object sender, EventArgs e)
        {
            iddel();            
        }

        private void iddel()
        {
            string a;
            List<Student> addrList = sc.getList();
            Console.Write("삭제할 전화 번호 입력 : ");
            a = Console.ReadLine();
            delBox.Text = a;
            for (int i = 0; i < sc.getList().Count; i++)
            {
                /*  if (addrList[i].Tel.Equals(a))
                  {
                      addrList.RemoveAt(i--);
                      MessageBox.Show("정보가 삭제 되었습니다.");
                      break;
                  }
                  else if (!addrList[i].Tel.Equals(a))
                  {
                      MessageBox.Show("일치 x");
                      break;
                  }*/

                /*if (addrList[i].Tel == a)
                {
                    addrList.RemoveAt(i--);
                    MessageBox.Show("정보가 삭제 되었습니다.");
                    break;
                }
                else if (addrList[i].Tel != a)
                {
                    MessageBox.Show("일치 x");
                    break;
                }*/

                if (a == addrList[i].Tel)
                {
                    addrList.RemoveAt(i--);
                    MessageBox.Show("정보가 삭제 되었습니다.");
                    break;
                }
                else if (a != addrList[i].Tel)
                {
                    MessageBox.Show("일치 x");
                    break;
                }        
            }
        }

        private void delNameBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dellabel_Click(object sender, EventArgs e)
        {

        }

        private void arrHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("데이터를 전체 삭제 : 우측 체크 박스에 체크를 먼저 하고 삭제 버튼을 눌러주세요." + "\r"
                + "특정 사용자 삭제 : 삭제 버튼을 먼저 눌러주세요." + "\r");            
        }
    }
}
