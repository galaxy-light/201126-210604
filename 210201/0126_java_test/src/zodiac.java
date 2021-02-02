import java.util.Scanner;

public class zodiac {

	public zodiac() {
		Scanner s = new Scanner(System.in);
		int zodiac = s.nextInt();
		switch (zodiac % 12) {
		case 0:
			System.out.println("원숭이");
			break;
		case 1:
			System.out.println("닭");
			break;
		case 2:
			System.out.println("개");
			break;
		case 3:
			System.out.println("돼지");
			break;
		case 4:
			System.out.println("쥐");
			break;
		case 5:
			System.out.println("소");
			break;
		case 6:
			System.out.println("호랑이");
			break;
		case 7:
			System.out.println("토끼");
			break;
		case 8:
			System.out.println("용");
			break;
		case 9:
			System.out.println("뱀");
			break;
		case 10:
			System.out.println("말");
			break;
		case 11:
			System.out.println("양");
			break;
		}
	}
}
