package if1209;

import java.util.Scanner;

public class If1209_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 입력 : ");
		int num = s.nextInt();
		
		if (num%2 == 1) {	// if (num%2 != 1)로도 쓸 수 있음							
			System.out.println("홀수입니다.");
		}
		else {
			System.out.println("짝수입니다.");
		}
		
		s.close();

	}

}
