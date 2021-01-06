import java.util.Scanner;

public class Switch_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자 입력 : ");
		double num1 = s.nextDouble();
		System.out.print("연산자 입력 : ");
		String a = s.next();
		System.out.print("두번째 숫자 입력 : ");
		double num2 = s.nextDouble();
		double result = 0; // 초기값 설정
		switch(a) {
		case "+" :
			result = num1 + num2;
			System.out.println("결과값 : " + (int)result); // (int)result : 강제형변환
			break;
		case "-" :
			result = num1 - num2;
			System.out.println("결과값 : " + (int)result);
			break;
		case "*" :
			result = num1 * num2;
			System.out.println("결과값 : " + (int)result);
			break;			
		case "/" :
			if(num2 == 0) { // case 안에 if 사용 가능
				System.out.println("분모 에러");
				s.close(); // System.exit(0);가 하단에 있기 때문에 죽은 코드가 되지 않게 여기에 적음
				// 실행 프로그램 강제 종료
				System.exit(0);
			}
			result = num1 / num2;
			break;
		default :
			System.out.println("잘못된 입력값입니다.");
			s.close();
			System.exit(0);
		}
		
	}

}
