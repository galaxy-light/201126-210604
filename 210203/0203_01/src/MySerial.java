import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

import gnu.io.CommPort;
import gnu.io.CommPortIdentifier;
import gnu.io.NoSuchPortException;
import gnu.io.PortInUseException;
import gnu.io.SerialPort;
import gnu.io.UnsupportedCommOperationException;

public class MySerial {
	void connect(String portName) {
		try {
			CommPortIdentifier portId = 
				CommPortIdentifier.getPortIdentifier(portName);
			if (portId.isCurrentlyOwned()) {
				System.out.println("[에러] 포트 사용중");
			}
			else {
				// 클래스 이름을 식별자로 사용하여 포트 열기
				CommPort commPort = 
					portId.open(getClass().getName(), 2000);
				if (commPort instanceof SerialPort) {
					SerialPort serialPort = (SerialPort)commPort;
					serialPort.setSerialPortParams(9600, SerialPort.DATABITS_8, 
							SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
					InputStream in = serialPort.getInputStream();
					OutputStream out = serialPort.getOutputStream();
					
					// new Thread(new SerialReader(in)).start();
					new Thread(new SerialWriter(out)).start();
				}
			}
		} catch (NoSuchPortException e) {
			e.printStackTrace();
		} catch (PortInUseException e) {
			e.printStackTrace();
		} catch (UnsupportedCommOperationException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	// inner class :  클래스 안에 클래스
	// 인터페이스를 쓸 경우 반드시 오버라이딩을 해야 됨
	// 추상메서드는 반드시 오버라이딩을 해야 됨
	public static class SerialReader implements Runnable{
		InputStream in;		
		
		public SerialReader(InputStream in) {
			// super();
			this.in = in;
		}
		
		// Source-Override/Implements Methods
		@Override
		public void run() {
			// TODO Auto-generated method stub
			byte [] buf = new byte [1024];
			int len = -1;
			try {
				while ((len = in.read(buf)) > -1) {
					System.out.println(new String(buf, 0, len));
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}
	
	// 인터페이스를 쓸 경우 반드시 오버라이딩을 해야 됨
	public static class SerialWriter implements Runnable {
		OutputStream out;
				
		public SerialWriter(OutputStream out) {
			// super();
			this.out = out;
		}

		@Override
		public void run() {
			// TODO Auto-generated method stub
			int c = 0;
			try {
				while((c=System.in.read()) > -1) {
					out.write(c);
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}		
	}	
}
