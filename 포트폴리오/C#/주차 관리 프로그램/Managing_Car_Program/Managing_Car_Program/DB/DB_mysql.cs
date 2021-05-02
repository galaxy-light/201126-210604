using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program.DB
{
    class DB_mysql
    {
        public static MySqlConnection connection = new MySqlConnection();

        // Sql 새연결정보 생성 (Query문)               
        //cmd.CommandText = "insert into tbl_member (id,name,addr) values ('abc','홍길동','서울');";
        //cmd.CommandText = "update tbl_member set addr='서울' where id='abc' and name='홍길동';";
        //cmd.CommandText = "delete tbl_member where id='abc' and name='홍길동' and addr='서울';";   

        // MySQL DB셋팅 초기화
        public static void InitializeDB()
        {
            Console.WriteLine("DB 초기화");
            string connectionString;
            connectionString = $"SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;";

            connection = new MySqlConnection(connectionString);
        }

        public static DataSet vipdb(string tableName)
        {
            connection.Open();

            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();           
            cmd.CommandText = "SELECT * FROM " + tableName;

            //DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, tableName); // SELECT * FROM 테이블의 결과가 da에 입력됨
            connection.Close(); //연결 해제

            return ds;
            //listView / dataGridView에 DB에서 가져온 데이터 입력하기
        }

        public static void SelectDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                try//예외 처리
                {
                    connection.Open();
                    string sql = "SELECT * FROM viplist";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이터 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", table["name"], table["carnumber"], table["phone"], table["start"], table["end"]);
                    }
                    table.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void SelectUsingAdapter()
        {
            DataSet ds = new DataSet();
            string connStr = "SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                //MySqlDataAdapter 클래스를 이용하여
                //비연결 모드로 데이터 가져오기
                string sql = "SELECT * FROM viplist WHERE Id>=2";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "viplist");
            }

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Console.WriteLine(r["Name"]);
            }
        }

        public static void insertDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                string insertQuery = "INSERT INTO viplist(name, carnumber, phone, start, end) VALUES ('" + nametext + "', '" + carnumbertext + "', '" + phonetext + "', '" + starttext + "', '" + endtext + "')";

                try//예외 처리
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB insert 성공");
                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("DB insert 실패");
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void updateDB(int count, string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {          
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {               
                string updateQuery = "UPDATE viplist SET name=@nametext, carnumber=@nametext, phone=@phonetext, start=@starttext, end=@endtext WHERE id=@count";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@nametext", nametext);
                    command.Parameters.AddWithValue("@carnumbertext", carnumbertext);
                    command.Parameters.AddWithValue("@phonetext", phonetext);
                    command.Parameters.AddWithValue("@starttext", starttext);
                    command.Parameters.AddWithValue("@endtext", endtext);
                    command.Parameters.AddWithValue("@count", count);
                    command.CommandText = updateQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB update 성공");
                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("DB update 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.ToString());
                    //throw;
                }                
            }
        }

        public static void deleteDB(int count)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                string deleteQuery = "DELETE FROM viplist WHERE id=@count";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    
                    command.Parameters.AddWithValue("@count", count);
                    command.CommandText = deleteQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB delete 성공");
                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("DB delete 실패");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.ToString());
                    //throw;
                }
            }
        }
    }
}
