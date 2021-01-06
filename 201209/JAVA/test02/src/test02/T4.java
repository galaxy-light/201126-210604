package test02;

import java.util.Scanner;

public class T4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 논리연산, 제어문
		Scanner n = new Scanner(System.in);
		System.out.print("연도를 입력하세요 : ");
		int a = n.nextInt();
		
		if((a%4 == 0 && a%100 != 0)||(a%400 == 0)) {
			System.out.println("입력한 연도는 윤년입니다.");
		}
		else {
			System.out.println("입력한 연도는 윤년이 아닙니다.");
		}		
		n.close();
	}

}
