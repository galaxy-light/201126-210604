package jdbc0226_2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcTest_2 {
	static Connection con;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "test0226";
	
	// 접속 방식
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";	
	static String dbUrl = "jdbc:mysql://localhost/" + // localhost : 루프백 주소
				DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		openDB();
		closeDB();
	}
	
	public static void openDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				System.out.println("DB 접속 성공");
			}			
		} catch (InstantiationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IllegalAccessException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
	}
	
	public static void closeDB() {
		try {
			con.close();
			System.out.println("DB 접속 종료");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
	}
}
