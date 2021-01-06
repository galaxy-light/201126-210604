
public class HelloJava4_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		byte b = 127;
		int i = 100;
		
		// 타입 변환(형변환, 타입 캐스팅)
		// b가 자동으로 int 타입으로 변환
		System.out.println(b + i);
		
		int num = 10, num2 = 4; // 한꺼번에 하는 방법도 있지만 하나씩 하는걸 권장함
		// int num 10;
		// int num2 = 4;
		System.out.println(10 / 4); // 결과값으로 2가 뜨는데 10과 4가 int(정수)이기 때문에 소수점 이하는 절삭됨, 변수를 써도 결과값은 동일함
		System.out.println(num / num2);
		
		// 4가 자동으로 4.0으로 변환
		System.out.println(10.0 / 4); // 실수와 정수기 때문에 실수로 출력됨
		
		// 강제 형변환
		// 강제 형변환은 패턴이 정해져있음
		System.out.println((char)65); // 숫자이지만 문자로 강제 형변환(아스키코드 이용)
		System.out.println((int)2.9 + 1.8); // int2.9는 int를 사용했기 때문에 2로 변환됨 -> 2+1.8
		System.out.println((int)(2.9 + 1.8)); // int에 둘다 묶였기때문에 3으로 결과값 도출
		System.out.println((int)2.9 + (int)1.8); // int2.9 -> 2, int1.8 -> 1 => 2+1=3
		

	}

}
