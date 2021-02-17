package serial0217;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain2 {
	public static final String ADMIN_ID = "admin";
	public static final String GUEST_ID = "guest";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_PW = "1111";	
	public static final String ADMIN_MODE = "admin_mode";	
	public static final String GUEST_MODE = "guest_mode";	
	public static final String OTHER_MODE = "other_mode";	
	
	public static final int LOGOUT = 0;
	public static final int TV_ON = 1;
	public static final int TV_OFF = 2;
	public static final int HEATER_ON = 3;
	public static final int CLEANER_ON = 4;
	public static final int BREAK = 5;
	public static final int EXIT = 5;
	public static final int PROGRAM_EXIT = 6;
	public static final int RECONN = 7;
	
	static final int CMD_TV_ON = '1';
	static final int CMD_TV_OFF = '2';
	static final int CMD_HEATER_ON = '3';
	static final int CMD_CLEANER_ON = '4';	

	public static SerialPort initSerial() { // SerialPort : 타입
		// 사용 가능 포트 확인
	    // 현재 컴퓨터의 직렬 포트 이름이 포함된 배열을 가져옴
		String[] portName = SerialPortList.getPortNames();
	      for (int i=0; i<portName.length; i++) {	    	
	         System.out.println("사용가능 포트: " + portName[i]);
	         // System.out.println(portName[i]);
	      }
	      
	      // 직렬 포트 리소스를 나타냄
	      SerialPort serialPort = new SerialPort(portName[0]); // 시리얼 객체 생성
	      // SerialPort serialPort = new SerialPort("COM$");	      
	      
	      return serialPort; // 객체 정보 리턴
	}	
	
	public static void openSerial (SerialPort serialPort) {
		// 시리얼 포트 오픈+초기화
	      try {
	         serialPort.openPort();
	         // setParams : setter의 역할
	         serialPort.setParams(SerialPort.BAUDRATE_9600, // BAUDRATE_9600 : 통신속도는 아두이노 파일과 동일하게 맞추어야 함
	               SerialPort.DATABITS_8 , // DATABITS_8 : 데이터를 전송할 때 8비트
	               SerialPort.STOPBITS_1, // STOPBITS_1 : 데이터의 전송이 종료된다는 사실을 알려 주기 위하여 데이터 비트의 맨 마지막에 첨가하는 비트
	               SerialPort.PARITY_NONE); // PARITY_NONE : 오류 체크 방식 중 하나
	         System.out.println("포트 연결!");
	      } catch (SerialPortException e) {
	         e.printStackTrace();
	      }		      
	}
		
	public static String login(Scanner s) {
		System.out.println("----------------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("----------------------");
		System.out.print("ID : ");
		String id = s.next();
		System.out.print("PW : ");
		String passwd = s.next();
		String mode;

//		System.out.println("ID : " + id);
//		System.out.println("PW : " + passwd);	
		
		while (true) {
			if (id.equals(ADMIN_ID) && passwd.equals(ADMIN_PW)) {
//				System.out.println("관리자 모드");
				mode = ADMIN_MODE;
			} else if (id.equals(GUEST_ID) && passwd.equals(GUEST_PW)) {
//					System.out.println("사용자 모드");
				mode = GUEST_MODE;
			} else {
//					System.out.println("ID 또는 PW가 일치하지 않습니다.");
//					System.out.println("다시 입력하세요.");
				mode = OTHER_MODE;
			}
			return mode;
		}		
	}
	
	public static int adminmenu(Scanner s) {
		System.out.println("--------------------");
		System.out.println("스마트홈 제어 관리자 모드");
		System.out.println("--------------------");
		
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 긴급 정지");		
		System.out.println("6. 종료");
		System.out.println("7. 통신 재접속");
		System.out.println("0. 로그아웃");
		System.out.println("--------------------");
		System.out.print("메뉴 선택 : ");	
		return s.nextInt();
	}
	
	public static int guestmenu(Scanner s) {
		System.out.println("--------------------");
		System.out.println("스마트홈 제어 사용자 모드");
		System.out.println("--------------------");
		System.out.println("1. TV 켜기");
		System.out.println("2. TV 끄기");
		System.out.println("3. 보일러 동작");
		System.out.println("4. 세탁기 동작");
		System.out.println("5. 종료");
		System.out.println("6. 통신 재접속");
		System.out.println("0. 로그아웃");
		System.out.println("------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();		
	}
	
	public static boolean adminoption(Scanner s, SerialPort serial) { // Scanner s, SerialPort serial : 매개변수
			switch (adminmenu(s)) {
			case TV_ON :
				System.out.println("TV 켜기");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF :
				System.out.println("TV 끄기");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case HEATER_ON :
				System.out.println("보일러 동작");
				try {
					serial.writeInt(CMD_HEATER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case CLEANER_ON :
				System.out.println("세탁기 동작");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case BREAK :
				System.out.println("긴급 정지");		
				try {
					serial.closePort();
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case RECONN :
				System.out.println("통신 재연결");
				if(!serial.isOpened()) {
					connSerial(serial);
				}
				break;
			case PROGRAM_EXIT :
				System.out.println("종료");
				s.close();
				System.exit(0);											
			case LOGOUT :
				System.out.println("관리자 로그아웃");	
				return false;
			}
			return true;
		}
	
	public static void connSerial(SerialPort serial) {
		try {
			serial.openPort();
		} catch (SerialPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	} 
	
	public static void closeSerial(SerialPort serial) {
		try {
			serial.closePort();
		} catch (SerialPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}	
	
	public static boolean guestoption(Scanner s, SerialPort serial ) {		
			switch (guestmenu(s)) {
			case TV_ON :
				System.out.println("TV 켜기");
				try {
					serial.writeInt(CMD_TV_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case TV_OFF :
				System.out.println("TV 끄기");
				try {
					serial.writeInt(CMD_TV_OFF);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case HEATER_ON :
				System.out.println("보일러 동작");
				try {
					serial.writeInt(CMD_HEATER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;
			case CLEANER_ON :
				System.out.println("세탁기 동작");
				try {
					serial.writeInt(CMD_CLEANER_ON);
				} catch (SerialPortException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				break;			
			case EXIT :
				System.out.println("종료");
				s.close();
				System.exit(0);					
			case LOGOUT :
				System.out.println("사용자 로그아웃");	
				return false;
			}	
			return true;
		}				
		
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		SerialPort serial = initSerial(); // 메서드 호출
		openSerial(serial);

		while (true) {
			String mode = login(s);
			if (mode.equals(ADMIN_MODE)) {
				System.out.println("관리자 모드");
//				adminmenu(s);				
				while (true) {
					if (adminoption(s, serial) == false ) {
						break;
					}
				}
			}
			else if (mode.equals(GUEST_MODE)) {
				System.out.println("사용자 모드");
//				guestmenu(s);			
				while (true) {
					if (!guestoption(s, serial)) {
						break;
					}						
				}
			}
			else { // OTHER_MODE
				System.out.println("ID 또는 PW가 일치하지 않습니다.");
				System.out.println("다시 입력하세요.");				
			}
		}
	}
}
