package test02;

import java.util.Scanner;

public class T3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 사칙연산, 제어문(if)
		Scanner n = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력 :" );
		int a = n.nextInt();
		System.out.print("연산자 입력 : ");
		String t = n.next();
		System.out.print("두번째 숫자 입력 : ");
		int b = n.nextInt();
		
		int c = a+b;
		int d = a-b;
		int e = a*b;
		int f = a/b;
		
		if (t.equals("+")) {
			System.out.println(a + "+" + b + "=" + c);
		}
		else if (t.equals("-")) {
			System.out.println(a + "-" +  b + "=" + d);
		}
		else if (t.equals("*")) {
			System.out.println(a + "*" +  b + "=" + e);
		}
		else if (t.equals("/")) {
			System.out.println(a + "/" +  b + "=" + f);
		}
		n.close();
	}

}
