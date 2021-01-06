import java.util.Scanner;

public class Switch_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("1~12월 중 하나를 입력 : ");
		int mon = s.nextInt();
		switch (mon) {
		// case 입력 방법은 두 가지가 있음
		case 3 :
		case 4 :
		case 5 :
			System.out.println("봄입니다.");
			break;
		case 6 : case 7 : case 8 :
			System.out.println("여름입니다.");
			break;
		case 9 : case 10 : case 11 :
			System.out.println("가을입니다.");
			break;
		case 12 :
		case 1 :
		case 2 :
			System.out.println("겨울입니다.");
			break;
		default :
			System.out.println("잘못된 입력값입니다.");
			// break; 마지막이라서 생략함
		}
		s.close();
	}

}
