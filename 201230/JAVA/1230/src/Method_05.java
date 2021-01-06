
public class Method_05 {

	public static void divide(int num1, int num2) {
		// num1 : 분자, num2 : 분모
		if(num2 == 0) {  // if(!num2) 이렇게도 사용 가능
			System.out.println("0으로 나눌 수 없습니다.");
			return; // void 메서드에서 return을 사용하면 메서드 종료
			// System.exit(0);
			/*
			 * system.exit(0);와 return; 차이
			 * system.exit(0); : 프로그램 강제 종료
			 * return; : 현재 실행중인 메서드 탈출
			 */			
		}
		System.out.println("나눗셈 : " + (num1/num2));
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		divide(4, 2); // 4->num1 2->num2에 저장
		divide(4, 0); // 4->num1 0->num2에 저장
		System.out.println("main() 종료");
	}

}
