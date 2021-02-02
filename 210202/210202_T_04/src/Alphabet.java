import java.util.Scanner;

public class Alphabet {
	public Alphabet (String moonja[]) {
		String eng[] = new String[24];
		for (int i = 0; i < 24; i++) {
			eng[i] = Character.toString((char)(97+i));
		}
		
		String kor [] = {"ㄱ","ㄴ","ㄷ","ㄹ","ㅁ","ㅂ","ㅅ",
				"ㅇ","ㅈ","ㅊ","ㅋ","ㅌ","ㅍ","ㅎ",
				"ㅏ","ㅑ","ㅓ","ㅕ","ㅗ","ㅛ",
				"ㅜ","ㅠ","ㅡ","ㅣ"};
		
		for (int i = 0; i < moonja.length; i++) {
			for (int j = 0; j < 24; j++) {
				String a = (eng[j]);
				String b = moonja[i];
				if (a.equals(b)) {
					System.out.print(kor[j]);
					break;
				}
			}
		}
	}
}
