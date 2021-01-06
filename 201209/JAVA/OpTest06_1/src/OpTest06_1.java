import java.util.Scanner;

public class OpTest06_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 초기값 0으로 설정
		int coin500 = 0;
		int coin100 = 0;
		int coin50 = 0;
		int coin10 = 0;
		
		Scanner s = new Scanner(System.in);
		System.out.print("금액을 입력하세요 : ");
		int input = s.nextInt();
		coin500 = input / 500; // 500원 개수
		int namg1 = input % 500; // 500원으로 나누지 못한 나머지
		System.out.println("500원 나머지 : " + namg1);
		
		coin100 = namg1 / 100; // 100원 개수
		int namg2 = namg1 % 100; // 100원으로 나누지 못한 나머지
		System.out.println("100원 나머지 : " + namg2);
		
		coin50 = namg2 / 50; // 50원 개수
		int namg3 = namg2 % 50; // 50원으로 나누지 못한 나머지
		System.out.println("50원 나머지 : " + namg3);
		
		coin10 = namg3 / 10; // 10원 개수
		int namg4 = namg3 % 10; // int namg4 %= 100; <- 이런 방식으로도 사용 가능 // 10원으로 나누지 못한 나머지
		System.out.println("10원 나머지 : " + namg4);
		
		
		System.out.println("------------------");
		System.out.println("동전 교환기 프로그램 1.0");
		System.out.println("------------------");
		System.out.println("오백원 개수		: " + coin500 + "개");
		System.out.println("백원 개수		: "+ coin100 +"개");
		System.out.println("오십원 개수		: " + coin50 +"개");		
		System.out.println("십원 개수		: " + coin10 +"개");
		System.out.println("바꾸지 못한 잔돈	: " + namg4 +"원");
		System.out.println("------------------");
		
		s.close();		

	}

}
