package com.y.addrApp.util;

import java.util.Random;
import java.util.Scanner;

import com.y.addrApp.dao.MySQLHandler;
import com.y.addrApp.model.AddrBook;

public class RandData {
	// 랜덤 데이터 추가
	Random r = new Random();
	static String[] name = { "우길동", "강길동", "추길동", "현길동", "서길동" };
	static int[] age = { 10, 20, 30, 40, 50 };
	static String[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
	static String[] address = { "대구시 동구", "춘천시 동구", "목포시 동구", "파주시 동구", "창원시 동구" };
	static String[] email = { "uu@naver.com", "kang@daum.net", "chu@gmail.com", "heon@naver.com", "seo@gmail.com" };

	public String getRName() {
		return name[r.nextInt(5)];
	}

	public int getRAge() {
		return age[r.nextInt(5)];
	}

	public String getRTel() {
		return tel[r.nextInt(5)];
	}

	public String getRAddress() {
		return address[r.nextInt(5)];
	}

	public String getREmail() {
		return email[r.nextInt(5)];
	}

	public AddrBook getABook() {
		return new AddrBook(getRName(), getRAge(), getRTel(), getRAddress(), getREmail());
	}	
}


