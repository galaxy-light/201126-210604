using System;
using System.Data;
using System.Data.SqlClient;

namespace Address0324.DB
{
    internal class MYSQL
    {
        public static SqlConnection conn = new SqlConnection();

        public static void ConnectDB()
        {
            try
            {
                conn.ConnectionString = string.Format("Data Source=({0}); " +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3"
                , "local", "AddressDATA", "SSPI");

                //conn.ConnectionString = $"Data Source=({"local"}); Initial Catalog={"MYDB"}; Timeout=3"; // 위와 동일한 구문

                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }

        public static DataSet Query_Select(string tableName)
        {
            ConnectDB();

            // SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM " + tableName;

            // DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, tableName); // SELECT * FROM My_Address의 결과가 da에 입력됨
            conn.Close(); // 연결 해제

            // dataGridView에 DB에서 가져온 데이터 입력하기
            return ds;
        }

        public static void InsertDB(string name, string tel, string address, string email)
        {
            try
            {
                ConnectDB();

                string sqlcommand = "INSERT INTO My_Address (name, tel, address, email)" +
                    " VALUES (@name, @tel, @address, @email)";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }

        public static void UpdateDB(string name, string tel, string address, string email)
        {
            try
            {
                ConnectDB();

                string sqlcommand = "UPDATE My_Address SET name=@name, tel=@tel, address=@address, email=@email" +
                    " WHERE name = @name";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }

        public static void DeleteDB(string name)
        {
            try
            {
                ConnectDB();

                string sqlcommand = "DELETE FROM My_Address WHERE name = @name";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
                //throw;
            }
        }
    }
}