// https://blog.naver.com/hack4ork/221671486484
import java.util.Scanner;

public class Test07_method_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("숫자 1 입력 : ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 : ");
		String str = s.next();
		
		func(num1, num2, str);
		s.close();
	}
	
	public static int func(int num1, int num2, String str) {
		int result = 0;
		switch (str) {
		case "+":
			result = num1+num2;
			System.out.println(num1+"+"+num2+"="+result);
			break;
		case "-":
			result = num1-num2;
			System.out.println(num1+"-"+num2+"="+result);
			break;
		case "*":
			result = num1*num2;
			System.out.println(num1+"*"+num2+"="+result);
			break;
		case "/":
			result = num1/num2;
			System.out.println(num1+"/"+num2+"="+result);
			break;
		default:
			System.out.println("잘못된 입력값!");
			break;
		}		
		return result;
	}
}
