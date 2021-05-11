package com.y.addrApp;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Random;
import java.util.Scanner;

import com.y.addrApp.dao.MySQLHandler;
import com.y.addrApp.model.AddrBook;
import com.y.addrApp.util.Menu;
import com.y.addrApp.util.RandData;

public class AddrBookMain {	
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);	
		MySQLHandler db = new MySQLHandler(); // 객체 생성
//		db.openDB();
		Menu nu = new Menu();
				
		while (true) {
			switch (nu.mainMenu(s)) { // s : 매개 변수
			case Menu.MAIN_TABLE_CREATE:
				System.out.println("테이블 생성");
				db.createTB();
				break;
			case Menu.MAIN_TABLE_DROP:
				System.out.println("테이블 삭제");
				db.dropTB();
				break;
			case Menu.MAIN_DATA_ADD:
				System.out.println("데이터 추가");
//				db.dataAdd(s);
//				AddrBook addr = nu.addMenu(s);
				db.addData(nu.addMenu(s));				
				break;
			case Menu.MAIN_RANDOM_DATA_ADD:
				System.out.println("랜덤 데이터 추가");	
				System.out.print("랜덤 횟수 : ");
				int loof = s.nextInt();
				RandData rd = new RandData();				
				for (int i = 0; i < loof; i++) {
					db.addData(rd.getABook());
				}
				break;
			case Menu.MAIN_DATA_SHOW:
				System.out.println("데이터 보기");
				db.showDB();
				break;
			case Menu.MAIN_DATA_UPDATE:
				System.out.println("데이터 수정");
				db.updateData(nu.updateMenu(s), s);
				break;
			case Menu.MAIN_DATA_DEL:
				System.out.println("데이터 삭제");
				db.dropData(nu.delMenu(s), s);
				break;
			case Menu.MAIN_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				db.closeDB();
				break;			
			}
		}
	}	
}
