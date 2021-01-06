package switch1215;

import java.io.IOException;

public class Switch_T01 {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub		
		System.out.println("---------------------------");
		System.out.println("식당 메뉴 자동 주문 프로그램 v1.0");
		System.out.println("---------------------------");
		System.out.println("원하는 식사를 선택하세요");
		System.out.println("a. 김치찌개 : 5,000원");
		System.out.println("b. 된장찌개 : 5,000원");
		System.out.println("c. 칼국수  : 4,500원");
		System.out.println("d. 잔치국수 : 4,000원");
		System.out.println("e. 비빔밥  : 5,000원");
		System.out.print("메뉴를 선택하세요 : ");
		char str = (char)System.in.read();		
		switch (str) {
		case 'a' :
			System.out.println("김치찌개를 주문했습니다.");			
			break;
		case 'b' :
			System.out.println("된장찌개를 주문했습니다.");			
			break;
		case 'c' :
			System.out.println("칼국수를 주문했습니다.");				
			break;
		case 'd' :
			System.out.println("잔치국수를 주문했습니다.");				
			break;
		case 'e' :
			System.out.println("비빕밥을 주문했습니다.");				
			break;
		default :
			System.out.println("잘못된 입력값");
			break;
		}
		
	}

}

