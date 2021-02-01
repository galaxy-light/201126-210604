import java.util.Scanner;

public class Number {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		String input = s.nextLine();
		int [] alpha = new int[26];
		
		for (int i = 0; i < input.length(); i++) {
			int index = input.charAt(i) + (int)'a';
			alpha[index]++;
		}
		for (int i = 0; i < 26; i++) {
			if (alpha[i]!=0) {
				String sentense = "" + (char)(i+97)+"'"+"는 "+alpha[i]+"글자입니다.";
			}
		}
	}

}
