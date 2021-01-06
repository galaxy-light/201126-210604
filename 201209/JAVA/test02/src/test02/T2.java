package test02;

import java.util.Scanner;

public class T2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 크기 비교, 제어문(if)
		Scanner n = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int a = n.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int b = n.nextInt();
		
		if (a > b) {
			System.out.println("a가 b보다 크다.");
		}
		else if (a < b) {
			System.out.println("a가 b보다 작다.");
		}
		else if (a == b) {
			System.out.println("a와 b가 같다.");
		}
		n.close();
	}

}
