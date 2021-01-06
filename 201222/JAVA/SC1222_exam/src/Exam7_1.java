import java.util.Scanner;

public class Exam7_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		while(true) {
		System.out.println("----------------------");
		System.out.println("간단한 파일 관리 프로그램 1.0");
		System.out.println("----------------------");
		System.out.println("1. 파일 생성 및 쓰기");
		System.out.println("2. 파일 읽기");
		System.out.println("3. 프로그램 종료");
		System.out.println("--------------------");
		System.out.print("메뉴를 선택하세요 : ");
		int menu = s.nextInt();
		switch(menu){
			case 1:
				System.out.println("파일 생성 및 쓰기 예제입니다.");
				break;
			case 2:
				System.out.println("파일에서 내용 읽어오기");
				break;
			case 3:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 입력값!");
				break;
		}
		
	}

}
}