
public class Method_01 {
	static int func() {
		System.out.println("값을 반환하는 메서드");		
		return 100; // 타입과 리턴값 일치
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num = func();
		System.out.println("num : " + num); // System.out.println("num : " + func()); 이렇게도 쓸 수 있음
	}

}
