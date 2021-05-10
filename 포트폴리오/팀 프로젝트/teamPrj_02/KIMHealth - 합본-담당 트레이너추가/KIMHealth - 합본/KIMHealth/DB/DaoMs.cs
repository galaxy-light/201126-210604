using System;
using System.Data;
using System.Data.SqlClient;

namespace KIMHealth.DB
{
    class DaoMs
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
                , "local", "GYM_DB", "SSPI");
                conn = new SqlConnection(conn.ConnectionString);
                conn.Open();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
            
        }

        public static DataSet DB_GYM(string tableName)
        {
            ConnectDB();

            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM " + tableName;

            //DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, tableName); // SELECT * FROM 테이블의 결과가 da에 입력됨
            conn.Close(); //연결 해제

            return ds;
            //dataGridView에 DB에서 가져온 데이터 입력하기

        }
        
        public static DataSet SelectId (string tableName, int id)
        {
            ConnectDB();

            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM " + tableName + " WHERE m_num = " + id;


            //DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, tableName); // SELECT * FROM 테이블의 결과가 da에 입력됨
            conn.Close(); //연결 해제

            return ds;
            //dataGridView에 DB에서 가져온 데이터 입력하기

        }
        
        public static DataSet SelectName(string tableName, string name)
        {
            ConnectDB();

            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("SELECT * FROM {0} WHERE m_name = '{1}'", tableName, name);


            //DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, tableName); // SELECT * FROM 테이블의 결과가 da에 입력됨
            conn.Close(); //연결 해제

            return ds;
            //dataGridView에 DB에서 가져온 데이터 입력하기

        }

        public static string countMember(string id)
        {
            ConnectDB();
            string s = "";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM M_TB WHERE m_num = " + id;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                s = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
            return s;
        }

        public static string countMemberName(string name)
        {
            ConnectDB();
            string s = "";
            //SQL명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format("SELECT COUNT(*) FROM M_TB WHERE m_name = '{0}'", name);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                s = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
            return s;
        }






        public static void DB_Insert(string name, string phone, string address, string age, string gender, string height, string weight,
                                     string bmi, string membership, string lent, string pt, string trainer, string startday, string endday)
        {
            try
            {

                ConnectDB();

                string sqlcommand = "INSERT INTO M_TB (m_name, m_phone, m_addr, m_age, m_gender," +
                    "m_height, m_weight, m_bmi, m_membership, m_lent, m_pt, m_trainer,m_startday, m_endday)" +
                    " VALUES (@name, @phone, @addr, @age, @gender, @height, @weight, @bmi, @membership, @lent," +
                    "@pt,@trainer, @startday, @endday)";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@bmi", bmi);
                cmd.Parameters.AddWithValue("@membership", membership);
                cmd.Parameters.AddWithValue("@lent", lent);
                cmd.Parameters.AddWithValue("@pt", pt);
                cmd.Parameters.AddWithValue("@trainer", trainer);
                cmd.Parameters.AddWithValue("@startday", startday);
                cmd.Parameters.AddWithValue("@endday", endday);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }

        public static void DB_Delete(string name)
        {
            try
            {

                ConnectDB();

                string sqlcommand = "DELETE FROM M_TB WHERE m_name = @name";

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
            }
        }

        public static void DB_Update(int nowSelectNum, string name, string phone, string address, string age, string gender, string height, string weight,
                                     string bmi, string membership, string lent, string pt, string trainer, string startday, string endday)
        {
            try
            {

                ConnectDB();

                string sqlcommand = "UPDATE M_TB SET m_name=@name, m_phone=@phone, m_addr=@addr, m_age=@age, m_gender=@gender, m_height=@height, m_weight=@weight, " +
                    "m_bmi = @bmi, m_membership=@membership,  m_lent=@lent, m_pt=@pt,m_trainer=@trainer, m_startday=@startday, m_endday = @endday" +
                    " WHERE m_num = @id";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@bmi", bmi);
                cmd.Parameters.AddWithValue("@membership", membership);
                cmd.Parameters.AddWithValue("@lent", lent);
                cmd.Parameters.AddWithValue("@pt", pt);
                cmd.Parameters.AddWithValue("@trainer", trainer);
                cmd.Parameters.AddWithValue("@startday", startday);
                cmd.Parameters.AddWithValue("@endday", endday);
                cmd.Parameters.AddWithValue("@id", nowSelectNum);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }
        }

        public static void DB_Delete_t(string name)
        {
            try
            {
                ConnectDB();

                string sqlcommand = "DELETE FROM T_TB WHERE t_name = @name";

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
            }
        }

        public static void DB_Update_t(int nowSelectNum, string name, string age, string gender, string career)
        {
            try
            {

                ConnectDB();

                string sqlcommand = "UPDATE T_TB SET t_name=@name, t_age=@age, t_gender=@gender, t_career=@career" +
                    " WHERE t_num = @id";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@career", career);
                cmd.Parameters.AddWithValue("@id", nowSelectNum);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.StackTrace);
            }

        }
    }
}

