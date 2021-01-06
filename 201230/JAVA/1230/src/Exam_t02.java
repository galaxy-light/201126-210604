import java.util.Scanner;

public class Exam_t02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 입력받은 수의 팩토리얼을 구하는 프로그램
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int n = s.nextInt();
		
		int result = factorial(n);
		System.out.println(n + "!=" + result);
	}	
	
	public static int factorial(int n) {
		if (n == 1) {
			return 1;
		}
		else {
			return n * factorial(n-1);
		}
	}
}
