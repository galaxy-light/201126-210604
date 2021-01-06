package if1209;

import java.util.Scanner;

public class If1209_07 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);		
		
		System.out.println("-------------------");
		System.out.println("대소 비교 프로그램 v1.0");
		System.out.println("-------------------");
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num1 입력 : ");
		int num2 = s.nextInt();
		
		
		if (num1 > num2) {
			System.out.println("num1이 num2보다 크다.");
		}
		else if (num1 < num2) {
			System.out.println("num2이 num1보다 크다.");
		}
		else if (num1 == num2) {
			System.out.println("num1과 num2가 같다.");
		}
	s.close();
	}
	
}
