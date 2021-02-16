package serial4;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int HEATER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;

	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '0';
	static final int CMD_HEATER_ON = '2';
	static final int CMD_CLEANER_ON = '3';	
	
	public static int getMenu(Scanner s) {
		System.out.println("----------------");
		System.out.println("스마트 홈 제어 v1.0");
		System.out.println("----------------");
		System.out.println("1. TV 켜기"); // LED ON
		System.out.println("2. TV 끄기"); // LED OFF
		System.out.println("3. 보일러 동작"); // BUZZER ON
		System.out.println("4. 세탁기 동작"); // SERVO ON
		System.out.println("5. 종료");
		System.out.println("----------------");
		System.out.print("메뉴 선택 : ");
//		int menu = s.nextInt();
//		return menu;
		return s.nextInt(); // 위의 두 줄을 한 줄로
	}
	
	public static SerialPort initSerial() {
		// 사용 가능 포트 확인
	    // 현재 컴퓨터의 직렬 포트 이름이 포함된 배열을 가져옴
		String[] portName = SerialPortList.getPortNames();
	      for (int i=0; i<portName.length; i++) {	    	
	         System.out.println("사용가능 포트: " + portName[i]);
	         // System.out.println(portName[i]);
	      }
	      
	      // 직렬 포트 리소스를 나타냄
	      SerialPort serialPort = new SerialPort(portName[0]); // 시리얼 객체 생성
	      // SerialPort serialPort = new SerialPort("COM5");      
	      
	      // 시리얼 포트 오픈+초기화
	      try {
	         serialPort.openPort();
	         serialPort.setParams(SerialPort.BAUDRATE_9600, // BAUDRATE_9600 : 통신속도는 아두이노 파일과 동일하게 맞추어야 함
	               SerialPort.DATABITS_8 , // DATABITS_8 : 데이터를 전송할 때 8비트
	               SerialPort.STOPBITS_1, // STOPBITS_1 : 데이터의 전송이 종료된다는 사실을 알려 주기 위하여 데이터 비트의 맨 마지막에 첨가하는 비트
	               SerialPort.PARITY_NONE); // PARITY_NONE : 오류 체크 방식 중 하나
	         System.out.println("포트 사용 가능!");
	      } catch (SerialPortException e) {
	         e.printStackTrace();
	      }		      
	      return serialPort;
	}
	
	public static void main(String[] args) {
		// 라이브러리 연결
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);		
		SerialPort serial = initSerial(); // 메서드 호출
		
		while (true) {
			switch (getMenu(s)) {
			case TV_ON:
				System.out.println("TV ON");
				// serial = serialPort
				// serial.writeInt(CMD_TV_ON); -> try/catch
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF:
				System.out.println("TV OFF");
				// serial = serialPort
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case HEATER_ON:
				System.out.println("보일러 가동");	
				// serial = serialPort
				try {
					serial.writeInt(CMD_HEATER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case CLEANER_ON:
				System.out.println("세탁기 가동");	
				// serial = serialPort
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case PROGRAM_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}







