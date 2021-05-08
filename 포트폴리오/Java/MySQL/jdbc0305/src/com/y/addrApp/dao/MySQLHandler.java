package com.y.addrApp.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

import com.y.addrApp.model.AddrBook;
import com.y.addrApp.util.Menu;
import com.y.addrApp.util.RandData;

public class MySQLHandler {
	ArrayList<AddrBook> list = new ArrayList<AddrBook>();
	
	// 인스턴스 메서드, 변수는 반드시 객체를 생성해야 되고 클래스 메서드, 변수는 객체를 생성하지 않아도 사용이 가능함
//	static Connection con;
//	static Statement state;	
	Connection con;
	Statement state;

	// 클래스 변수(static)
//	static final String USER_ID = "root";
//	static final String USER_PW = "1126";
//	static final String DBNAME = "mydb2";		

	// 인스턴스 변수
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "mydb2";

//	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
//	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";

	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	Menu nu;

	public MySQLHandler() {
		openDB(); // 캡슐화
	}

	// 외부에 노출할 필요가 없으면 메서드 앞에 public이 아니라 private를 사용

	// DB 연결
	public void openDB() {
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
	public void closeDB() {
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
	public void createTB() {
		// NOT NULL : 개체 무결성(무결성 = 정확성)
//		String query = "create table addrbook(" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NOT NULL,"
//				+ "age INT(3) NOT NULL," + "tel VARCHAR(20) NOT NULL," + "address VARCHAR(40) NOT NULL,"
//				+ "email VARCHAR(20) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";
		String query = "create table addrbook(" + "id INT(10) NOT NULL AUTO_INCREMENT," + "name VARCHAR(10) NULL,"
				+ "age INT(3) NULL," + "tel VARCHAR(20) NULL," + "address VARCHAR(40) NULL,"
				+ "email VARCHAR(20) NULL," + "date DATETIME NOT NULL," + "PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
			// 에러 예외 처리
//				if (e.getErrorCode() == 1050) {
//					// System.out.println(e.getMessage());
//					System.out.println("테이블이 이미 존재합니다.");
//				}

			e.printStackTrace(); // 이것도 하나의 에러 확인 장치

			// 다른 에러 확인법
//			System.out.println(e.getSQLState());
//			System.out.println(e.getMessage());
//			System.out.println(e.getErrorCode());
//			System.out.println(e.getCause().toString());			 
		}
	}

	// 테이블 삭제
	public void dropTB() {
		String query = "drop table addrbook";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			checkError(e);
//				if (e.getErrorCode() == 1051) {
//					System.out.println("삭제할 테이블이 존재하지 않습니다.");
//				}		
			e.printStackTrace();
//			System.out.println(e.getSQLState());
//			System.out.println(e.getMessage());
//			System.out.println(e.getErrorCode());
//			System.out.println(e.getCause().toString());
		}
	}

	// 데이터 추가
	public void addData(Scanner s) {
		String query1 = "insert into t_user values"
				+ "(0, '홍길동', 100, '010-1478-5236', '조선 한양', 'honghong@naver.com', now())";

		String name = "전우치";
		int age = 200;
		String tel = "010-8546-1354";
		String address = "조선 두메산골";
		String email = "jeon@daum.net";
		String query2 = String.format( // String.format : printf와 동일하게 쓰임(%@이런 식으로 쓸 때 사용)
				"insert into addrbook(id, name, age, tel, address, email, date)" + "values('%s', %d, '%s', '%s', '%s')",
				name, age, tel, address, email);
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
//			System.out.println(e.getSQLState());
//			System.out.println(e.getMessage());
//			System.out.println(e.getErrorCode());
//			System.out.println(e.getCause().toString());
			checkError(e);
		}
//		System.out.print("이름 :  ");
//		String name = s.next();
//		System.out.print("나이 : ");
//		int age = s.nextInt();
//		System.out.print("번호 : ");
//		String tel = s.next();
//		System.out.print("주소 : ");
//		String address = s.next();
//		System.out.print("이메일 : ");
//		String email = s.next();
//
//		System.out.println("이름 : " + name);
//		System.out.println("나이 : " + age);
//		System.out.println("번호 : " + tel);
//		System.out.println("주소 : " + address);
//		System.out.println("이메일 : " + email);
//
//		String query1 = String.format("insert into addrbook(id, name, age, tel, address, email, date)"
//				+ "values(0,'%s',%d,'%s','%s','%s',now())", name, age, tel, address, email);
//		try {
//			state.executeUpdate(query1);
//		} catch (SQLException e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}
//		System.out.println("데이터 추가 완료");

//		String query1 = "insert into addrbook values" + "(0, '홍길동', 30, '010-1478-5236', '서울', 'hong@naver.com', now())"; 
//		String query2 = "insert into addrbook values" + "(0, '김길동', 27, '010-4467-7869', '광양', 'kim@naver.com', now())"; 
//		String query3 = "insert into addrbook values" + "(0, '이길동', 39, '010-6454-4319', '제주', 'lee@naver.com', now())"; 
//		String query4 = "insert into addrbook values" + "(0, '박길동', 21, '010-0483-9742', '울릉', 'park@naver.com', now())"; 
//		String query5 = "insert into addrbook values" + "(0, '최길동', 35, '010-1984-4632', '강릉', 'choi@naver.com', now())";

//			String[] conv = new String[5];
//			for (int i = 0; i < conv.length; i++) {
//				conv[0] = query1;
//				conv[1] = query2;
//				conv[2] = query3;
//				conv[3] = query4;
//				conv[4] = query5;			
//			}

//		 try { state.executeUpdate(query1); state.executeUpdate(query2);
//		 state.executeUpdate(query3); state.executeUpdate(query4);
//		 state.executeUpdate(query5); } catch (SQLException e) { e.printStackTrace();
//		 System.out.println(e.getSQLState());
//		 System.out.println(e.getMessage());
//		 System.out.println(e.getErrorCode());
//		 System.out.println(e.getCause().toString());
	}

	// 오버로딩
	public void addData(AddrBook ab) {
		String query2 = String.format(
				"insert into addrbook(id, name, age, tel, address, email, date)"
						+ "values(0, '%s', %d, '%s', '%s', '%s', now())",
				ab.getName(), ab.getAge(), ab.getTel(), ab.getAddress(), ab.getEmail());
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
//			System.out.println(e.getSQLState());
//			System.out.println(e.getMessage());
//			System.out.println(e.getErrorCode());
//			System.out.println(e.getCause().toString());
			checkError(e);
		}
	}

	// 데이터 보기
	public void showDB() {
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
			
			checkError(e);
		}
	}

	// 데이터 수정
	public void updateData(int updateMenu, Scanner s) {
		String query = "select * from addrbook";		
		String ex;
		String re;
		int exage;
		int reage;		
		
		if (updateMenu == 1) {
			System.out.print("변경 이름 : ");
			ex = s.next();
			System.out.print("수정 이름 : ");
			re = s.next();
//			for (int i = 0; i < list.size(); i++) {
//				if (rdd.getName().equals(ex)) {
//					list.get(3).setName(re);
//				}				
//			}
		String query3 = String.format("update addrbook set name='%s' where name='%s'", re, ex);
		try {
			state.executeUpdate(query3);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			}
		System.out.println("이름 수정 완료");
		} else if (updateMenu == 2) {
			System.out.print("변경 나이 : ");
			exage = s.nextInt();
			System.out.print("수정 나이 : ");
			reage = s.nextInt();
			String query3 = String.format("update addrbook set age='%d' where age='%d'", reage, exage);
			try {
				state.executeUpdate(query3);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			System.out.println("나이 수정 완료");
		} else if (updateMenu == 3) {
			System.out.print("변경 번호 : ");
			ex = s.next();
			System.out.print("수정 번호 : ");
			re = s.next();
			String query3 = String.format("update addrbook set tel='%s' where tel='%s'", re, ex);
			try {
				state.executeUpdate(query3);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			System.out.println("번호 수정 완료");
		} else if (updateMenu == 4) {
			System.out.print("변경 주소 : ");
			ex = s.next();
			System.out.print("수정 주소 : ");
			re = s.next();
			String query3 = String.format("update addrbook set address='%s' where address='%s'", re, ex);
			try {
				state.executeUpdate(query3);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			System.out.println("주소 수정 완료");
		} else if (updateMenu == 5) {
			System.out.print("변경 이메일 : ");
			ex = s.next();
			System.out.print("수정 이메일 : ");
			re = s.next();
			String query3 = String.format("update addrbook set email='%s' where email='%s'", re, ex);
			try {
				state.executeUpdate(query3);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
			System.out.println("이메일 수정 완료");
		}
	}

	// 데이터 삭제
	public void dropData(int delMenu, Scanner s) {
		String dela;		
		int delt;		
	
		if (delMenu == 1) {
			System.out.print("삭제 이름 : ");
			dela = s.next();
			String query4 = String.format("delete from addrbook WHERE name = '%s'", dela);
			try {
				state.executeUpdate(query4);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
		}
		else if (delMenu == 2) {
			System.out.print("삭제 나이 : ");
			delt = s.nextInt();
			String query4 = String.format("delete from addrbook WHERE age = '%d'", delt);
			try {
				state.executeUpdate(query4);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
			System.out.println("데이터 삭제 완료");
		}
		else if (delMenu == 3) {
			System.out.print("삭제 번호 : ");
			dela = s.next();
			String query4 = String.format("delete from addrbook WHERE tel = '%s'", dela);
			try {
				state.executeUpdate(query4);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
			System.out.println("데이터 삭제 완료");
		}
		else if (delMenu == 4) {
			System.out.print("삭제 주소 : ");
			dela = s.next();
			String query4 = String.format("delete from addrbook WHERE address = '%s'", dela);
			try {
				state.executeUpdate(query4);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
			System.out.println("데이터 삭제 완료");
		}
		else if (delMenu == 5) {
			System.out.print("삭제 이메일 : ");
			dela = s.next();
			String query4 = String.format("delete from addrbook WHERE email = '%s'", dela);
			try {
				state.executeUpdate(query4);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
//				System.out.println(e.getSQLState());
//				System.out.println(e.getMessage());
//				System.out.println(e.getErrorCode());
//				System.out.println(e.getCause().toString());
				checkError(e);
			}
			System.out.println("데이터 삭제 완료");
		}					
	}

	// 예외 처리
	public void checkError(SQLException e) { // SQLException e : 매개 변수
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("테이블이 이미 존재합니다.");
			break;
		case 1051:
			System.out.println("삭제할 테이블이 존재하지 않습니다.");
			break;
		case 1146:
			System.out.println("데이터가 존재하지 않습니다.");
		}
	}	
}
