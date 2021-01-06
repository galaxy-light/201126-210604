package switch1215;

import java.util.Scanner;

public class Switch_T03_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("--------------------------------");
		System.out.println("담배 자판기 v1.0");
		System.out.println("--------------------------------");
		System.out.println("원하는 담배를 메뉴에서 선택하세요");
		System.out.println("1. 에쎄 골든 리프  6,000원");
		System.out.println("2. 에쎄 스페셜 골드 5,000원");
		System.out.println("3. 더원 블루      6,000원");
		System.out.println("4. 더원 오렌지    4,500원");
		System.out.println("5. 더원 화이트    4,500원");
		System.out.print("담배를 선택하세요 : ");
		Scanner s = new Scanner(System.in);
		int menu = s.nextInt();
		
		switch (menu) {
		case 1 :
			System.out.println("1. 에쎄 골든 리프를 선택하셨습니다.");
			break;
		case 2 :
			System.out.println("2. 에쎄 스페셜 골드를 선택하셨습니다.");
			break;
		case 3 :
			System.out.println("3. 더원 블루를 선택하셨습니다.");
			break;
		case 4 :
			System.out.println("4. 더원 오렌지를 선택하셨습니다.");
			break;
		case 5 :
			System.out.println("5. 더원 화이트를 선택하셨습니다.");
			break;
		default :
			System.out.println("잘못된 입력값입니다.");
		}
		System.out.println("-------------------------------");
		System.out.print("금액을 투입하세요.");
		int input = s.nextInt();
		int namg = 0;
		
		switch (menu) {
		case 1 : // 에쎄 골든 리프 6000
			namg = input - 6000;
			if (namg > 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + namg +"원을 받으세요.");
			}
			else if (namg == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액 " +  Math.abs(namg) + "을 투입하세요."); // Math.abs : 절대값을 만드는 메서드
			}
			break;
		case 2 : // 에쎄 스페셜 골드 5000
			namg = input - 5000;
			if (namg > 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + namg +"원을 받으세요.");
			}
			else if (namg == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액 " + Math.abs(namg) + "을 투입하세요."); // Math.abs : 절대값으로 만들어주는 메서드
			break;
		}
		case 3 : // 더원 블루 6000
			namg = input - 6000;
			if (namg > 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + namg +"원을 받으세요.");
			}
			else if (namg == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액 " +  Math.abs(namg) + "을 투입하세요."); // Math.abs : 절대값으로 만들어주는 메서드
			break;
			}
		case 4 : // 더원 오렌지
			namg = input - 4500;
			if (namg > 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + namg +"원을 받으세요.");
			}
			else if (namg == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액 " +  (namg*(-1)) + "을 투입하세요."); // (namg*(-1)) : 음수를 양수로 바꾸는 방법
			break;
			}
		case 5 : // 더원 화이트
			namg = input - 4500;
			if (namg > 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈 " + namg +"원을 받으세요.");
			}
			else if (namg == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액 " +  (namg*(-1)) + "을 투입하세요."); // (namg*(-1)) : 음수를 양수로 바꾸는 방법
			break;	
			}
			s.close();
		}

	}

}


