package switch1215;

import java.io.IOException;
import java.util.Scanner;

public class Switch_T01_01 {

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
		System.out.println("---------------------------");
		System.out.print("메뉴를 선택하세요 : ");
		Scanner s = new Scanner(System.in);
		char ch = (char)System.in.read(); 
		/* System.in.read(); : 메서드기 때문에 이것만 적으면 오류, 타입 오류를 맞춰주면 됨
		 * -> (char)System.in.read(); -> 마우스를 대고 add throws declaration 선택
		 */
		System.out.println("입력받은 문자 : " + ch);
		
		switch(ch) {
		case 'a' :
			System.out.println("김치찌개를 선택하셨습니다.");
			break;
		case 'b' :
			System.out.println("된장찌개를 선택하셨습니다.");
			break;
		case 'c' :
			System.out.println("칼국수를 선택하셨습니다.");
			break;
		case 'd' :
			System.out.println("잔치국수를 선택하셨습니다.");
			break;
		case 'e' :
			System.out.println("비빔밥을 선택하셨습니다.");
			break;
		default :
			System.out.println("없는 메뉴를 선택하셨습니다.");
		}

	}

}
