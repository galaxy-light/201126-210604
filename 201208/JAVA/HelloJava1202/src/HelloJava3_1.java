
public class HelloJava3_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 1bit : 컴퓨터의 최소 단위
		// 1byte : 8bit, 0 또는 1이 들어감(기계어) 2의 1승부터 2의 8승 = 1024bit
		byte num = 'A'; 
				
		// short는 int의 절반
		short char1 = 'B';
		char char2 = 67; // char은 문자 타입이기때문에 67이 아스키코드로 변환됨
		// long는 int의 두배
		long num2 = 98765134512l; // int 범위를 넘었기 때문에 숫자 마지막 자리에 l을 붙여줌
		
		System.out.println("num : " + num); // 결과값이 65 뜨는데 이 경우는 아스키코드로 뜬 것
		System.out.println("char1 : " + char1); // B -> 아스키코드로 변환
		System.out.println("char2 : " + char2); // 67 -> 아스키코드로 변환
		System.out.println("num2 : " + num2);
		
		int result = num + 32;
		// 괄호안이 복잡할때는 println보다 printf가 더 편함
		System.out.printf("num + 30 = %d\n", result); //%d의 의미는 10진수 / num이 65로 변환되었으니 그 값을 넣고 65 + 30 = 97
		System.out.printf("result : %c\n", result); //%c의 의미는 문자 // result = 65 -> a(아스키코드)로 변환
		

	}

}
