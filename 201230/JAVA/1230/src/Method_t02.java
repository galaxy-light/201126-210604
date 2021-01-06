import java.util.Scanner;

public class Method_t02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 숫자 2개와 사칙연산자를 입력받아 동작하는 간단한 계산기 만들기
		Scanner s = new Scanner(System.in);
		int result;
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 : ");
		String a = s.next();
	
		
		int re = func(num1, num2, a);
	    System.out.printf("%d %s %d = %d", num1, a, num2, func(num1,num2,a));
	}
	
	public static int func(int num1, int num2, String a) {
		int result = 0;
		if (a.equals("+")) {			
			result = num1 + num2;
			// System.out.println(result);
		}
		else if (a.equals("-")) {
			result = num1 - num2;
			// System.out.println(result);
		}
		else if (a.equals("*")) {
			result = num1 * num2;
			// System.out.println(result);
		}
		else if (a.equals("/")) {
			result = num1 / num2;
			// System.out.println(result);
		}
		return result;		
	}	

}
