package com.y.serialApp.network;
import com.y.serialApp.handler.SerialCtrl;
import com.y.serialApp.util.Menu;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class Myserial {
	public SerialPort initSerial() {
		String[] portNames = SerialPortList.getPortNames();
		for (int i = 0; i < portNames.length; i++) {
			System.out.println(portNames[i]);
		}
		SerialPort serialPort =	new SerialPort(portNames[0]);		
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8,
					SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
		return serialPort;
	}
}
