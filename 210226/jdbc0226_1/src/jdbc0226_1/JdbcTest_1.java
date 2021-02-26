package jdbc0226_1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JdbcTest_1 {
	static Connection con; // import(java.sql)
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";
	
	// 접속 방식
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";	
	static String dbUrl = "jdbc:mysql://localhost/" + // localhost : 루프백 주소
			DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	
	// 프로젝트 속성-라이브러리-classpath-외부 라이브러리 추가
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		connectDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver).newInstance(); // try/catch
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW); // 인스턴스 생성 / surrounding try
			if (con != null) { // con != null : 정상적으로 접속이 이루어졌음
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
			/*
			 * // 이 조건식은 con이 null이면 오류 처리가 발생하지 않는 문제가 있음
			 * if (con != null) { // con != null : 객체에 정보가 들어있음(접속이 이루어짐) 
			 * con.close(); // try/catch
			 * }
			 */			
			con.close(); // 오류 해결을 위해 이렇게 사용
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
