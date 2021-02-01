import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("1.원 반지름 입력 :");
		Circle circle = new Circle(s.nextInt());
		System.out.println(circle.getArea());
		
		System.out.println("2.년도 입력 : ");
		zodiac zo = new zodiac();
		System.out.println("3.");
		Student std[] = new Student[2];
		std[0] = new Student("이동준","2009038033", "남");
		std[1] = new Student("이제영","2007012034", "여");
		for (int i = 0; i < std.length; i++) {
			std[i].showStdInfo();
		}
		System.out.println("-------------이동준학생 학번 변경----------");
		std[0].setHackbun("2019038033");
		for (int i = 0; i < std.length; i++) {
			std[i].showStdInfo();
		}
		System.out.println("4.문자열 입력 : ");
		String a = s.next();
		String moonja[] = a.split("");
		new Alphabet(moonja);
		
		System.out.println("4-1.문자열 입력 : ");
		String aa = s.next();
		String moonja1[] = aa.split("");
        new Alphabet2(moonja1);
		System.out.println();
        System.out.print("5.문자열 입력 : ");
        String str = s.next();
		new AlphaNum(str);
	}
}
