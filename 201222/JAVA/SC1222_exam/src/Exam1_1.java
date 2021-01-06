import java.util.Scanner;

public class Exam1_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// for
		Scanner s = new Scanner(System.in);
		System.out.println("------------------");
		System.out.println("짝수, 홀수 구분 프로그램");
		System.out.println("------------------");
		for(int i=0; i<5; i++) {
			System.out.print((i+1) + ".num" + (i+1) + ":");
			int num = s.nextInt();
			if(num%2==0) {
				System.out.println("짝수");
			}
			else {
				System.out.println("홀수");
			}
		}
		s.close();
	}
}
