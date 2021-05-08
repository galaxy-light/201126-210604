package com.y.serialApp.util;

import java.util.Scanner;

public class Menu {
	// 로그인 메뉴
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";
	public static final String ADMIN_MODE = "admin_mode";
	public static final String GUEST_MODE = "guest_mode";
	public static final String OTHER_MODE = "other_mode";

	// 관리자 메뉴
	public static final int MENU_TV_ON = 1;
	public static final int MENU_TV_OFF = 2;
	public static final int MENU_HEATER_ON = 3;
	public static final int MENU_CLEANER_ON = 4;
	public static final int MENU_EMARGENCY = 5;
	public static final int MENU_ADMIN_LOGOUT = 6;
	public static final int MENU_ADMIN_EXIT = 7;

	// 사용자 메뉴
	public static final int MENU_GUEST_LOGOUT = 5;
	public static final int MENU_GUEST_EXIT = 6;

	// 시리얼 메뉴
	public static final int CMD_TV_ON = '1';
	public static final int CMD_TV_OFF = '2';
	public static final int CMD_HEATER_ON = '3';
	public static final int CMD_CLEANER_ON = '4';

	Scanner s;
	
	public String login(Scanner s) {
		System.out.println("-----------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("-----------------");
		System.out.print("ID: ");
		String id = s.next();
		System.out.print("PW: ");
		String passwd = s.next();
		String mode;

		if (id.equals(ADMIN_ID) && passwd.equals(ADMIN_PW)) {
			mode = ADMIN_MODE;
		} else if (id.equals(GUEST_ID) && passwd.equals(GUEST_PW)) {
			mode = GUEST_MODE;
		} else {
			mode = OTHER_MODE;
		}
		return mode;
	}	

	public int adminMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("스마트홈 제어 관리자");
		System.out.println("------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급 정지");
		System.out.println("6. 관리자 로그아웃");
		System.out.println("7. 종료");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		int menu = 0;
		menu = s.nextInt();
		return menu;
	}

	public int guestMenu(Scanner s) {
		System.out.println("------------------");
		System.out.println("스마트홈 제어 사용자");
		System.out.println("------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 사용자 로그아웃");
		System.out.println("6. 종료");
		System.out.println("------------------");
		System.out.print("메뉴 선택: ");
		int menu = 0;
		menu = s.nextInt();
		return menu;
	}
}
