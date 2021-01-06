package if1215;

import java.util.Scanner;

public class If_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("국어 점수 입력 : ");
		int ko = s.nextInt();
		System.out.print("영어 점수 입력 : ");
		int en = s.nextInt();
		System.out.print("수학 점수 입력 : ");
		int ma = s.nextInt();
		
		
		int sum = ko+en+ma;
		System.out.println("총점 : " + sum);
		int ave = (ko+en+ma)/3;
		System.out.println("평균 : " + ave);
		
		if (100>=ave && ave>=90) {
			System.out.println("A학점");
		}
		else if (90>ave && ave>=80) {
			System.out.println("B학점");
		}
		else {
			System.out.println("A, B를 제외한 학점");
		}
		s.close();
	}

}
