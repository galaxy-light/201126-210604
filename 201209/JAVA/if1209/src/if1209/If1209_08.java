package if1209;

import java.util.Scanner;

public class If1209_08 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		
	
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 : ");
		String a = s.next();
		int b = num1 + num2;
		int c = num1 - num2;
		int d = num1 * num2;
		int e = num1 / num2;
			
		System.out.println("---------------------");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("---------------------");
		if (a.equals("+")) {
			System.out.println(num1 + a + num2 + "=" + b);			
		}
		else if (a.equals("-")) {
			System.out.println(num1 + a + num2 + "=" + c);
		}
		else if (a.equals("*")) {
			System.out.println(num1 + a + num2 + "=" + d);
		}
		else if (a.equals("/")) {
			System.out.println(num1 + a + num2 + "=" + e);
		}		
		s.close();
	}
	
}


