import java.util.Scanner;

public class Method_t04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 국어, 영어, 수학 점수를 입력받아 총점과 평균값을 구하는 프로그램
		Scanner s = new Scanner(System.in);
		System.out.print("국어 : ");
		int ko = s.nextInt();
		System.out.print("영어 : ");
		int en = s.nextInt();
		System.out.print("수학 : ");
		int ma = s.nextInt();
		
		if ((0<=ko)&&(ko<=100)&&(0<=en)&&(en<=100)&&(0<=en)&&(en<=100)) {
			System.out.println(ko + " "+ en + " "+ ma + " ");
		}		
		else {
			System.out.println("잘못된 입력값");
		}
		
		func(ko, en, ma);
	}
	
	public static void func(int num1, int num2, int num3) {
		int hap = 0;		
		hap = hap + num1 + num2 + num3;
		System.out.println("총점 : " + hap);
		
		int avg = 0;
		avg = (num1 + num2 + num3)/3;
		System.out.println("평균 : " + avg);
	}
}	


	

