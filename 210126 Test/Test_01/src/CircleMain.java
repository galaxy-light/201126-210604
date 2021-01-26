import java.util.Scanner;

public class CircleMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("원의 반지름 입력 : ");
		int rad = s.nextInt();	
		if (rad<0) {
			System.out.println("음수 입력!");
			System.exit(0);
		}
		
		Circle Circle = new Circle(rad);
		Circle.showCircleInfo();		
		s.close();
	}
	
}

class Circle {
	double rad = 0;
	final double PI = 3.14;
	
	// 기본 생성자
	public Circle(double rad) {
		super();
		this.rad = rad;
	}

	// getter setter
	public double getRad() {
		return rad;
	}

	public void setRad(double rad) {
		this.rad = rad;
	}

	public double getPI() {
		return PI;
	}

	public void showCircleInfo () {
		System.out.println("원의 넓이 : " + (rad*rad)*PI);
	}

	
	
}