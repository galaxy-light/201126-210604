package com.y.app;

import java.util.Random;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String name [] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age [] = {20, 25, 30, 35, 40};
		char gender [] = {'남', '여'};
		String address [] = {"대구시 동구 신암4동", "서울시 동구 신암4동",
				"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		int arr [] = new int [10];	

		Random a = new Random();
		Student st[] = new Student[10];
		for (int i = 0; i < arr.length; i++) {
			st[i] = new Student(name[a.nextInt(5)], age[a.nextInt(5)], gender[a.nextInt(2)], address[a.nextInt(5)]);
			st[i].showStudentInfo();
		}
		
	}



}