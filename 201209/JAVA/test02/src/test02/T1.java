package test02;

import java.util.Scanner;

public class T1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 홀수짝수, 제어문
		Scanner n = new Scanner(System.in);
		System.out.print("숫자를 입력하세요 : ");
		int a = n.nextInt();
		
		if (a%2 == 0) {
			System.out.println("짝수");
		}
		else if (a%2 != 0) {
			System.out.println("홀수");
		}
		n.close();
	}

}
