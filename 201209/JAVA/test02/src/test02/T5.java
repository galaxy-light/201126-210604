package test02;

import java.util.Scanner;

public class T5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner n = new Scanner(System.in);
		System.out.print("국어 점수를 입력하세요 : ");
		int ko = n.nextInt();
		System.out.print("수학 점수를 입력하세요 : ");
		int ma = n.nextInt();
		System.out.print("영어 점수를 입력하세요 : ");
		int en = n.nextInt();
		
		int su = ko+ma+en;
		int ev = (ko+ma+en)/3;
		System.out.println("총점 : " + su + "점");
		System.out.println("평균 : " + ev + "점");
		
		if (ev <= 100 && ev >= 90) {
			System.out.println("A");
		}
		else if (ev <= 89 && ev >= 80) {
			System.out.println("B");
		}
		else if (ev <= 79 && ev >= 70) {
			System.out.println("C");
		}
		else if (ev <= 69 && ev >= 0) {
			System.out.println("D");
		}
		n.close();
	}

}
