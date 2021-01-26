import java.util.Scanner;

public class Textarr {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("a ~ x까지 소문자 입력 : ");
		String text = s.next();
		
		char text1[] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
				'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
				'u', 'v', 'w', 'x'};
		
		char text2[] = {'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ',
				'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ',
				'ㅗ', 'ㅛ','ㅜ', 'ㅠ', 'ㅡ', 'ㅣ'};
		
		int chCount[] = new int[24];
		
		for (int i = 0; i < text.length(); i++) { // 사용자가 입력한 만큼만 반복
			for (int j = 0; j < text2.length; j++) {
				if (text.charAt(i)==text1[j]) {
					System.out.print(text2[j]);
					chCount[j]++; // chCount[j] += 1; 문법과 동일
					break;
				}
			}
		}
		s.close();
		System.out.println();
		for (int i = 0; i < text1.length; i++) {
			if (chCount[i]!=0) {
//				System.out.println(text1[i]+":"+chCount[i]);
				System.out.printf("%c는 %d글자입니다.", text1[i], chCount[i]);
				System.out.println();
			}
		}
	}
}
