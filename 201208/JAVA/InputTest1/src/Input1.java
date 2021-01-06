import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Scanner : S 대문자 : Scanner라는 Class
		// Scanner 객체(s) 생성 : s라는 객체 생성 / * s 대신 다른 것을 적어도 됨
		// System.in 입력(키보드로부터 정보를 입력받겠다)
		// s에 노란줄이 뜨는데 경고라는 뜻(프로그램 작동에 영향은 없음) : s를 썼기때문에 닫아주어야한다 / * 빨간줄은 에러		
		Scanner s = new Scanner(System.in);
		// 마우스 커서가 print를 썼기때문에 이름 입력 : 옆에 뜸
		System.out.print("이름 입력 : ");
		// 이름이니까 String 사용(문자열)
		// 키보드로 문자열 입력 받음
		// s.nextLine()에 키보드로 입력한 것이 name로 저장됨
		// String이라서 next뒤에 오는것이 Line / next만 써도 됨
		String name = s.nextLine();
		
		System.out.print("나이 입력 : ");
		// 나이니까 int 사용(정수)
		// 키보드로 정수 입력 받음
		// s.nextInt()에 키보드로 입력한 것이 age로 저장됨
		int age = s.nextInt();
		
		System.out.println("이름 정보 : " + name);
		System.out.println("나이 정보 : " + age);
		
		// s.close();를 쓰면 s의 노란줄이 사라짐
		s.close();
	}

}
