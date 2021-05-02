using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL_Test_01
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection(); // 빈 객체 생성
        //public SqlConnection conn; // 안되는 이유는 빈 객체를 생성 안한 상태에서 객체에 정보를 넣을 수 없기 때문

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectDB() // DB연결시 사용할 객체 및 함수선언
        {
            conn.ConnectionString = string.Format("Data Source=({0}); " +
                "Initial Catalog = {1};" +
                "Integrated Security = {2};" +
                "Timeout = 3",
                "local", "Test_01", "SSPI");

            //conn.ConnectionString = $"Data Source = ({"local"}); Initial Catalog = {"Test_01"}; Timeout = 3"; // 윗 줄 대신 사용 가능
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Query_Select();
        }

        private void Query_Select()
        {
            ConnectDB();

            // SQL 명령어 선언
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Table_1";

            // DataAdapter와 DataSet으로 DB Table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); // select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "Table_1"); // SELECT * FROM temp_id의 결과가 da에 입력됨

            // dataGridView에 DB에서 가져온 데이터 입력하기
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Table_1";
            conn.Close(); // 연결 해제
        }

        private void Query_Insert()
        {
            ConnectDB();
            string sqlcommand = "Insert Into Table_1 (temp_id, temp_name, temp_age, temp_address) values" +
                " (@parameter1, @parameter2, @parameter3, @parameter4)";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            // Column명은 별도의 파라메터 형태로 선언함
            // SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예 : +나 ' 기호를 이용한 공격
            cmd.Parameters.AddWithValue("@parameter1", textBox1.Text);
            cmd.Parameters.AddWithValue("@parameter2", textBox2.Text);
            cmd.Parameters.AddWithValue("@parameter3", textBox3.Text);
            cmd.Parameters.AddWithValue("@parameter4", textBox4.Text);
            cmd.CommandText = sqlcommand;
            cmd.ExecuteNonQuery(); // 쿼리 실행
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query_Insert(); // 테이블에 입력한 데이터 추가
            Query_Select(); // 추가된 데이터가 포함된 테이블 출력
        }
    }
}
