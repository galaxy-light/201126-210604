
public class Method_03 {
	// 예시를 들기 위해 num를 같은 변수로 썼지만 웬만하면 변수 이름은 달리 쓰는게 좋음
	static int num = 200; // 전역변수
	public static void func() {		
		int num = 100; // 지역변수
		System.out.println("func() num : " + num); // {}안에 선언된 변수는 {}안에서만 영향이 있음. 그래서 호출이 없다면 결과값에 영향을 주지 않음
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("main() num : " + num);
		func(); // 호출
	}

}
