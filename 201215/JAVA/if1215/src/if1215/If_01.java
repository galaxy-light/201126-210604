package if1215;

import java.util.Scanner;

public class If_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("num1 입력 : ");
		double op1 = s.nextDouble();
		System.out.print("num2 입력 : ");
		double op2 = s.nextDouble();
		System.out.print("연산자 입력 : ");
		String oper = s.next();
		double result = 0;
		
		if (oper.equals("+")) {
			result = op1 + op2;
			System.out.println(op1 + oper + op2 + "=" + result);
		}
		else if (oper.equals("-")) {
			result = op1 - op2;
			System.out.println(op1 + oper + op2 + "=" + result);
		}
		else if (oper.equals("*")) {
			result = op1 * op2;
			System.out.println(op1 + oper + op2 + "=" + result);
		}
		else if (oper.equals("/")) {
			result = op1 / op2;
			System.out.println((int)op1 + oper + (int)op2 + "=" + (int)result); // 강제형변환
			/* %d : 정수(int)로 치환 
			 * %s : 문자열(String)로 치환 
			 * %f : 실수(float)로 치환 
			 * \n : 줄 바꿈 
			 * \t : 탭키 삽입
			 */
			System.out.printf("%d %s %d = %d\n", (int)op1, oper, (int)op2, (int)result); // %d=op1 %s=oper %d=op2 = %d\n=result
		}
		s.close();
	}

}
