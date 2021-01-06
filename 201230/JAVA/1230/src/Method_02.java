
public class Method_02 {
	// 메서드 정의는 main 위나 아래에 작성 가능
	public static void func1() {
		System.out.println("func1() 사용");
		// 메쏘드 내에서 다른 메서드 호출 가능
		func2();
	}
	
	public static void func2() {
		System.out.println("func2() 사용");
		func3();
	}
	
	public static void func3() {
		System.out.println("func3() 사용");		
	}
	
	
	// main도 메서드이기 때문에 다른 메서드 호출이 가능하나, main에서 main을 호출할 수는 없음
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		func1();
		System.out.println("모든 메서드 종료"); // 프로그램은 처음 호출한 곳에서 종료 됨
		
	}

}
