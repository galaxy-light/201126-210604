import java.util.Scanner;

public class Text {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		String input = s.nextLine();
		char [] test = new char[] {
				'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ',
				'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ', 'ㅛ',
				'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ'
				};
		
		for (int i = 0; i < input.length(); i++) {
			System.out.println(test[input.charAt(i)-(int)'a']);
		}
		System.out.println();		
	}

}
