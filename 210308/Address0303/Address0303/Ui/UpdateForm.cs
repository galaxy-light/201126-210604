﻿using AddressTest0222;
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
            

        public UpdateForm(StudentCtrl sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            showListView();
        }

        private void updateInfo()
        { 
                    
        }

        private void updateExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameUpdate_Click(object sender, EventArgs e)
        {
                       
        }

        private void telUpdate_Click(object sender, EventArgs e)
        {

        }

        private void addressUpdate_Click(object sender, EventArgs e)
        {

        }

        private void emailUpdate_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int n = listView.SelectedItems[0].Index;
                string name = listView.Items[n].SubItems[1].Text;
                string tel = listView.Items[n].SubItems[2].Text;
                string addr = listView.Items[n].SubItems[3].Text;
                string email = listView.Items[n].SubItems[4].Text;
                Console.WriteLine("이름 : {0}", name);
                Console.WriteLine("전화 번호 : {0}", tel);
                Console.WriteLine("주소 : {0}", addr);
                Console.WriteLine("이메일 : {0}", email);
                Console.WriteLine("--------------------------");
                listView.Items.RemoveAt(n);
            }
        }

        private void initListView() // 이 클래스에서만 사용해서 private
        {
            string[] data = { "1", "홍길동", "010-1234-1234", "조선 한양 홍대감댁", "hong@naver.com" };
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
            listView.EnsureVisible(index);
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
            listView.Items[index].Focused = true;
            listView.EnsureVisible(index);
        }                   
    }
}
