
public class Method_01 {

	// 프로그램의 시작점은 main
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 순서 : 8라인->9라인->19라인->20라인->21라인->10라인->12라인->반복(13라인->14라인->19라인->20라인)->종료
		System.out.println("func() 호출전");
		func(); // 메서드 사용(호출)
		System.out.println("func() 호출후");
		
		System.out.println("반복문 메서드 호출");
		for (int i = 0; i < 5; i++) {
			func();
		}
	}
	
	// 메서드 정의 : class 안에 반드시 적어야 됨
	public static void func() {
		System.out.println("메서드 사용");
	}
}
