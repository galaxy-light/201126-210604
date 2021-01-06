import java.util.Scanner;

public class Test1208_5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 지폐는 입력값
		Scanner a = new Scanner(System.in);
		System.out.print("지폐 입력 : ");
		int b = a.nextInt();
		
		int c = 500;
		int d = 100;
		int e = 50;
		int f = 10;
		
		// 입력한 지폐값에서 500원
		int g = b/c; // 몫 : 500원 개수
		System.out.println("500원 개수 : " + g);
		int h = b%c; // 나머지 : nnn원 단위	
		
		// 나머지 값에서 100원
		int i = h/d; // 몫 : 100원 개수
		System.out.println("100원 개수 : " + i);
		int j = h%d; // 나머지 : nn원 단위
		
		// 나머지 값에서 50원
		int k = j/e; // 몫 : 50원 개수
		System.out.println("50원 개수 : " + k);
		int l = j%e; // 나머지 : 1n원 단위	
		
		// 나머지 값에서 10원
		int m = l/f; // 몫 : 10원 개수
		System.out.println("10원 개수 : " + m);
		int n = l%f; // 나머지 : n원 단위
		
		// 바꾸지 못하는 잔돈		
		int p = n%f; // 나머지 -> 결과값
		System.out.println("바꾸지 못하는 잔돈 : " + p);
		
		// 교환기
		System.out.println("--------------------");
		System.out.println("동전 교환기 프로그램 1.0");
		System.out.println("--------------------");
		System.out.println("500원 개수 : " + g);
		System.out.println("100원 개수 : " + i);
		System.out.println("50원 개수 : " + k);
		System.out.println("10원 개수 : " + m);
		System.out.println("바꾸지 못하는 잔돈 : " + p);
		
		a.close();
	}

}
