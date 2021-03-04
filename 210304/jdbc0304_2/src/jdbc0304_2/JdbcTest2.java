package jdbc0304_2;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Random;
import java.util.Scanner;

public class JdbcTest2 {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb2";
	
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";	
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	static final int MAIN_TABLE_CREATE = 1;
	static final int MAIN_TABLE_DROP = 2;
	static final int MAIN_DATA_ADD = 3;
	static final int MAIN_RANDOM_DATA_ADD = 4;
	static final int MAIN_DATA_SHOW = 5;
	static final int MAIN_DATA_UPDATE = 6;
	static final int MAIN_DATA_DEL = 7;
	static final int MAIN_EXIT = 8;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		openDB();
		while (true) {
			switch (menu(s)) { // s : 매개 변수
			case MAIN_TABLE_CREATE:
				System.out.println("테이블 생성");
				createTB();
				break;
			case MAIN_TABLE_DROP:
				System.out.println("테이블 삭제");
				dropTB();
				break;
			case MAIN_DATA_ADD:
				System.out.println("데이터 추가");
				dataAdd();
				break;
			case MAIN_RANDOM_DATA_ADD:
				System.out.println("랜덤 데이터 추가");
				
				break;
			case MAIN_DATA_SHOW:
				System.out.println("데이터 보기");
				showDB();
				break;
			case MAIN_DATA_UPDATE:				
				break;
			case MAIN_DATA_DEL:				
				break;
			case MAIN_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				closeDB();
				break;			
			}
		}
	}
	
	public static int menu(Scanner s) { // Scanner s : 매개 변수
		System.out.println("------------------------");
		System.out.println("MySQL DB 관리 프로그램 v1.0");
		System.out.println("------------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 랜덤 데이터 추가");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 프로그램 종료");
		System.out.println("------------------------");
		System.out.print("메인 메뉴 선택 : ");
//		int menu = s.nextInt();
//		return menu;
		return s.nextInt();
	}
	
	// DB 연결
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
	
	// DB 연결 해제
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
	
	// 테이블 생성
	public static void createTB() {		
		// NOT NULL : 개체 무결성(무결성 = 정확성)
		String query = "create table addrbook("
				+ "id INT(10) NOT NULL AUTO_INCREMENT,"
				+ "name VARCHAR(10) NOT NULL,"
				+ "age INT(3) NOT NULL,"
				+ "tel VARCHAR(20) NOT NULL,"
				+ "address VARCHAR(40) NOT NULL,"
				+ "email VARCHAR(20) NULL,"
				+ "date DATETIME NOT NULL,"
				+ "PRIMARY KEY(id))";		
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
			// 에러 예외 처리
//			if (e.getErrorCode() == 1050) {
//				// System.out.println(e.getMessage());
//				System.out.println("테이블이 이미 존재합니다.");
//			}
			
			// e.printStackTrace(); // 이것도 하나의 에러 확인 장치
			/*
			 * // 에러 확인법
			 * System.out.println(e.getSQLState());
			 * System.out.println(e.getMessage());
			 * System.out.println(e.getErrorCode());
			 * System.out.println(e.getCause().toString());
			 */			
		}
	}
	
	// 테이블 삭제
	public static void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
//			if (e.getErrorCode() == 1051) {
//				System.out.println("삭제할 테이블이 존재하지 않습니다.");
//			}			
			/*
			 * e.printStackTrace();
			 * System.out.println(e.getSQLState());
			 * System.out.println(e.getMessage());
			 * System.out.println(e.getErrorCode());
			 * System.out.println(e.getCause().toString());
			 */			
		}
	}
	
	// 데이터 추가
	public static void dataAdd() {
		String query1 = "insert into addrbook values" + "(0, '홍길동', 30, '010-1478-5236', '서울', 'hong@naver.com', now())";
		String query2 = "insert into addrbook values" + "(0, '김길동', 27, '010-4467-7869', '광양', 'kim@naver.com', now())";
		String query3 = "insert into addrbook values" + "(0, '이길동', 39, '010-6454-4319', '제주', 'lee@naver.com', now())";
		String query4 = "insert into addrbook values" + "(0, '박길동', 21, '010-0483-9742', '울릉', 'park@naver.com', now())";
		String query5 = "insert into addrbook values" + "(0, '최길동', 35, '010-1984-4632', '강릉', 'choi@naver.com', now())";
		
//		String[] conv = new String[5];
//		for (int i = 0; i < conv.length; i++) {
//			conv[0] = query1;
//			conv[1] = query2;
//			conv[2] = query3;
//			conv[3] = query4;
//			conv[4] = query5;			
//		}
		
		try {
			state.executeUpdate(query1);
			state.executeUpdate(query2);
			state.executeUpdate(query3);
			state.executeUpdate(query4);
			state.executeUpdate(query5);
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println(e.getSQLState());
			System.out.println(e.getMessage());
			System.out.println(e.getErrorCode());
			System.out.println(e.getCause().toString());
		}		
	}
	
	// 랜덤 데이터 추가	
	public static void randdataAdd(Scanner s) {
		Random r = new Random();
		String[] a1 = { "1", "2", "3", "4", "5" };
		String[] a2 = { "우길동", "강길동", "추길동", "현길동", "서길동" };
		String[] a3 = { "10", "20", "30", "40", "50" };
		String[] a4 = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555"};
		String[] a5 = { "대구", "춘천", "목포", "파주", "창원"};
		String[] a6 = { "uu@naver.com", "kang@daum.net" , "chu@gmail.com", "heon@naver.com", "seo@gmail.com" };
				
		for (int i = 0; i < a1.length; i++) {
			String re;
//			re.new randdataAdd(a1[r.nextInt(5)], a2[r.nextInt(5)], a3[r.nextInt(5)], a4[r.nextInt(5)], a5[r.nextInt(5)]);
		}
	}
	
	// 데이터 보기
	public static void showDB() {
		String query = "select * from addrbook";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					// System.out.print(count+"\t");
					System.out.print(rs.getString("id") + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString(7)); // System.out.println(rs.getString(7)); 동일하게 쓸 수 있음(인덱스로도 처리 가능)
					count++;
				}
				rs.close();
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	// 데이터 수정
	public static void updateData(Scanner s) {
		String query = "select * from addrbook";
		System.out.println("데이터 수정");
		System.out.println("1. 이름");
		System.out.println("2. 나이");
		System.out.println("3. 번호");
		System.out.println("4. 주소");
		System.out.println("5. 이메일");
		System.out.print("메뉴 선택 : ");
		int choo = s.nextInt();
		
		String ex;
		String re;
		
		while (true) {
			if (choo == 1) {				
				System.out.print("변경 이름 : ");
				ex = s.next();
				System.out.print("수정 이름 : ");
				re = s.next();
			
			}
			else if (choo == 2) {				
				System.out.print("변경 나이 : ");
				ex = s.next();
				System.out.print("수정 나이 : ");
				re = s.next();

			}
			else if (choo == 3) {				
				System.out.print("변경 번호 : ");
				ex = s.next();
				System.out.print("수정 번호 : ");
				re = s.next();
				
			}
			else if (choo == 4) {				
				System.out.print("변경 주소 : ");
				ex = s.next();
				System.out.print("수정 주소 : ");
				re = s.next();
				
			}
			else if (choo == 5) {				
				System.out.print("변경 이메일 : ");
				ex = s.next();
				System.out.print("수정 이메일 : ");
				re = s.next();
				
			}
			
		}
	}
	
	// 데이터 삭제
		public static void dropData() {
			String query = "drop data addrbook";
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();		
			}
		}
	
	// 예외 처리
	public static void checkError(SQLException e) { // SQLException e : 매개 변수
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재합니다.");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않습니다.");
			break;
		}
	}
}
