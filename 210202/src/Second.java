import java.util.Scanner;

public class Second {

	public static void main(String[] args) {
		int year = 0;
		System.out.println("¾ğÁ¦ ÅÂ¾î³µ³Ä?");
		Scanner s = new Scanner(System.in);
		year = s.nextInt();
		switch (year%12) {
		case 0: 
			System.out.println("¿ø¼şÀÌ¶ì");
			break;
		case 1:
			System.out.println("´ß¶ì");
			break;
		case 2:
			System.out.println("°³¶ì");
			break;
		case 3:
			System.out.println("µÅÁö¶ì");
			break;
		case 4:
			System.out.println("Áã¶ì");
			break;
		case 5:
			break;
		case 6:
			break;
		case 7:
			break;
		case 8:
			break;
		case 9:
			break;
		case 10:
			break;
		case 11:
			break;
		
		}

	}

}
