package loop1216;

import java.util.Scanner;

public class Loop_T01_03 {

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
		do {
			if(a%2==0) {
				System.out.println("num1 => " + a);
				System.out.println("짝수입니다.");
			}
			else if(a%2 != 0){
				System.out.println("num1 => " + a);
				System.out.println("홀수입니다.");
			}
		}while(a<100);
		i = 0;
		do {
			if(b%2==0) {
				System.out.println("num1 => " + b);
				System.out.println("짝수입니다.");
			}
			else if(b%2 != 0){
				System.out.println("num1 => " + b);
				System.out.println("홀수입니다.");
			}
		}while(b<100);
		i = 0;
		do {
			if(c%2==0) {
				System.out.println("num1 => " + c);
				System.out.println("짝수입니다.");
			}
			else if(c%2 != 0){
				System.out.println("num1 => " + c);
				System.out.println("홀수입니다.");
			}
		}while(c<100);
		i = 0;
		do {
			if(d%2==0) {
				System.out.println("num1 => " + d);
				System.out.println("짝수입니다.");
			}
			else if(d%2 != 0){
				System.out.println("num1 => " + d);
				System.out.println("홀수입니다.");
			}
		}while(d<100);
		i = 0;
		do {
			if(e%2==0) {
				System.out.println("num1 => " + e);
				System.out.println("짝수입니다.");
			}
			else if(e%2 != 0){
				System.out.println("num1 => " + e);
				System.out.println("홀수입니다.");
			}
		}while(e<100);
		}
	}


