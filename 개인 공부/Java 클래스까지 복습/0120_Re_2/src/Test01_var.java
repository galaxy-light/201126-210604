import java.util.Scanner;

// https://blog.naver.com/hack4ork/221682675581
public class Test01_var {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 1번, 원의 면적
		final double pi = 3.14;
		int num = 5;
		System.out.println("원의 면적 : "+num+"*"+num+"*"+pi+"="+num*num*pi);
		
		
		// 2번, 5-3번
		Scanner s = new Scanner(System.in);
		System.out.print("국어 입력 : ");
		int ko = s.nextInt();
		System.out.print("영어 입력 : ");
		int en = s.nextInt();
		System.out.print("수어 입력 : ");
		int ma = s.nextInt();
		System.out.print("과학 입력 : ");
		int si = s.nextInt();		
		int sum = ko+en+ma+si;
		double avg = sum/4;
		System.out.println("총점 :" + sum);
		System.out.println("평균 :" + avg);
		
		s.close();
	}

}
