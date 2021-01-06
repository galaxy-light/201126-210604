package operTest1208;

import java.util.Scanner;

public class OpTest6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 동전 500 100 50 10
		Scanner a = new Scanner(System.in);
		
		final int b = 500;
		final int c = 100;			
		final int d = 50;
		final int e = 10;
		
		System.out.print("지폐 입력 : ");
		int f = a.nextInt();
		
		int g = f/b; // 입력한 값을 500으로 나눠서 몫 구하기 : 500원 동전 갯수
		int h = f%b; // 입력한 값 500으로 나머지 구하기 : 100원대만 남도록		
		System.out.println("500원 : " + g);
		
		int i = h/c; // h값을 100으로 나눠서 몫 구하기 : 100원 동전 갯수
		int j = h%c; // h값 100으로 나머지 구하기 : 50원대만 남도록
		System.out.println("100원 : " + i);
		
		int k = j/d; // j값을 50으로 나눠서 몫 구하기 : 50원 동전 갯수
		int l = j%d; // j값 50으로 나머지 구하기 : 10원대만 남도록
		System.out.println("50원 : " + k);
		
		int m = l/e; // l값을 10으로 나눠서 몫 구하기 : 10원 동전 갯수
		int n = l%e; // l값 10으로 나머지 구하기 : 1원대만 남도록
		System.out.println("10원 : " + m);
		
		int o = n/e; // n값을 10으로 나눠서 몫 구하기 : 1원 동전 갯수
		int p = n%e; // n값 10으로 나머지 구하기 : 바꾸지 못한 잔돈
		System.out.println("바꾸지 못한 잔돈 : " + p);
		
		// 교환기
		System.out.println("-------------------");
		System.out.println("동전 교환 프로그램 1.0");
		System.out.println("-------------------");
		System.out.println("오백원 갯수 : " + g +"개");
		System.out.println("오백원 갯수 : " + i +"개");
		System.out.println("오백원 갯수 : " + k +"개");
		System.out.println("오백원 갯수 : " + m +"개");
		System.out.println("바꾸지 못한 잔돈 " + p +"원");
		
				
	
	}

}
