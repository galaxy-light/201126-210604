import java.util.Scanner;

public class Text {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("a ~ x까지 입력 : ");
		String input = s.nextLine();
		char [] test = new char[] {
				'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ',
				'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ', 'ㅛ',
				'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ'
				};
		
		for (int i = 0; i < input.length(); i++) {
			// System.out.println(i); // i : 입력된 문자의 자리 위치
			System.out.println(test[input.charAt(i)-(int)'a']); // ex) 입력값 : a일 때 -> a-97 -> 97-97 -> 0 > ㄱ
			// System.out.println(input.charAt(i));
			// System.out.println((int)'a'); // (int)'a' : 97
		}
		System.out.println();		
	}

}
