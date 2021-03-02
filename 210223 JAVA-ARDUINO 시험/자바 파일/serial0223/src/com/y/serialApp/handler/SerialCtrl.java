package com.y.serialApp.handler;

import com.y.serialApp.network.Myserial;
import com.y.serialApp.util.Menu;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;

public class SerialCtrl {
	Menu log = new Menu();
	Scanner s;
	
	public boolean adminWork(Scanner s, SerialPort serial) {
		switch (log.adminMenu(s)) {
		case Menu.MENU_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(log.CMD_TV_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case Menu.MENU_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(log.CMD_TV_OFF);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case Menu.MENU_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(log.CMD_HEATER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case Menu.MENU_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(log.CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case Menu.MENU_EMARGENCY:
			System.out.println("긴급 정지");
			try {
				serial.closePort();
			} catch (SerialPortException e) {
				e.printStackTrace();
			}
			break;
		case Menu.MENU_ADMIN_LOGOUT:
			System.out.println("관리자 로그아웃");
			return false;
		case Menu.MENU_ADMIN_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}

	public boolean guestWork(Scanner s, SerialPort serial) {
		switch (log.guestMenu(s)) {
		case Menu.MENU_TV_ON:
			System.out.println("TV 켜기");
			try {
				serial.writeInt(log.CMD_TV_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case Menu.MENU_TV_OFF:
			System.out.println("TV 끄기");
			try {
				serial.writeInt(log.CMD_TV_OFF);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case Menu.MENU_HEATER_ON:
			System.out.println("보일러 가동");
			try {
				serial.writeInt(log.CMD_HEATER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case Menu.MENU_CLEANER_ON:
			System.out.println("세탁기 가동");
			try {
				serial.writeInt(log.CMD_CLEANER_ON);
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			break;
		case Menu.MENU_GUEST_LOGOUT:
			System.out.println("사용자 로그아웃");
			return false;
		case Menu.MENU_GUEST_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
		return true;
	}
}
