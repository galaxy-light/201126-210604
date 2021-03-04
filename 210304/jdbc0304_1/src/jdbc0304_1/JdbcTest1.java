package jdbc0304_1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JdbcTest1 {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";
	
	// 접속 방식
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";	
	static String dbUrl = "jdbc:mysql://localhost/" + // localhost : 루프백 주소
				DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		openDB();
		insertDB();
		showDB();
		closeDB();		
	}
	
	public static void openDB() {
		try {
			Class.forName(jdbcDriver).newInstance();
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
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
			state.close();
			con.close();
			System.out.println("DB 접속 종료");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
	}
	
	public static void insertDB() {
		String query1 = "insert into t_user values" + "(0, '홍길동', 100, 'honghong@naver.com', '010-1478-5236', '조선 한양', now())";
		
		String name = "전우치";
		int age = 200;
		String email = "jeon@daum.net";
		String tel = "010-8546-1354";
		String addr = "조선 두메산골";
		String query2 = String.format("insert into t_user(user_nm, user_age, email, user_phone, user_address)"
				+ "values('%s', %d, '%s', '%s', '%s')", name, age, email, tel, addr);
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		
	}
	
	public static void showDB() {
		String query = "select * from t_user";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print(count+"\t");
					System.out.print(rs.getString("user_nm") + "\t");
					System.out.print(rs.getString("user_age") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.print(rs.getString("user_phone") + "\t");
					System.out.print(rs.getString("user_address") + "\t");
					System.out.println(rs.getString("r_dt")); // System.out.println(rs.getString(6)); 동일하게 쓸 수 있음(인덱스로도 처리 가능)
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
