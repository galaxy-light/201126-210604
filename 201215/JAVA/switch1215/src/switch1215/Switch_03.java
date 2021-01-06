package switch1215;

import java.util.Scanner;

public class Switch_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력 : ");		
		double op1 = s.nextDouble();
		System.out.print("연산식 입력 : ");
		String oper = s.next();
		System.out.print("두번째 숫자 입력 : ");		
		double op2 = s.nextDouble();
		double result = 0;
		switch (oper) {
		case "+" :
			result = op1 + op2;
			break;
		case "-" :
			result = op1 - op2;
			break;
		case "*" :
			result = op1 * op2;
			break;
		case "/" :			
			if (op2 == 0) { // case 안에 if 사용 가능
				System.out.println("분모 0 에러!");
				s.close(); // s.close();가 죽은 코드가 되지 않게 하려면 여기에 적어주면 됨
				// 실행 프로그램 강제 종료
				System.exit(0); // System.exit(0);이 있어서 저기에 걸리면 s.close();은 죽은 코드가 됨
			}
			result = op1 / op2;
			break;
		default :
			System.out.println("잘못된 연산자 입력");
			s.close(); // s.close();가 죽은 코드가 되지 않게 하려면 여기에 적어주면 됨
			System.exit(0);
		}
		System.out.println("결과값 : " + result);
		s.close(); // System.exit(0);이 있어서 저기에 걸리면 s.close();은 죽은 코드가 됨
	}

}
