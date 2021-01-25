package com.y.carApp;

import java.util.Random;

import y.carApp.customer.Customer;

public class CarAppMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub	
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		String tel[] = {"010-1234-5678", "010-4321-5678", "010-3478-1278",
				"010-4523-1978", "010-7890-2134"};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동",
				"부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		String model[] = {"SM6", "쏘나타", "싼타페", "K7", "그랜저"};
		String color[] = {"블랙", "은색", "흰색", "회색", "빨강"};
		int year[] = {2016, 2017, 2016, 2017, 2016};
		String company[] = {"삼성르노", "현대", "현대", "기아", "현대"};
		String price[] = {"2천5백만원", "3천만원", "3천5백만원", "4천만원", "4천5백만원"};
		
		Random rand = new Random();
		Customer arr[] = new Customer[10];		
		for (int i = 0; i < arr.length; i++) {
			arr[i] = new Customer(name[rand.nextInt(5)], tel[rand.nextInt(5)], address[rand.nextInt(5)],
					 new Car(model[rand.nextInt(5)], year[rand.nextInt(5)],
					color[rand.nextInt(5)], company[rand.nextInt(5)],
					price[rand.nextInt(5)]));
			arr[i].printCustomerInfo();
		}
		
	}

}
