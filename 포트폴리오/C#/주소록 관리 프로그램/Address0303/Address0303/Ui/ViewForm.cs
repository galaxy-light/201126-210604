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
    partial class ViewForm : MaterialForm // public 삭제 -> 영역 충돌 방지
    {
        AddressCtrl sc;

        DataSet ds = new DataSet();

        public ViewForm() // 싱글톤
        {
            InitializeComponent();
        }

        // 오버로딩
        public ViewForm(AddressCtrl sc)
        {           
            InitializeComponent(); // InitializeComponent(); : 초기화 
            this.sc = sc;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // initListView();
            // initGridView();
            // showListView();
            showGridView();

            nullinfo();
        }

        private void nullinfo()
        {
            List<Address_attri> addrList = sc.getList();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Name == "")
                {
                    MessageBox.Show("이름 정보가 없습니다.");
                    return;
                }
                else if (addrList[i].Tel == "")
                {
                    MessageBox.Show("전화 번호 정보가 없습니다.");
                    return;
                }
                else if (addrList[i].Address == "")
                {
                    MessageBox.Show("주소 정보가 없습니다.");
                    return;
                }
                else if (addrList[i].Email == "")
                {
                    MessageBox.Show("이메일 정보가 없습니다.");
                    return;
                }            
            }
        }

        private void initListView() // 이 클래스에서만 사용해서 private
        {
            /*string[] data = { "1", "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" };
            listView.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                listView.Items.Add(new ListViewItem(
                    new string[] { (i + 2).ToString(), "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" }));
            }
            setRowColor(listView, Color.White, Color.LightBlue);
            int index = listView.Items.Count - 1;
            // listView.Items[index].Selected = true;
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);*/
        }

        private void showGridView()
        {
            ds = Address0324.DB.MYSQL.Query_Select("My_Address");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "My_Address";
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index%2) == 0) // 짝수 행
                {
                    item.BackColor = color1;
                }
                else // 홀수 행
                {
                    item.BackColor = color2;
                }
            }
        }

        //private void initGridView()
        //{
        //    string[] data = { "1", "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" };
        //    gridView.Rows.Add(data);

        //    for (int i = 0; i < 50; i++)
        //    {
        //        gridView.Rows.Add(new String[] {
        //            (i + 2).ToString(), "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" });
        //    }
        //    int count = gridView.Rows.Count - 1;
        //    gridView.FirstDisplayedScrollingRowIndex = count;
        //    gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        //}               

        /*private void showListView()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Address_attri> addrList = sc.getList();
                listView.Items.Add(new ListViewItem(new String[] {
                    (i+1).ToString(),
                    addrList[i].Name,
                    addrList[i].Tel,
                    addrList[i].Address,
                    addrList[i].Email}));
            }
            setRowColor(listView, Color.White, Color.LightGray);
            int index = listView.Items.Count - 1;
            // listView.Items[index].Selected = true;
            // listView.Items[index].Focused = true;
            // listView.EnsureVisible(index);
        }*/

        //private void showGridView()
        //{
        //    int cnt = sc.getList().Count;
        //    for (int i = 0; i < cnt; i++)
        //    {
        //        List<Student> addrList = sc.getList();
        //        gridView.Rows.Add(new String[] {
        //            (i + 1).ToString(),
        //            addrList[i].Name,
        //            addrList[i].Tel,
        //            addrList[i].Address,
        //            addrList[i].Email});
        //    }
        //    int count = gridView.Rows.Count - 1;
        //    gridView.FirstDisplayedScrollingRowIndex = count;
        //    gridView.CurrentCell = gridView.Rows[count - 1].Cells[0];
        //}

        

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
