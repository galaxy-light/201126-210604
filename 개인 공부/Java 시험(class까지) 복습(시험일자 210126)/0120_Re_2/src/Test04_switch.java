import java.io.IOException;
import java.util.Scanner;

// https://blog.naver.com/hack4ork/221690105166
public class Test04_switch {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		// 1번
		System.out.print("a, b, c, d, e 중 하나 입력 : ");
		char str = (char) System.in.read();
		System.in.read();
		switch (str) {
		case 'a': 
			System.out.println("a. 김치찌개");
			break;		
		case 'b': 
			System.out.println("b. 된장찌개");
			break;		
		case 'c': 
			System.out.println("c. 칼국수");
			break;		
		case 'd': 
			System.out.println("d. 잔치국수");
			break;		
		case 'e': 
			System.out.println("e. 비빔밥");
			break;		
		default:
			System.out.println("잘못된 입력값!");
			break;
		}

		// 2번
		Scanner s = new Scanner(System.in);
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num1 입력 : ");
		int num2 = s.nextInt();
		System.out.print("+, -, *, / 중 연산자 하나 입력 : ");
		String st = s.next();
		switch (st) {
		case "+": 
			System.out.println(num1 + "+" + num2 + "=" + num1 + num2);
			break;		
		case "-":
			System.out.println(num1 + "+" + num2 + "=" + num1 + num2);
			break;
		case "*":
			System.out.println(num1 + "*" + num2 + "=" + num1 * num2);
			break;
		case "/":
			System.out.println(num1 + "/" + num2 + "=" + num1 / num2);
			break;
		default:
			System.out.println("잘못된 입력값!");
			break;
		}
		
		
		// 3번
		System.out.print("투입 금액 : ");
		int insert = s.nextInt();
		System.out.print("1, 2, 3 중 음료수 하나 입력 : ");
		int num3 = s.nextInt();
		int price = 0;
		switch (num3) {
		case 1:
			System.out.println("커피");
			price = 1000;
			break;
		case 2:
			System.out.println("탄산");
			price = 1500;
			break;
		case 3:
			System.out.println("주스");
			price = 2000;
			break;
		default:
			System.out.println("잘못된 입력값!");
			break;
		}				
		int res = insert-price;
		System.out.println("거스름돈 : " + res);
		
		s.close();
	}
}
