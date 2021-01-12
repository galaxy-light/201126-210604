package com.lg.carapp.car;

public class Car {
	// 객체지향의 특징 : 캡슐화, 특징화, 오버로딩
	// 변수 캡슐화 : private
	// 특징화 : model, year, money
	private String model;
	private int year;
	private String money;
	
	// 기본 생성자 : class에 대한 정보 초기화		
	public Car() {
		// 인스턴스 변수
		model = "K7";
		year = 2020;
		money = "4천만원";
		/* 이렇게 사용자가 생성자를 적어주면 사용자가 정의한 대로 java에서 사용하고
		* 사용자가 생성자를 지정하지 않으면 java 컴파일러에서 자동으로 기본 생성자를 생성함
		*/
		System.out.println("기본 생성자 생성!");
		showCarInfo(); // 여기서도 출력 가능
	}
	
	
	// Source-Generate Constructor using Fields	
	/*  메서드 오버로딩(중복 정의) - 2개의 조건 중에 하나만 충족하면 됨
	 *  1번 조건 : 매개변수 개수 다름
	 *  2번 조건 : 매개변수 타입이 다름
	 */	
	public Car(String model, int year, String money) { // 생성자 오버로딩
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}

	
	// Source-Generate getters and setters
	public String getModel() {
		return model;
	}
	public void setModel(String model) {
		this.model = model;
	}
	public int getYear() {
		return year;
	}
	public void setYear(int year) {
		this.year = year;
	}
	public String getMoney() {
		return money;
	}
	public void setMoney(String money) {
		this.money = money;
	}
	
	
	// 인스턴스 메서드
	public void showCarInfo() {
		System.out.println("모델 : " + model);
		System.out.println("연식 : " + year);
		System.out.println("가격 : " + money);
		System.out.println("------------------");
	}
	
}


