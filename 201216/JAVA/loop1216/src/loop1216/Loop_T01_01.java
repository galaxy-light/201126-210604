package loop1216;

import java.util.Scanner;

public class Loop_T01_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력 : ");
		int a = s.nextInt();
		System.out.print("두번째 숫자 입력 : ");
		int b = s.nextInt();
		System.out.print("세번째 숫자 입력 : ");
		int c = s.nextInt();
		System.out.print("네번째 숫자 입력 : ");
		int d = s.nextInt();
		System.out.print("다섯번째 숫자 입력 : ");
		int e = s.nextInt();		
	
		System.out.println("---------------------------");
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("---------------------------");
		
		int i = 0;
		for(i=0; a%2 == 0; i+=2) {			
			System.out.println("num1 => " + a);
			System.out.println("짝수입니다.");
			break;
			
		}
		for(i=0; a%2 != 0; i--) {			
			System.out.println("num1 => " + a);
			System.out.println("홀수입니다.");
			break;
		}
		i = 0;
		for(i=0; b%2 == 0; i+=2) {			
			System.out.println("num2 => " + b);
			System.out.println("짝수입니다.");
			break;
			
		}
		for(i=0; b%2 != 0; i--) {			
			System.out.println("num2 => " + b);
			System.out.println("홀수입니다.");
			break;
		}
		i = 0;
		for(i=0; c%2 == 0; i+=2) {			
			System.out.println("num3 => " + c);
			System.out.println("짝수입니다.");
			break;
			
		}
		for(i=0; c%2 != 0; i--) {			
			System.out.println("num3 => " + c);
			System.out.println("홀수입니다.");
			break;
		}
		i = 0;
		for(i=0; d%2 == 0; i+=2) {			
			System.out.println("num4 => " + d);
			System.out.println("짝수입니다.");
			break;
			
		}
		for(i=0; d%2 != 0; i--) {			
			System.out.println("num4 => " + d);
			System.out.println("홀수입니다.");
			break;
		}
		i = 0;
		for(i=0; e%2 == 0; i+=2) {			
			System.out.println("num5 => " + e);
			System.out.println("짝수입니다.");
			break;
			
		}
		for(i=0; e%2 != 0; i--) {		
			System.out.println("num5 => " + e);
			System.out.println("홀수입니다.");
			break;
		}
		s.close();
	}

}
