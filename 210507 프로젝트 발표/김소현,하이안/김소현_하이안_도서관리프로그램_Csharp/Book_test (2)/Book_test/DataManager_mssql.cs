using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Book_test
{
    class DataManager_mssql
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager_mssql()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                //select 문으로 해당 테이블의 전체 데이터들을 가져옴
                DBHelper.selectQuery_Book();

                Books.Clear(); //새로 조회할 때마다 Clear 해줘야 함
                foreach (DataRow item in DBHelper.dt_book.Rows)
                {
                    Book book = new Book();
                    book.Isbn = item["Isbn"].ToString();
                    book.Name = item["Name"].ToString();
                    book.Publisher = item["Publisher"].ToString();
                    book.Page = int.Parse(item["Page"].ToString());
                    book.BorrowedAt = item["BorrowedAt"].ToString() == "" ? new DateTime() : DateTime.Parse(item["BorrowedAt"].ToString());
                    book.isBorrowed = bool.Parse(item["isBorrowed"].ToString());
                    if (item["UserId"].ToString() == "")
                    {
                        book.UserId = 0;
                    }
                    else
                    {
                        book.UserId = int.Parse(item["UserId"].ToString());
                    }
                    book.UserName = item["UserName"].ToString();
                    Books.Add(book);
                }

                DBHelper.selectQuery_User();
                 Users.Clear();
                foreach (DataRow item in DBHelper.dt_user.Rows)
                {
                    User user = new User();
                    user.Id = int.Parse(item["uId"].ToString());
                    user.Name = item["Name"].ToString();
                    Users.Add(user);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show(e.StackTrace);
            }
        }

        public static void CreateFile()
        {
            //Cars.xml 파일을 만들겁니다.

            string fileName = @"./Books.xml";
            StreamWriter writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제
            fileName = @"./Users.xml";
            writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제

        }

        public static void Save()
        {
            //부모테이블에 해당하는 UserTable을 먼저 리셋한다.
            DBHelper.allDeleteTable("bookuser");
            foreach (var item in Users)
            {
                DBHelper.allInsertIntoUserTable(item.Id, item.Name);
            }

            DBHelper.allDeleteTable("book");

            foreach (var item in Books)
            {
                DBHelper.allInsertIntoBookTable(item.Isbn, item.Name, item.Publisher, item.Page, item.UserId, item.UserName, item.isBorrowed, item.BorrowedAt);
            }

        }
    }
    }
