import java.util.Scanner;

public class Number {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String input = s.nextLine();
		int [] alpha = new int[26];
		
		for (int i = 0; i < input.length(); i++) {
			int index = input.charAt(i) - (int)'a';
			System.out.print(input.charAt(i));
			// System.out.println((int)'a' - 97);
			// System.out.println((int)'a'); // (int)'a' : 97
			alpha[index]++;			
			// System.out.println(index); // index : 해당 문자의 위치
		}
		System.out.println();
		for (int i = 0; i < 26; i++) {
			if (alpha[i]!=0) {
				String sentense = "'" + (char)(i+97)+"'"+"는 "+alpha[i]+"글자입니다.";
				// System.out.println(((char)(i+97))); // (char)(i+97) : 입력한 문자 출력
				System.out.println(sentense);
			}
		}
	}
}
