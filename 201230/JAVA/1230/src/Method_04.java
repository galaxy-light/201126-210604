
public class Method_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 순서 : 8라인->14라인->15라인->7라인->9라인
		int num = 10; // {}안에 선언되었기 때문에 아래 num변수에 영향을 주지 않음		
		func(num); // 매개변수로 10을 아래 func(int num)에 전달
		System.out.println("main() num : " + num); // 위의 int num = 10;를 받아 10 출력
	}
		
	public static void func(int num) {
		// int num = 20; 여기 num는 중복이기 때문에 오류 발생
		num = num + 1;
		System.out.println("func() num : " + num); // 전달 받은 10이 더해져 결과값 11 출력
	}
	

}
