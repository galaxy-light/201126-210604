package switch1215;

import java.util.Scanner;

public class Switch_T03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);			
		System.out.println("-------------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("원하는 담배를 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프  6,000원");
		System.out.println("2. 에쎄 스페셜 골드 5,000원");
		System.out.println("3. 더원 블루      6,000원");
		System.out.println("4. 더원 오렌지    4,500원");
		System.out.println("5. 더원 화이트    4,500원");
		System.out.println("------------------------");
		System.out.print("담배를 선택하세요.");		
		int n = s.nextInt();
		String b = null;
		int a = 0;
		switch(n) {
		case 1 :
			System.out.println("에쎄 골든 리프를 선택하셨습니다.");
			a = 6000;
			b = "에쎄 골든 리프";
			break;		
		case 2 :
			System.out.println("에쎄 스페셜 골드를 선택하셨습니다.");
			a = 5000;
			b = "에쎄 스페셜 골드";
			break;		
		case 3 :
			System.out.println("더원 블루를 선택하셨습니다.");
			a = 4500;
			b = "더원 블루"; 
			break;		
		case 4 :
			System.out.println("더원 오렌지를 선택하셨습니다.");
			a = 4500;
			b = "더원 오렌지";
			break;	
		case 5 :
			System.out.println("더원 화이트를 선택하셨습니다.");
			a = 4500;
			b = "더원 화이트";
			break;
		default :
			System.out.println("잘못된 입력값");
			break;
		}	
		System.out.println("------------------------");
		System.out.print("담배 금액을 입력하세요 : ");
		int n2 = s.nextInt();
		//
		int result = n2-a;		
		System.out.println(b + "(을)를 구매하셨습니다. 거스름돈 " + result + "원을 받으세요.");
		
		s.close();

	}

}
