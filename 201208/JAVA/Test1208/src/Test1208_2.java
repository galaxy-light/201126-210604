import java.util.Scanner;

public class Test1208_2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 원의 반지름은 입력값
		Scanner a = new Scanner(System.in);
		System.out.print("원의 반지름 : ");
		double b = a.nextDouble();
		
		// 원주율=PI=3.14
		// final : 상수 : 고정된 값
		final float c =  3.14f;
		
		// 원의 면적=반지름*반지름*PI
		double d = b*b*c;
		System.out.println("원의 면적 : "+ d);
			
		a.close();

	}

}
