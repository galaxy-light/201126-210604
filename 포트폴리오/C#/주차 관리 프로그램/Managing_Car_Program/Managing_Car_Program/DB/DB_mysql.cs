using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program.Control
{
    class DB_mysql
    {
        public static MySqlConnection connection = new MySqlConnection();

        // MySQL DB셋팅 초기화
        /*private void InitializeDB()
        {
            Console.WriteLine("DB 초기화");
            string connectionString;
            connectionString = $"SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;";

            connection = new MySqlConnection(connectionString);
        }*/

        private void SelectDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
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
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void insertDB(string nametext, string carnumbertext, string phonetext, string starttext, string endtext)
        {
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=vipdata;UID=root;PASSWORD=1126;"))
            {
                string insertQuery = "INSERT INTO viplist(name, carnumber, phone, start, end) VALUES(nametext, carnumbertext, phonetext, starttext, endtext)";
                
                try//예외 처리
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Console.WriteLine("인서트 성공");
                    }
                    else
                    {
                        Console.WriteLine("인서트 실패");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
