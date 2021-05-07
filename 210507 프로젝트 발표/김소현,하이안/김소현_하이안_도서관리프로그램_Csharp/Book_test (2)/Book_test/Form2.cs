using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_test
{
    public partial class Form2 : Form
    {
        public Form2(ListBox listBox1)
        {
            InitializeComponent();
            Text = "도서 관리";

            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 버튼 설정
            button1.Click += (sender, e) =>
            {
                // 추가 버튼
                try
                {
                    DataManager.writelog("도서관리 추가 버튼 클릭", listBox1);

                    if (DataManager.Books.Exists((x) => x.Isbn == textBox1.Text))
                    {
                        MessageBox.Show("이미 존재하는 도서입니다");
                    }
                    else
                    {
                        Book book = new Book()
                        {
                            Isbn = textBox1.Text,
                            Name = textBox2.Text,
                            Publisher = textBox3.Text,
                            Page = int.Parse(textBox4.Text)
                        };
                        DataManager.Books.Add(book);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();
                    }
                }
                catch (Exception exception)
                {

                }
            };

            button2.Click += (sender, e) =>
            {
                // 수정 버튼
                try
                {
                    DataManager.writelog("도서관리 수정 버튼 클릭", listBox1);

                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    book.Name = textBox2.Text;
                    book.Publisher = textBox3.Text;
                    book.Page = int.Parse(textBox4.Text);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서입니다");
                }
            };

            button3.Click += (sender, e) =>
            {
                // 수정 버튼
                try
                {
                    DataManager.writelog("도서관리 삭제 버튼 클릭", listBox1);

                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    DataManager.Books.Remove(book);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서입니다");
                }
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
                textBox3.Text = book.Publisher;
                textBox4.Text = book.Page.ToString();
            }
            catch (Exception exception)
            {

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1.new_main();
        }
    }
}
