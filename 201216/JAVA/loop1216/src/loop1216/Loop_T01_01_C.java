package loop1216;

import java.util.Scanner;

public class Loop_T01_01_C {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("---------------------------");
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("---------------------------");
		Scanner s = new Scanner(System.in);
		for (int i=0; i<5; i++) {
			System.out.println((i+1)+".Num"+(i+1)+"==> ");
			int num = s.nextInt();
			if (num%2 == 0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}
		}
	}
}
