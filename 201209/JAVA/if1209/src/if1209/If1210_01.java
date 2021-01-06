package if1209;

import java.util.Scanner;

public class If1210_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		
		System.out.print("국어 점수 입력 : ");
		int ko = s.nextInt();
		System.out.print("영어 점수 입력 : ");
		int en = s.nextInt();
		System.out.print("수학 점수 입력 : ");
		int ma = s.nextInt();
		
		int to = ko+en+ma;
		int ev = (ko+en+ma)/3;
		
		System.out.println("------------------");
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println("------------------");
		System.out.println("총점 : " + to);
		System.out.println("평균 : " + ev);
		if ( 100 >= ev && 90 <= ev ) {
			System.out.println("A학점");
		}
		else if ( 89 >= ev && 80 <= ev ) {
			System.out.println("B학점");
		}
		else if ( 79 >= ev && 70 <= ev ) {
			System.out.println("C학점");
		}
		else if ( 69 >= ev && 60 <= ev ) {
			System.out.println("D학점");
		}
		else if ( 59 >= ev && 50 <= ev) {
			System.out.println("E학점");
		}
		else if ( 49 >= ev && 0 <= ev) {
			System.out.println("F학점");
		}
		s.close();		
	}	
}
