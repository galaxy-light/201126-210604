import java.util.Scanner;

public class Input2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner a = new Scanner(System.in);
		System.out.print("첫번째 정수값 입력 : ");
		// ()가 있으면 메서드
		// 앞이 정수 타입이면 next뒤에 오는 것도 정수
		int num1 = a.nextInt();
		System.out.print("두번째 정수값 입력 : ");
		int num2 = a.nextInt();
		System.out.print("세번째 정수값 입력 : ");
		int num3 = a.nextInt();
		
		int sum = num1 + num2 + num3;
		int ave = sum / 3;
		
		System.out.println("합계 : " + sum);
		System.out.println("평균 : " + ave);
		a.close();
		
	}

}
