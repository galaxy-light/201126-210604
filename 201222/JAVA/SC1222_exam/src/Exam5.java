import java.util.Scanner;

public class Exam5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------");
		System.out.println("간단 구구단 프로그램 v1.0");
		System.out.println("-------------------");
		System.out.print("1. 구구단 입력 : ");
		int num1 = s.nextInt();
		int num2 = 0;
		for(num2=1; num2<10; num2++) {
			int num3 = num1*num2;
			System.out.println(num1 + "X" + num2 + "=" + num3);
		}
		s.close();
	}

}
