import java.util.Scanner;

// https://blog.naver.com/hack4ork/221682679110
public class Test02_alg {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 삼항연산자 => 조건?참:거짓
		// 1번
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int num = s.nextInt();		
		String result1 = num%2==0?"짝수":"홀수";
		System.out.println(num + " : " + result1);
		
		
		// 2번
		int a = 0;
		int b = 0;
		int c = 0;
		System.out.print("숫자 1 : ");
		a = s.nextInt();
		System.out.print("숫자 2 : ");
		b = s.nextInt();
		System.out.print("숫자 3 : ");
		c = s.nextInt();
		int max = 0;
		int min = 0;
		max = a>b?a:b;
		max = max>c?max:c;
		System.out.println("최대값 : " + max);
		min = a<b?b:a;
		min = min<c?min:c;
		System.out.println("최소값 : " + min);
		
		
		// 3번
		int num1 = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		num1 = 500;
		num2 = 100;
		num3 = 50;
		num4 = 10;
		System.out.print("금액 투입 : ");
		int insert = s.nextInt();	
		int result2 = insert/500;
		System.out.println("오백원 개수 : " + result2);
		int result3 = insert%500;
		System.out.println("잔돈 : " + result3);
		int result4 = result3/100;
		System.out.println("백원 개수 : " + result4);
		int result5 = result3%100;
		System.out.println("잔돈 : " + result5);
		int result6 = result5/50;
		System.out.println("오십원 개수 : " + result6);
		int result7 = result5%50;
		System.out.println("잔돈 : " + result7);
		int result8 = result7/10;
		System.out.println("십원 개수 : " + result8);
		int result9 = result7%10;
		System.out.println("바꾸지 못하는 잔돈 : " + result9);
		
		s.close();
	}

}
