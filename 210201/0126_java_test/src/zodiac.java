import java.util.Scanner;

public class zodiac {

	public zodiac() {
		Scanner s = new Scanner(System.in);
		int zodiac = s.nextInt();
		switch (zodiac % 12) {
		case 0:
			System.out.println("¿ø¼şÀÌ");
			break;
		case 1:
			System.out.println("´ß");
			break;
		case 2:
			System.out.println("°³");
			break;
		case 3:
			System.out.println("µÅÁö");
			break;
		case 4:
			System.out.println("Áã");
			break;
		case 5:
			System.out.println("¼Ò");
			break;
		case 6:
			System.out.println("È£¶ûÀÌ");
			break;
		case 7:
			System.out.println("Åä³¢");
			break;
		case 8:
			System.out.println("¿ë");
			break;
		case 9:
			System.out.println("¹ì");
			break;
		case 10:
			System.out.println("¸»");
			break;
		case 11:
			System.out.println("¾ç");
			break;
		}
	}

}
