import java.util.Scanner;

public class Input7 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner a = new Scanner(System.in);
		
		// final : 상수 : 절대 변하지 않는 값
		final int b = 40;
		System.out.println("화씨 온도 입력 : " + b);
		
		System.out.print("섭씨 온도 입력 : ");
		double c = a.nextDouble();
		
		double d = (b-32)/1.8;
		System.out.print("화씨 온도를 섭씨 온도로 변환 : " + d);
		
		a.close();
	}

}
