import java.util.Scanner;

public class CircleMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		Circle circle = new Circle(s.nextInt());		
		System.out.println("rad : " + circle.getRad());
		System.out.println("area : " + circle.getArea());
	}

}