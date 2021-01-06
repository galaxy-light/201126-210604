import java.util.Scanner;

public class Exam4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		String a = "파일명 : test1.txt";
		while(true) {
			System.out.println("-----------------------");
			System.out.println("간단한 파일 관리 프로그램 v1.0");
			System.out.println("-----------------------");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2. 파일 읽기");
			System.out.println("3. 종료");
			System.out.println("-----------------------");
			System.out.print("메뉴를 선택하세요 : ");
			int menu = s.nextInt();
			switch(menu) {
			case 1:
				System.out.println(a);
				System.out.println("파일 내용 : 파일 생성 및 쓰기 예제입니다.");
				System.out.println("파일 생성이 성공하였습니다.");
				break;
			case 2:
				System.out.println(a);
				System.out.println("읽은 내용 : 파일 생성 테스트입니다.");
				System.out.println("파일 읽기가 성공하였습니다.");
				break;
			case 3:
				System.out.println(a);
				System.out.println("프로그램이 종료됩니다.");
				break;
			default:
				System.out.println("잘못된 입력값!");
				break;
			}
			s.close();
		}

	}

}
