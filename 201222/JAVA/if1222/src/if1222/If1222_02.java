package if1222;

import java.util.Scanner;

public class If1222_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num2 = s.nextInt();
		
		if(num1>num2) {
			System.out.println("num1이 num2보다 크다.");
		}
		else if(num1<num2) {
			System.out.println("num1이 num2보다 작다.");
		}
		else if(num1==num2) {
			System.out.println("num1과 num2는 같다.");
		}

	}

}
