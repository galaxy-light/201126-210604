package if1222;

import java.util.Scanner;

public class If1222_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("-------------");
		System.out.println("윤년 구분 프로그램");
		System.out.println("-------------");
		int num = s.nextInt();
		if(num%4==0 && num%100!=0 || num%400==0) {
			System.out.println("윤년입니다.");
		}
	}

}
