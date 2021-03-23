using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블 + 시퀀스 생성";
        const string DROP_TB_ERR = "테이블 + 시퀀스 삭제";

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
                "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                "User Id=c##scott;Password=1126;";

        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~DaoOracle() // 소멸자
        {
            dbClose(); // 소멸자 : 객체가 파괴될 때 호출됨     
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("접속 에러 : " + e.Message);
                //errorMsg("접속", e);
                errorMsg(CONNECT_ERR, e);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("해제 에러 : " + e.Message);
                //errorMsg("해제", e);
                errorMsg(DISCONNECT_ERR, e);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table testTB (" + "id number not null," + "name varchar(20) not null," +
                                 "age number not null," + "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id increment by 1 start with 1";

                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }            
            catch (OracleException e)
            {
                //Console.WriteLine("에러 : " + e.Message);
                //errorMsg("테이블 + 시퀀스 생성", e);
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + " : 에러 번호" + e.Number);
            //Console.WriteLine(msg + " : 에러 코드" + e.ErrorCode.ToString());
            Console.WriteLine(msg + " : 에러 내용" + e.Message);
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "create table Car_Customer (" + "cu_num int not null," + "cu_nm varchar(20) not null," +
                                 "cu_ph VARCHAR2(20) not null," + "cu_addr VARCHAR2(20) not null," +
                                 "cu_em VARCHAR2(20) not null," + "constraint Car_Customer_pk primary key (cu_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Customer_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Customer 테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러 : " + e.Message);
                //errorMsg("테이블 + 시퀀스 생성", e);
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCar()
        {          
            try
            {
                string query = "create table Car_Car (" + "ca_num int not null," + "ca_mod varchar(20) not null," +
                                 "ca_pri VARCHAR2(20) not null," + "ca_col VARCHAR2(20) not null," +
                                 "ca_com VARCHAR2(20) not null," + "ca_year VARCHAR2(20) not null," +
                                 "constraint Car_Car_pk primary key (ca_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Car_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Car 테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러 : " + e.Message);
                //errorMsg("테이블 + 시퀀스 생성", e);
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "create table Car_Seller (" + "se_num int not null," + "se_nm varchar(20) not null," +
                                 "se_ph VARCHAR2(20) not null," + "se_em VARCHAR2(20) not null," +
                                 "se_ran VARCHAR2(20) not null," + "se_pla VARCHAR2(20) not null," +
                                 "constraint Car_Seller_pk primary key (se_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Seller_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Seller 테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러 : " + e.Message);
                //errorMsg("테이블 + 시퀀스 생성", e);
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbDeal()
        {          
            try
            {
                string query = "create table Car_Deal (" + "de_num int not null," + "de_dat varchar(20) not null," +
                                 "de_senum int not null," + "de_cunum int not null," +                               
                                 "de_carnum int not null," + "de_pri int not null," +
                                 "constraint Car_Deal_pk primary key (de_num)," +
                                 "constraint FK_Car_Deal_de_senum_Car_Seller FOREIGN KEY (de_senum)" +
                                 "REFERENCES Car_Seller(se_num)," +
                                 "constraint FK_Car_Deal_de_carnum_Car_Car FOREIGN KEY (de_carnum)" +
                                 "REFERENCES Car_Car(ca_num)," +
                                 "constraint FK_Car_Deal_de_cunum_Car_Customer FOREIGN KEY(de_cunum)" +
                                 "REFERENCES Car_Customer(cu_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Deal_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Deal 테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러 : " + e.Message);
                //errorMsg("테이블 + 시퀀스 생성", e);
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeAllTB()
        {
            makeTbCar();
            makeTbCustomer();            
            makeTbSeller();
            makeTbDeal(); // 생성할 때는 외래키를 가진 메서드 맨 밑으로
        }

        public void dropAllTB()
        {
            dropTable("Car_Deal", "Car_Deal_seq"); // 삭제할 때는 외래키를 가진 메서드를 맨 위로
            dropTable("Car_Car", "Car_Car_seq");
            dropTable("Car_Customer", "Car_Customer_seq");           
            dropTable("Car_Seller", "Car_Seller_seq");            
        }

        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러: " + e.Message);
                //errorMsg("테이블 + 시퀀스 삭제", e);
                errorMsg(DROP_TB_ERR, e);
            }
        }

        // 오버로딩
        public void dropTable(string tb, string seq)
        {
            try
            {                
                string query = "drop table " + tb; // table과 "" 사이 띄어쓰기 필수(띄어쓰기 안하면 tb와 붙어버림)
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                                
                string querySeq = "drop sequence " + seq; // sequence와 "" 사이 띄어쓰기 필수(띄어쓰기 안하면 seq와 붙어버림)
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러: " + e.Message);
                //errorMsg("테이블 + 시퀀스 삭제", e);
                errorMsg(DROP_TB_ERR, e);
            }
        }
    }
}
