// https://blog.naver.com/hack4ork/221671486484
import java.util.Scanner;

public class Test07_method_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("국어 점수 입력 : ");
		int ko = s.nextInt();
		System.out.print("영어 점수 입력 : ");
		int en = s.nextInt();
		System.out.print("수학 점수 입력 : ");
		int ma = s.nextInt();
		for (int i = 0; i < 1; i++) {
			if (((0<=ko)&&(ko<=100))&&((0<=en)&&(en<=100))&&((0<=ma)&&(ma<=100))) {
				System.out.println("국어 점수 : " + ko);
				System.out.println("영어 점수 : " + en);
				System.out.println("수학 점수 : " + ma);
			}
			else {
				System.out.println("잘못된 입력값!(0 ~ 100사이를 입력하세요.)");
				break;
			}
		}	
		
		func(ko, en, ma);
		s.close();
	}	
	
	public static void func(int ko, int en, int ma) {
		int sum = 0;
		int avg = 0;
		
		sum = ko+en+ma;
		avg = sum/3;
		
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + avg);
	}
	
}
