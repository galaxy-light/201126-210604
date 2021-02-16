package serial3_2;

import java.io.IOException;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial_2 {
   public static void main(String[] args) {
      String[] portName = SerialPortList.getPortNames();
      for (int i=0; i<portName.length; i++) {
         System.out.println("사용가능 포트: " + portName[i]);
         // System.out.println(portName[i]);
      }
      SerialPort serialPort = new SerialPort(portName[0]);
      // SerialPort serialPort = new SerialPort("COM5");      
      
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
      
      ReadThread rt = new ReadThread(serialPort);
      rt.start();
      WriteThread wt = new WriteThread(serialPort);
      wt.start();
//      try {
//         serialPort.closePort();
//         System.out.println("포트 종료!");
//      } catch (SerialPortException e) {
//         e.printStackTrace();
//      }
   }
}

// 읽기 전용 작업 스레드
class ReadThread extends Thread {
   SerialPort serial;
   
   public ReadThread(SerialPort serial) {
      this.serial = serial;
   }

   @Override
   public void run() {
	   // 무한 루프
      while (true) {
         try {
            byte[] read = serial.readBytes(); // 바이트로 자료를 입력 받음
            if (read != null && read.length > 0) {
//               System.out.print(new String(read));
               String data = new String(read);
               System.out.print(data);
            }
         } catch (SerialPortException e) {
            e.printStackTrace();
         }
      }
   }
}

// 전송 전용 작업 스레드
class WriteThread extends Thread {
   SerialPort serial;
   
   // WriteThread : 생성자
   public WriteThread(SerialPort serial) {
      this.serial = serial;
   }
   
   public void run() {
      int c = 0;
      try {
         while ((c=System.in.read()) > -1) {
            serial.writeInt(c);
         }
      } catch (IOException e) {
         e.printStackTrace();
      } catch (SerialPortException e) {
         e.printStackTrace();
      }
   }
}
