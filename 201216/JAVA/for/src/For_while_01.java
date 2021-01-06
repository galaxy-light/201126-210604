import java.util.Scanner;

public class For_while_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/* 초기값;
		 * while(조건) {
		 * 	 	실행값;
		 * 		증가또는감소;
		 * }
		 * 
		 */
		int i = 0;
		while(i<10) {
			System.out.println(i);
			i++;
		}		
		
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int a = s.nextInt();
		a = 0;
		while(a<10) {
			System.out.println(a);
			a++;
		}
		s.close();
	}

}
