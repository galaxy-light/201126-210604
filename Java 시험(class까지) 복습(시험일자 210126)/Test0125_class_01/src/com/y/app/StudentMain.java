package com.y.app;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub		
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동",
				"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};			
		
		Random rand = new Random();
		Student st [] = new Student[10];
		for (int i = 0; i < st.length; i++) {
			st[i] = new Student(name[rand.nextInt(5)], age[rand.nextInt(5)],
					gender[rand.nextInt(2)], address[rand.nextInt(5)]);
			st[i].showStudentInfo();
		}
//		st[9].showStudentInfo(); // 원본 10번째 객체
		
		st[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골"); // 10번째 객체 정보 변경
		st[9].showStudentInfo();
	}

}
