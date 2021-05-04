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

        // vip DB 전체
        public static List<VipCust> Select_vip_DB()
        {
            List<VipCust> tempFromDB = new List<VipCust>();
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingvipdata;UID=root;PASSWORD=1126;"))
            {                
                try
                {
                    connection.Open();
                    string selectQuery = "select * from parkingviplist";

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

        // carnumber 조회
        public static List<VipCust> select_vip_car(string carnumbertext)
        {
            List<VipCust> tempDB = new List<VipCust>();
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingvipdata;UID=root;PASSWORD=1126;"))
            {
                try
                {
                    connection.Open();
                    string sql = "select * from parkingviplist where carnumber=" + "'" + carnumbertext + "'";

                    //ExecuteReader를 이용하여
                    //연결 모드로 데이터 가져오기
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", table["name"], table["carnumber"], table["phone"], table["start"], table["end"]);
                        tempDB.Add(new VipCust() { custnm = table["name"].ToString(), custcarnum = table["carnumber"].ToString(), custph = table["phone"].ToString(), custstart = table["start"].ToString(), custend = table["end"].ToString() });
                    }
                    table.Close();
                    return tempDB;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB select carnumber 실패");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
        }

        public static void insert_in_DB(string parkingspottext, string carnumbertext, string parkingintext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingindata;UID=root;PASSWORD=1126;"))
            {
                string insertinQuery = "INSERT INTO parkinginlist(parkinginspot, parkingincar, parkingintime) VALUES ('" + parkingspottext + "', '" + carnumbertext + "', '" + parkingintext + "')";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertinQuery, connection);

                    //command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB insert parkingin 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB insert parkingin 실패");
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

        public static void insert_out_DB(string parkingspottext, string carnumbertext, string parkingouttext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingoutdata;UID=root;PASSWORD=1126;"))
            {
                string insertoutQuery = "INSERT INTO parkingoutlist(parkingoutspot, parkingoutcar, parkingouttime) VALUES ('" + parkingspottext + "', '" + carnumbertext + "', '" + parkingouttext + "')";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertoutQuery, connection);

                    //command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB insert parkingout 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB insert parkingout 실패");
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

        public static void insert_vip_DB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingvipdata;UID=root;PASSWORD=1126;"))
            {
                string insertvipQuery = "INSERT INTO parkingviplist(name, carnumber, phone, start, end) VALUES ('" + nametext + "', '" + carnumbertext + "', '" + phonetext + "', '" + starttext + "', '" + endtext + "')";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertvipQuery, connection);

                    //command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB insert vip 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB insert vip 실패");
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

        public static void update_vip_DB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext, string carnumber)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingvipdata;UID=root;PASSWORD=1126;"))
            {
                //string updateQuery = "UPDATE viplist SET name=@nametext, carnumber=@nametext, phone=@phonetext, start=@starttext, end=@endtext WHERE carnumber=@carnumber";
                string updateQuery = "UPDATE parkingviplist SET name=" + "'" + nametext + "', " + "carnumber=" + "'" + carnumbertext + "', " + "phone=" + "'" + phonetext + "', " + "start=" + "'" + starttext + "', " + "end=" + "'" + endtext + "' " + "WHERE " + "carnumber=" + "'" + carnumber + "'";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                                        
                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB update vip 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB update vip 실패");
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

        public static void delete_vip_DB(string carnumber)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingvipdata;UID=root;PASSWORD=1126;"))
            {
                //string deleteQuery = "DELETE FROM viplist WHERE carnumber = @carnumber";
                string deleteQuery = "DELETE FROM parkingviplist WHERE carnumber=" + "'" + carnumber + "'";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                    //command.CommandText = deleteQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("DB delete vip 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB delete vip 실패");
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

        public static void truncate_parking_in_DB()
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingindata;UID=root;PASSWORD=1126;"))
            {                
                string truncateinQuery = "TRUNCATE TABLE parkinginlist";                

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(truncateinQuery, connection);

                    //command.CommandText = deleteQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() != 1)
                    {
                        Console.WriteLine("DB truncate in 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB truncate in 실패");
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

        public static void truncate_parking_out_DB()
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=parkingoutdata;UID=root;PASSWORD=1126;"))
            {                
                string truncateoutQuery = "TRUNCATE TABLE parkingoutlist";

                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(truncateoutQuery, connection);

                    //command.CommandText = insertQuery;

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() != 1)
                    {
                        Console.WriteLine("DB truncate out 성공");
                    }
                    else
                    {
                        Console.WriteLine("DB truncate out 실패");
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
