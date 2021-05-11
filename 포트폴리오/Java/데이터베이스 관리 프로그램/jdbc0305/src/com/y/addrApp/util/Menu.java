package com.y.addrApp.util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

import com.y.addrApp.model.AddrBook;

public class Menu {
	// static : 객체가 여러 번 생성되어지더라도 한번만 만들어짐 -> 공통, 공용으로 쓸 수 있는 것들만 static으로 지정 / 싱글톤도 static
//	static final int MAIN_TABLE_CREATE = 1;
//	static final int MAIN_TABLE_DROP = 2;
//	static final int MAIN_DATA_ADD = 3;
//	static final int MAIN_RANDOM_DATA_ADD = 4;
//	static final int MAIN_DATA_SHOW = 5;
//	static final int MAIN_DATA_UPDATE = 6;
//	static final int MAIN_DATA_DEL = 7;
//	static final int MAIN_EXIT = 8;
	
	public static final int MAIN_TABLE_CREATE = 1;
	public static final int MAIN_TABLE_DROP = 2;
	public static final int MAIN_DATA_ADD = 3;
	public static final int MAIN_RANDOM_DATA_ADD = 4;
	public static final int MAIN_DATA_SHOW = 5;
	public static final int MAIN_DATA_UPDATE = 6;
	public static final int MAIN_DATA_DEL = 7;
	public static final int MAIN_EXIT = 8;
	
	// 메인 메뉴
	public int mainMenu(Scanner s) { // Scanner s : 매개 변수
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
	
	// 서브 메뉴(데이터 추가)
	public AddrBook addMenu(Scanner s) { // Addrbook : 타입 / Scanner s : 매개 변수
		System.out.println("-------------");
		System.out.println("데이터 추가 메뉴");
		System.out.println("-------------");
		System.out.print("이름 : ");
		String name = s.next();
		System.out.print("나이 : ");
		int age = s.nextInt();
		System.out.print("번호 : ");
		String tel = s.next();
		// 스페이스바 오류 해결
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		System.out.print("주소 : ");
		String address = null;
		try {
			address = br.readLine();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.print("이메일 : ");
		String email = s.next();
		return new AddrBook(name, age, tel, address, email); // 객체를 생성해서 리턴
	}
	
	// 서브 메뉴(데이터 수정)
	public int updateMenu(Scanner s) {
		System.out.println("-------------");
		System.out.println("데이터 수정 메뉴");
		System.out.println("-------------");
		System.out.println("1. 이름");
		System.out.println("2. 나이");
		System.out.println("3. 번호");
		System.out.println("4. 주소");
		System.out.println("5. 이메일");
		System.out.print("메뉴 선택 : ");	
		return s.nextInt();
	}	
	
	public int delMenu(Scanner s) {
		System.out.println("-------------");
		System.out.println("데이터 삭제 메뉴");
		System.out.println("-------------");		
		System.out.println("1. 이름");
		System.out.println("2. 나이");
		System.out.println("3. 번호");
		System.out.println("4. 주소");
		System.out.println("5. 이메일");
		System.out.print("메뉴 선택 : ");	
		return s.nextInt();
	}
}
