// 변수 타입만 다르지 활용은 같다
public class HelloJava2_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/* 문자열 저장 변수 String -> S 무조건 대문자
		* String 문자열 변수 타입
		* 문자열이기 때문에 "" 사용
		* String str에서 str 자리는 변수명 (변수명은 마음대로 작성 가능)
		* str과 STR은 다르다
		*/
		String str = "홍길동"; // 이름
		String STR = "홍길동";
		
		// 변수명은 연관성이 있는걸로 작성하는게 좋다
		// 변수명을 직관적으로 작성
		String name = "홍길동";
		
		/* String(문자열타입) 변수 선언, 변수 선언 필수 
		선언할 때 String name = "홍기동"; 과 String name;이 충돌하기 때문에 String name의 name에 구분을 지어주어야한다
		*/
		String name1;
		name1 = "홍길동";
		/* String name = "홍길동"; 과
		 * String name1; 
		 * name1 = "홍길동"; 은 같다
		 */
		
		/*
		 * 변수는 계속 바꿀 수 있다/횟수 제한X(변수 재사용) 
		 * 변수 선언을 무조건적으로 먼저 해야한다 => String name1;
		 */
		name1 = "홍길동";
		// 디버깅 / 디버깅의 방법 중 println 사용 / 디버깅을 습관화하는 것이 중요
		System.out.println("name1 : " + name1);		
		name1 = "박길동";
		System.out.println("name1 : " + name1);
		name1 = "최길동";
		System.out.println("name1 : " + name1);
		
		
		
		/* char 문자 타입 변수
		 * char 소문자 사용
		 * 문자이기 때문에 '' 사용
		 */
		char ch = '홍';
		// 변수 변경
		ch = 'A';
		
		
		/* int 숫자(정수) 타입 변수
		 * int 소문자 사용
		 */
		int num1 = 100;
		// long : int의 두배 크기
		// long num1 =
		
		
		
		/* float 숫자(실수) 타입 변수
		 * float 소문자 사용
		 */
		// float num2 = 1.5; 하면 1.5;에 빨간줄이 그이는데 이걸 수정하려면 1.5f;로 변경하던지 float를 double로 변경하면 된다.
		float num2 = 1.5f;
		// double : float의 두배 크기
		// double num2 =
		
	}

}
