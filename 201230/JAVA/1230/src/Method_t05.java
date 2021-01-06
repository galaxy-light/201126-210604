import java.util.Scanner;

public class Method_t05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 1개의 숫자를 입력 받아 구구단을 출력하는 프로그램
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int num1 = s.nextInt();
		
		func(num1);
	}
		
	public static void func(int num1) {		
			for (int i = 1; i <= 9; i++) {
				int num = num1*i;
				System.out.println(num1 + "*" + i + "=" + num);
			}
		
	}
}
