package com.y.addrApp.model;

public class AddrBook {
	
	String name;
	int age;
	String tel;
	String address;
	String email;
	
	public AddrBook(String name, int age, String tel, String address, String email) {
//		super(); // super(); : Object(최상위)에서 상속 받았다는 뜻
		this.name = name;
		this.age = age;
		this.tel = tel;
		this.address = address;
		this.email = email;
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

	public String getTel() {
		return tel;
	}

	public void setTel(String tel) {
		this.tel = tel;
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}	
	
	public void showAddressInfo() {
		System.out.println("이름 : " + name);
		System.out.println("나이 : " + age);
		System.out.println("번호 : " + tel);
		System.out.println("주소 : " + address);
	}
}
