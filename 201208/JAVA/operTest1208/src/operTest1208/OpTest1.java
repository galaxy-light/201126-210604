package operTest1208;

public class OpTest1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num1 = 2, num2 = 3, num3 = 4;		
		/*
		 * 연산자 우선순위
		 * () > *,/ > +,-
		 */
		int result1 = num1 + num2 - num3;
		System.out.println("result1 : " + result1);
		
		// 괄호를 먼저 처리
		int result2 = num1 + (num2 - num3);
		System.out.println("result2 : " + result2);
		
		// 곱셈을 먼저 처리
		int result3 = num1 + num2 * num3;
		System.out.println("result3 : " + result3);
		
		// 괄호를 먼저 처리
		int result4 = (num1 + num2) * num3;
		System.out.println("result4 : " + result4);
		
		// 곱셈을 먼저 처리
		int result5 = num1 * num2 / num3;
		System.out.println("result5 : " + result5);
		
		/* % : 나머지 연산자
		 *  @ % 2 : 0, 1 : 2로 나눈다면 자신(2)를 제외한 0부터 하위 숫자가 나머지로 나옴
		 *  @ % 3 : 0, 1, 2 : 3로 나눈다면 자신(3)를 제외한 0부터 하위 숫자가 나머지로 나옴
		 *  @ % 4 : 0, 1, 2, 3 : 4로 나눈다면 자신(4)를 제외한 0부터 하위 숫자가 나머지로 나옴
		 */
		int result6 = num3 % num2;
		// 4 % 3
		System.out.println("result6 : " + result6);
	}

}
