import java.util.Scanner;

public class Second {

	public static void main(String[] args) {
		int year = 0;
		System.out.println("���� �¾��?");
		Scanner s = new Scanner(System.in);
		year = s.nextInt();
		switch (year%12) {
		case 0: 
			System.out.println("�����̶�");
			break;
		case 1:
			System.out.println("�߶�");
			break;
		case 2:
			System.out.println("����");
			break;
		case 3:
			System.out.println("������");
			break;
		case 4:
			System.out.println("���");
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
