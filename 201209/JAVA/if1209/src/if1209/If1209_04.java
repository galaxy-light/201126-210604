package if1209;

import java.util.Scanner;

public class If1209_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("점수를 입력 : ");
		int num = s.nextInt();
		
		if (100 >= num && num >= 90) {            // && : 둘다 참이어야 참
			System.out.println("A학점");
		}
		else if (98 >= num && 80 <= num) {
			System.out.println("B학점");
		}
		else {
			System.out.println("A, B 제외 학점");
		}
		
		s.close();
	}

}
