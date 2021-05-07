using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";

            // 라벨 설정
            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) => {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) > DateTime.Now;
            }).Count().ToString();

            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += dataGridView2_CurrentCellChanged;

            // 버튼 이벤트 설정
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            DataManager.writelog("대여 버튼 클릭", listBox1);
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("사용자 Id를 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox3.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"이/가 \"" + user.Name + "\"님께 대여되었습니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.writelog("반납 버튼 클릭", listBox1);
            if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Isbn을 입력해주세요");
                }
                else
                {
                    try
                    {
                        Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                        if (book.isBorrowed)
                        {
                            User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());
                            book.UserId = 0;
                            book.UserName = "";
                            book.isBorrowed = false;
                            book.BorrowedAt = new DateTime();

                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = DataManager.Books;
                            DataManager.Save();

                            if (book.BorrowedAt.AddDays(7) > DateTime.Now)
                            {
                                MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                            }
                            else
                            {
                                MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("대여 상태가 아닙니다.");
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                    }
                }
            }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
            //선택 돼 있던 셀이 바꼈을 때 대여 반납 부분에서 텍스트 박스가 바뀌는 코드   
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
                textBox3.Text = book.UserId.ToString();
            }
            catch (Exception exception)
            {

            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
            }
            catch (Exception exception)
            {

            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataManager.writelog("도서 관리 모드 진입", listBox1);
            new Form2(listBox1).ShowDialog();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataManager.writelog("사용자 관리 모드 진입", listBox1);

            new Form3(listBox1).ShowDialog();
        }

        
    }
}
