import java.util.Scanner;

// 입력되는 알파벳에 대하여 한글로 출력하는 프로그램 만들기
public class Test_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String str = s.next();
		s.close();
		
		char [] ch = new char[str.length()]; // str 크기만큼 배열 생성
		
		for (int i = 0; i < ch.length; i++) {
			ch[i] = str.charAt(i); // charAt : ()안에 주어진 값에 해당하는 문자를 리턴함
		}
		
		char[] kor = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 
				'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ',
				'ㅗ','ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };
		
		for (int i = 0; i < ch.length; i++) { // 입력한 값 중 한개씩 비교하기 위한 반복문 i
			for (int j = 97; j < 121; j++) { // 비교할 값(아스키코드) j
				// 아스키코드로 97이 a, ex) 입력값이 b이면 j 반복문이 두번 돌아감.
				// j=98 -> 아스키코드 98이 b랑 같음
				if (ch[i] == ((char) j)) {
					System.out.print(kor[j - 97] + " "); // j=98-97 -> 배열 kor[1] -> ㄴ 문자가 출력됨
				}				
			}			
		}		
	}
}
