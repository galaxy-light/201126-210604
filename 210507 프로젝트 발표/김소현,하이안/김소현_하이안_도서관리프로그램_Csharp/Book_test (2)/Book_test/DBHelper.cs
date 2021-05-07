using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_test
{
    class DBHelper
    {
        public static SqlConnection conn = new SqlConnection();
        public static DataSet ds;
        public static DataTable dt_book;
        public static DataTable dt_user;

        public static void ConnectDB()
        {
            try
            {

                conn.ConnectionString = string.Format("Data Source=({0}); " +
                        "Initial Catalog = {1};" +
                        "Integrated Security = {2};" +
                        "Timeout = 3"
                        , "local", "BookManager", "SSPI");
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }
        public static void selectQuery_Book(string Isbn = "")
        {
            ConnectDB();

            //SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (Isbn == "")
            {
                cmd.CommandText = "SELECT * FROM book";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "book");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView_BookManager.DataSource = ds;
                //dataGridView_BookManager.DataMember = "BookTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM book Where Isbn = " + Isbn;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "book");

                dt_book = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        public static void selectQuery_User(int Id = -1)
        {
            ConnectDB();

          
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (Id < 0)
            {
                cmd.CommandText = "SELECT * FROM bookuser";

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "bookuser");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
                //dataGridView에 DB에서 가져온 데이터 입력하기
                //dataGridView_UserManager.DataSource = ds;
                //dataGridView_UserManager.DataMember = "UserTable";

            }
            else
            {
                cmd.CommandText = "SELECT * FROM bookuser Where Id = " + Id;

                //DataAdapter와 DataSet으로 DB table 불러오기
                //DataSet은 메모리상의 하나의 DB 객체이며 DataTable은 메모리상의 하나의 테이블 객체
                SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "bookuser");

                dt_user = ds.Tables[0]; //select 결과값을 DataTable에 넣는다.
            }

            conn.Close(); //연결 해제
        }

        public static void allInsertIntoBookTable(string Isbn, string Name, string Publisher, int Page, int? UserId, string UserName, bool isBorrowed, DateTime BorrowedAt)
        {
            try
            {
                ConnectDB();
                string sqlcommand;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                if (UserId != null && UserId > 0 && BorrowedAt != DateTime.MinValue) //대여중
                {
                    sqlcommand = "Insert Into book (Isbn, Name, Publisher, Page, UserId, UserName, isBorrowed, BorrowedAt) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)".ToLower();
                    cmd.Parameters.AddWithValue("@p1", Isbn);
                    cmd.Parameters.AddWithValue("@p2", Name);
                    cmd.Parameters.AddWithValue("@p3", Publisher);
                    cmd.Parameters.AddWithValue("@p4", Page);
                    cmd.Parameters.AddWithValue("@p5", UserId);
                    cmd.Parameters.AddWithValue("@p6", UserName);
                    cmd.Parameters.AddWithValue("@p7", isBorrowed);
                    cmd.Parameters.AddWithValue("@p8", BorrowedAt.ToString("yyyy-MM-dd"));
                }
                else //대여중이지 않은 상태(userid, username, borrowedat 값이 모두 null임)
                {
                    sqlcommand = "Insert Into book (Isbn, Name, Publisher, Page, isBorrowed) values (@p1, @p2, @p3, @p4, @p5)".ToLower();
                    cmd.Parameters.AddWithValue("@p1", Isbn);
                    cmd.Parameters.AddWithValue("@p2", Name);
                    cmd.Parameters.AddWithValue("@p3", Publisher);
                    cmd.Parameters.AddWithValue("@p4", Page);
                    cmd.Parameters.AddWithValue("@p5", isBorrowed);

                }

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }

        public static void allInsertIntoUserTable(int Id, string Name)
        {
            try
            {
                ConnectDB();
                string sqlcommand = "Insert Into bookuser (uId, Name) values (@p1, @p2)".ToLower();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@p1", Id);
                cmd.Parameters.AddWithValue("@p2", Name);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                System.Windows.Forms.MessageBox.Show(e.StackTrace);
            }
        }

        public static void allDeleteTable(string tableName)
        {
            try
            {
                ConnectDB();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string sqlcommand;
                sqlcommand = $"Delete {tableName}";
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                conn.Close();
            }
            catch (Exception eee)
            {
                System.Windows.Forms.MessageBox.Show(eee.Message);
                System.Windows.Forms.MessageBox.Show(eee.StackTrace);
            }
        }
    }
}
