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
        // 코드 참고 : https://wiseraintown.tistory.com/entry/C-MySQL-DataBase-%EC%97%B0%EB%8F%99%ED%95%98%EA%B8%B0-1

        public static MySqlConnection connection = new MySqlConnection();

        // MySQL DB셋팅 초기화
        public static void InitializeDB()
        {
            Console.WriteLine("DB 초기화");
            string connectionString;
            connectionString = $"SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;";

            connection = new MySqlConnection(connection.ConnectionString);
        }

        // 데이터베이스 연결을 Open
        public static bool OpenConnection()
        {
            InitializeDB();
            try
            {
                connection.Open();
                Console.WriteLine("DataBase 연동 성공");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("데이터베이스 서버에 연결할 수 없습니다.");
                        break;

                    case 1045:
                        Console.WriteLine("유저 ID 또는 Password를 확인해주세요.");
                        break;
                }
                return false;
            }
        }

        /*// 데이터베이스 연결을 Close
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }        

        public static DataSet vipDB(string tableName)
        {
            InitializeDB();

            MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;");

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
        }*/

        public static List<VipCust> SelectDB()
        {
            List<VipCust> tempFromDB = new List<VipCust>();
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {                
                try
                {
                    connection.Open();
                    string selectQuery = "select * from viplist";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이터 가져오기
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", table["name"], table["carnumber"], table["phone"], table["start"], table["end"]);
                        tempFromDB.Add(new VipCust() { custnm = table["name"].ToString(), custcarnum = table["carnumber"].ToString(), custph = table["phone"].ToString(), custstart = table["start"].ToString(), custend = table["end"].ToString() });
                    }
                    table.Close();
                    return tempFromDB;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB select 실패");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }

        /*public static void SelectUsingAdapter()
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
        }*/

        public static void insertDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                string insertQuery = "INSERT INTO viplist(name, carnumber, phone, start, end) VALUES ('" + nametext + "', '" + carnumbertext + "', '" + phonetext + "', '" + starttext + "', '" + endtext + "')";

                try//예외 처리
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    //command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB insert 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB insert 실패");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public static void updateDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext, string carnumber)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                //string updateQuery = "UPDATE viplist SET name=@nametext, carnumber=@nametext, phone=@phonetext, start=@starttext, end=@endtext WHERE carnumber=@carnumber";
                string updateQuery = "UPDATE viplist SET name=" + "'" + nametext + "', " + "carnumber=" + "'" + carnumbertext + "', " + "phone=" + "'" + phonetext + "', " + "start=" + "'" + starttext + "', " + "end=" + "'" + endtext + "' " + "WHERE " + "carnumber=" + "'" + carnumber + "'";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                                        
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB update 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB update 실패");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    //throw;
                }
            }
        }

        public static void deleteDB(string carnumber)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                //string deleteQuery = "DELETE FROM viplist WHERE carnumber = @carnumber";
                string deleteQuery = "DELETE FROM viplist WHERE carnumber=" + "'" + carnumber + "'";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    //command.CommandText = deleteQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB delete 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB delete 실패");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }
    }
}
