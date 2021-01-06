package if1215;

import java.util.Scanner;

public class If_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("연도를 입력하세요 : ");
		int num = s.nextInt();
		
		if ((num%4 == 0 && num%100 !=0)||(num%400 == 0)){
			System.out.println("윤년입니다.");
		}
		else {
			System.out.println("평년입니다.");
		}
		s.close();
	}

}
