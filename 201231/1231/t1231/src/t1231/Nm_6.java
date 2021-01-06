package t1231;

import java.util.Scanner;

public class Nm_6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		int hap = 0;
		System.out.print("N 입력 : ");		
		int num1 = s.nextInt();
		System.out.print("M 입력 : ");
		int num2 = s.nextInt();
		for (int i = 1; i <= num1; i++) {
			// System.out.println(i);
			for (int j = 1; j <= num2+1; j++) {
				// System.out.println(j);
			}
			if (i%2==0) {
				hap = hap + i;
				
			}
		}
		System.out.println("1~N까지 M의 배수를 제외한 합 : "+ hap);
	}

}
