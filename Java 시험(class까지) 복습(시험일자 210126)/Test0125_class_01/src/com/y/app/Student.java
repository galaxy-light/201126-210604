package com.y.app;

public class Student {
	// static 변수는 생성되는 모든 인스턴스들이 공유하게 됨, 인스턴스를 생성하지 않아도 사용 가능
	private static String name;
	private static int age;
	private static char gender;
	private static String address;
	
	public Student(String name, int age, char gender, String address) {
		super();
		this.name = name;
		this.age = age;
		this.gender = gender;
		this.address = address;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}
	
	public void showStudentInfo() {
		System.out.println("이름 : " + name);
		System.out.println("나이 : " + age);
		System.out.println("성별 : " + gender);
		System.out.println("주소 : " + address);
		System.out.println("---------------------------");
	}
}
	
