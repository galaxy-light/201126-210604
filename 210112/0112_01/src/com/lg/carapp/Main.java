package com.lg.carapp;

import java.util.ArrayList;

import com.lg.carapp.car.Car;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 객체를 생성하면 package가 분리되어 있어서 에러가 뜸 -> car에 마우스를 대고 import 선택 -> import 자동 생성
//		Car car = new Car(); // new Car(); : 객체 생성 / Car(); : 사용자가 정의하지 않아도 java에서 자동으로 기본 생성자 생성함
		// 지금은 Car.java에 사용자가 기본 생성자를 정의했기 때문에 그것을 불러옴
//		car.setModel("그랜저 개조");
//		car.setYear(2020);
//		car.setMoney("3천만원");
//		car.showCarInfo();
//		new Car(); // new Car();을 써도 생성이 가능하지만 위치 정보를 모르기 때문에 접근, 재사용 불가
//		new Car(); // new Car();을 써도 생성이 가능하지만 위치 정보를 모르기 때문에 접근, 재사용 불가
		
//		Car car2 = new Car("그랜저", 2021, "3천만원");
//		car2.showCarInfo();
		
		Car car3[] = new Car[10]; // 객체 생성X, 배열만 생성
		// int num[] = new int[10]; // 배열 10칸 생성(0~9까지) / 배열 시작 위치 : num
//		car3[0] = new Car(); // 첫번째 칸에 객체 생성
//		car3[9] = new Car(); // 마지막 간에 객체 생성
		
				
//		for (int i = 0; i < car3.length; i++) {
//			car3[i] = new Car(); // 배열크기[10]만큼 생성
//		}
		
		// 컬렉션 클래스(자료구조) ArrayList		
		ArrayList<Car> arrList = new ArrayList<>(); // <> : Car class 안에는 모든 타입이 올 수 있음 / 크기가 정해져 있지 않음
		arrList.add(new Car("소나타", 2020, "2천만원")); // 객체 저장
		arrList.add(new Car("SM7", 2021, "3천만원")); // 객체 저장
		
		for (int i = 0; i < arrList.size(); i++) {
			Car mycar = arrList.get(i);
			mycar.showCarInfo();
			arrList.get(i).showCarInfo(); // 체인 방식 : Car mycar = arrList.get(i); mycar.showCarInfo();을 한 줄로 표현
		}
		
	}

}
