package serial;

import java.io.IOException;


import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial {
	
	// https://mtsdev.tistory.com/4
	// https://code.google.com/archive/p/java-simple-serial-connector/downloads
	// 프로젝트 파일 안에 폴더 생성(lib)-jssc.jar 파일 붙여넣기
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String[] portName = SerialPortList.getPortNames();
		for (int i = 0; i < portName.length; i++) {
			System.out.println("사용 가능 포트 : " + portName[i]);
		}
		
		SerialPort serialPort = new SerialPort(portName[0]);
		// SerialPort serialPort = new SerialPort("COM5"); -> 위와 동일함 / 하드 코딩 형태 
		
		try {
			serialPort.openPort();
			// Params : 매개 변수
			// BAUDRATE, DATABITS, STOPBITS, PARITY -> static 변수
			// BAUDRATE_9600 : 데이터 전송 속도(보통 9600이 가장 안정적) / 속도가 빠르면 데이터 누락의 리스크가 있을 수도 있음
			// DATABITS_8 : 데이터를 전송할 때 8비트로 보냄
			// STOPBITS_1 : 데이터 전송이 종료된다는 사실을 알려 주기 위하여 데이터 비트의 맨 마지막에 첨가하는 비트
			// PARITY_NONE : 오류 체크 방식	
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8,
					SerialPort.STOPBITS_1, SerialPort.PARITY_NONE); // 4개의 매개 변수
			System.out.println("포트 사용 가능!");
		} catch (SerialPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		ReadThread rt = new ReadThread(serialPort);
		rt.start();
		WriteThread wt = new WriteThread(serialPort);
		wt.start();
	}
}

class ReadThread extends Thread {
	SerialPort serial; // SerialPort -> 라이브러리 사용
	
	// 매개 변수가 있는 생성자
	public ReadThread(SerialPort serial) {
		this.serial = serial;
	}
	
	// thread는 반드시 run 필요
	@Override // @ : 어노테이션 / Override : 재정의(상속) / *오버로딩 : 중복정의
	public void run() {
		// TODO Auto-generated method stub
//		super.run();
		// 무한 루프
		while (true) {			
			try {
				byte[] read = serial.readBytes(); // 모든 통신의 기본 단위 : byte
				if (read != null && read.length > 0) {
					String data = new String(read);
					System.out.print(data);
				}
			} catch (SerialPortException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}	
}

class WriteThread extends Thread {
	SerialPort serial;
	
	public WriteThread(SerialPort serial) {
		this.serial = serial;
	}
	
	public void run () {
		int c = 0;
		try {
			while ((c=System.in.read()) > -1) { // 아스키코드로 입력 받음
				serial.writeInt(c); 
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SerialPortException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}