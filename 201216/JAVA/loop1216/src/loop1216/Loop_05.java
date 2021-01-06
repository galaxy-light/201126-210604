package loop1216;

import java.util.Scanner;

public class Loop_05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("원하는 구구단 입력 : ");
		int gugu = s.nextInt();
		
		for (int i=0; i<9; i++) {
			System.out.printf("%dX%d=%d\n", gugu, i+1, gugu*(i+1));
			// %d : gugu / %d : i+1 / %d\n : gugu*(i+1) 치환
			// System.out.println(gugu + "X" + (i+1) + "=" + gugu*(i+1)); <- println을 사용하려면 이렇게 쓰면 됨
		}
			
	}

}
