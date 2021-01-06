package if1209;

import java.util.Scanner;

public class If1209_09 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);	
		
		System.out.println("-----------------------");
		System.out.println("년도별 윤년 구분 프로그램 v1.0");
		System.out.println("-----------------------");
		System.out.print("년도 입력 : ");
		int a = s.nextInt();
				
		if ((a%4 == 0 && a%100 != 0) || (a%400 == 0)) {
			System.out.println("입력한 년도는 윤년입니다.");
		}
		else {
			System.out.println("입력한 년도는 윤년이 아닙니다.");		
		}
		s.close();
	}
}