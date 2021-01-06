package operTest1208;

public class OpTest5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 메서드 안에서 선언된 변수에 초기값이 없으면 이상한 값이 들어감		
		// 3항 연산자
		int num1 = 10;
		int num2 = 15;
		String str = "";
		/* 물음표 앞에 있는 조건을 먼저 찾음
		* 11 >= 15
		* 참이면 "num1이 크다"가 동작하고
		* 거짓이면 "num2가 크다"가 동작함
		*/
		str = (++num1 >= num2) ? "num1이 크다" : "num2가 크다";
		System.out.println(str);
			

	}

}
