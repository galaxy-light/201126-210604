import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner b = new Scanner(System.in);
		System.out.print("주행거리 입력 : ");
		double juhang = b.nextDouble();
		System.out.print("사용한 휘발유 양 입력 : ");
		double fuels = b.nextDouble();
		// 연비 구함
		// / : 나누기 연산자
		double yeonbi = juhang / fuels;
		System.out.println("차량 연비 : " + yeonbi);
		b.close();
		

	}

}
