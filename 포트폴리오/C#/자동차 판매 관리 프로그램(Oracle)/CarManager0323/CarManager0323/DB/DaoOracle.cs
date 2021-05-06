using CarManager0323.Model;
using CarManager0331.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle // 여기에 public 붙으면 UI 파일들의 첫 줄에 public 안지워도 됨
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

        public void createTable() // testDB라서 사용X
        {
            try
            {
                string query = "create table testTB (" + "id number not null," + "name varchar(50) not null," +
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
                string query = "create table Car_Customer (" + "cu_num int not null," + "cu_nm varchar(50) not null," +
                                 "cu_ph VARCHAR2(50) not null," + "cu_addr VARCHAR2(50) not null," +
                                 "cu_em VARCHAR2(50) null," + "constraint Car_Customer_pk primary key (cu_num))";
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
                string query = "create table Car_Car (" + "ca_num int not null," + "ca_mod varchar(50) not null," +
                                 "ca_pri int not null," + "ca_col VARCHAR2(50) not null," +
                                 "ca_com VARCHAR2(50) not null," + "ca_year VARCHAR2(50) not null," +
                                 "constraint Car_Car_pk primary key (ca_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Car_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Car 테이블, 시퀀스 생성 성공");
                //System.Windows.Forms.MessageBox.Show("Car 테이블, 시퀀스 생성 성공");
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
                string query = "create table Car_Seller (" + "se_num int not null," + "se_nm varchar(50) not null," +
                                 "se_ph VARCHAR2(50) not null," + "se_em VARCHAR2(50) not null," +
                                 "se_ran VARCHAR2(50) not null," + "se_pla VARCHAR2(50) not null," +
                                 "constraint Car_Seller_pk primary key (se_num))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence Car_Seller_seq increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Seller 테이블, 시퀀스 생성 성공");
                //System.Windows.Forms.MessageBox.Show("Seller 테이블, 시퀀스 생성 성공");
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
                                 "de_carnum int not null," + "constraint Car_Deal_pk primary key (de_num)," +
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
                //System.Windows.Forms.MessageBox.Show("Deal 테이블, 시퀀스 생성 성공");
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
            //createTable(); // TestDB라서 사용X
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
                //System.Windows.Forms.MessageBox.Show("테이블, 시퀀스 삭제 성공");
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
                //System.Windows.Forms.MessageBox.Show("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                //Console.WriteLine("에러: " + e.Message);
                //errorMsg("테이블 + 시퀀스 삭제", e);
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void insertCar(Car car) // car 매개 변수를 받는 메서드
        {
            try
            {
                //string sql = "insert into Car_Car values (Car_Car_seq.nextval, '그랜저', '40000000', '은색', '현대', '2021년')";
                string sql = string.Format("insert into Car_Car values (Car_Car_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}')",
                    car.Ca_mod, car.Ca_pri, car.Ca_col, car.Ca_com, car.Ca_year);
                // {0}', '{1}', '{2}', '{3}', '{4}')", car.Ca_mod, car.Ca_pri, car.Ca_col, car.Ca_com, car.Ca_year : 치환
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch(OracleException e)
            {
                errorMsg("insetCar()", e);
            }
        }

        public void insertSeller()
        {
            try
            {
                string sql = "insert into Car_Seller values (Car_Seller_seq.nextval, '김철수', '010-1111-1111', 'kim@gmail.com', '대리', '동대구영업소')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }

        public void insertSeller(Seller sel) // sel 매개 변수를 받는 메서드
        {
            try
            {
                //string sql = "insert into Car_Seller values (Car_Seller_seq.nextval, '김철수', '010-1111-1111', 'kim@gmail.com', '대리', '동대구영업소')";
                string sql = string.Format("insert into Car_Seller values (Car_Seller_seq.nextval, '{0}', '{1}', '{2}', '{3}', '{4}')",
                    sel.Se_nm, sel.Se_ph, sel.Se_em, sel.Se_ran, sel.Se_pla);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }


        public void insertCustomer()
        {
            try
            {
                string sql = "insert into Car_Customer values (Car_Customer_seq.nextval, '김순자', '010-1478-5236', '대구 동구 신천2동', 'sunja@naver.com')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertCustomer(Customer cus) // cus 매개 변수를 받는 메서드
        {
            try
            {
                //string sql = "insert into Car_Customer values (Car_Customer_seq.nextval, '김순자', '010-1478-5236', '대구 동구 신천2동', 'sunja@naver.com')";
                string sql = string.Format("insert into Car_Customer values (Car_Customer_seq.nextval, '{0}', '{1}', '{2}', '{3}')",
                    cus.Cu_nm, cus.Cu_ph, cus.Cu_addr, cus.Cu_em);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }

        public void insertDeal()
        {
            try
            {
                string sql = "insert into Car_Deal (de_num, de_dat, de_senum, de_cunum, de_carnum) " +
                    "(select Car_Deal_seq.nextval, sysdate, " +
                    "se.se_num, cu.cu_num, ca.ca_num " +
                    "from Car_Seller se natural join Car_Customer cu " +
                    "natural join Car_Car ca " +
                    "where cu.cu_nm='김순자' and ca.ca_mod='그랜저' " +
                    "and se.se_nm ='김철수')";                    
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public void insertDeal(Deal deal)
        {
            try
            {
                string sql = string.Format("insert into Car_Deal (de_num, de_dat, de_senum, de_cunum, de_carnum) " +
                    "(select Car_Deal_seq.nextval, sysdate, " +
                    "se.se_num, cu.cu_num, ca.ca_num " +
                    "from Car_Seller se natural join Car_Customer cu " +
                    "natural join Car_Car ca " +
                    "where cu.cu_nm='{0}' and ca.ca_mod='{1}' " +
                    "and se.se_nm='{2}')", // {0}, {1}, {2} <= deal.Customer.Cu_nm, deal.Car.Ca_mod, deal.Seller.Se_nm : 매개 변수로 넘겨 받음
                    deal.Customer.Cu_nm,
                    deal.Car.Ca_mod,
                    deal.Seller.Se_nm);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        // 오버로딩
        public void insertDeal(Customer cus, Car car, Seller sel)
        {
            try
            {
                string sql = string.Format("insert into Car_Deal values (Car_Deal_seq.nextval, sysdate, " +
                    "(select cu_num from Car_Customer where cu_nm = '{0}' and cu_ph='{1}'), " +
                    "(select ca_num from Car_Car where ca_mod = '{2}' and ca_pri='{3}'), " +
                    "(select se_num from Car_Seller where se_nm = '{4}' and se_ph = '{5}'))",
                    cus.Cu_nm, cus.Cu_ph,
                    car.Ca_mod, car.Ca_pri,
                    sel.Se_nm, sel.Se_ph);                     
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }

        public List<DealResult> selectDeal()
        {
            List<DealResult> dResultList = new List<DealResult>();
            
            try
            {
                int count = 1;
                string query = "select cu.cu_nm, ca.ca_mod, ca.ca_pri, se.se_nm, d.de_dat " +
                    "from Car_Deal d, Car_Car ca, Car_Customer cu, Car_Seller se " +
                    "where d.de_carnum = ca.ca_num and d.de_cunum = cu.cu_num and d.de_num = se.se_num";
                                
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("번호 : " + count);
                        Console.WriteLine("고객명 : " + reader["cu_nm"]);
                        Console.WriteLine("차량 모델 : " + reader["ca_mod"]);
                        string price = reader["ca_pri"].ToString();
                        double dPrice = Convert.ToDouble(price);
                        NumberFormatInfo numFormat = new CultureInfo("ko-KR", false).NumberFormat;
                        price = dPrice.ToString("c", numFormat);
                        Console.WriteLine("가격 : " + price);
                        Console.WriteLine("판매자명 : " + reader["se_nm"]);                        
                        Console.WriteLine("구매 날짜 : " + reader["de_dat"]);
                        Console.WriteLine("----------------------------");
                        DealResult dResult = new DealResult(count,
                            reader["cu_nm"].ToString(),
                            reader["ca_mod"].ToString(),
                            price,
                            reader["se_nm"].ToString(),
                            reader["de_dat"].ToString());
                        dResultList.Add(dResult);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                    return null;
                }
                reader.Close();
            }
            catch(OracleException e)
            {
                errorMsg("selectDeal()", e); // selectDeal() 안에서의 오류 출력
            }
            return dResultList; // 데이터 개수가 많다면 이 방법(리턴)말고 다른 방법을 써야함
        }
    }
}
