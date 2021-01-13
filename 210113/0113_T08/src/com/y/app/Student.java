package com.y.app;

public class Student {
	private static String name;
	private static int age;
	private static char gender;
	private static String address;
	
	
	public Student(String name2, int age2, char gender2, String address2) {
		super();
		this.name = name2;
		this.age = age2;
		this.gender = gender2;
		this.address = address2;
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
		System.out.println(name);
		System.out.println(age);
		System.out.println(gender);
		System.out.println(address);
	}
	
}


