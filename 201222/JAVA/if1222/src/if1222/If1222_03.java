package if1222;

import java.util.Scanner;

public class If1222_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("--------------------");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("--------------------");
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 : ");
		String a = s.next();
		// equals : 문자 비교 
		if(a.equals("+")) {
			int hap = num1+num2;
			System.out.println(num1 + a + num2 + "=" + hap);
		}
		else if(a.equals("-")) {
			int hap = 0;
			hap = num1-num2;
			System.out.println(num1 + a + num2 + "=" + hap);
		}
		else if(a.equals("*")) {
			int hap = 0;
			hap = num1*num2;
			System.out.println(num1 + a + num2 + "=" + hap);
		}
		else if(a.equals("/")) {
			int hap = 0;
			hap = num1/num2;
			System.out.println(num1 + a + num2 + "=" + hap);
		}
		else {
			System.out.println("잘못된 입력값!");
		}
	}

}
