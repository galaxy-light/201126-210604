import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 반지름을 사용자가 입력
		Scanner c = new Scanner(System.in);
		System.out.print("원의 반지름 입력 : ");
		float d = c.nextFloat();
		// final : 상수 : 절대 변하지 않는 값
		final float pi = 3.14f;
		// 원의 면적 = 반지름*반지름*pi
		float e = d * d * pi;
		System.out.println("원의 면적 : " + e);
		c.close();
		
	}

}
