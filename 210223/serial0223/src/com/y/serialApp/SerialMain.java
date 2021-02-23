package com.y.serialApp;
import com.y.serialApp.handler.SerialCtrl;
import com.y.serialApp.network.Myserial;
import com.y.serialApp.util.Menu;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		Menu m = new Menu();
		Myserial sc = new Myserial();
		SerialPort serial = sc.initSerial();
		SerialCtrl ct = new SerialCtrl();	
				
		while (true) {
			String mode = m.login(s);				
			if (mode.equals(m.ADMIN_MODE)) {
				while (true) {
					if (ct.adminWork(s, serial) == false) {
						break;
					}
				}
			}
			else if (mode.equals(m.GUEST_MODE)) {
				while (true) {
					if (!ct.guestWork(s, serial)) {
						break;
					}
				}
			}
			else {
				System.out.println("ID 또는 비번이 잘못되었습니다.");
				System.out.println("다시 입력하세요.");
			}
		}
	}
}



