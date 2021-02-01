import java.util.Scanner;

public class Alphabet2 {
	public Alphabet2 (String moonja[]) {
		String eng[] = new String[24];
		for (int i = 0; i < 24; i++) {
			eng[i] = Character.toString((char)(97 + i));
		}
		String kor[] = {"ㄱ","ㄴ","ㄷ","ㄹ","ㅁ","ㅂ","ㅅ","ㅇ","ㅈ","ㅊ","ㅋ","ㅌ","ㅍ","ㅎ","ㅏ","ㅑ","ㅓ","ㅕ","ㅗ","ㅛ","ㅜ","ㅠ","ㅡ","ㅣ"};
		for (int i = 0; i < moonja.length; i++) {
			for (int j = 0; j < 24; j++) {
				String a = (eng[j]);
				String b = moonja[i];
				if(a.equals(b)) {
					System.out.printf(kor[j]);
					break;
				}
			}
		}
		int[] chCount = new int[26];
		Scanner s = new Scanner(System.in);
		System.out.println("알파벳을 입력하세요");
		String str = s.next();
		String str1[] = str.split("");
		for (int i = 0; i < str.length(); i++) {
			for (int j = 0; j < eng.length; j++) {
				if(str1[i] == eng[j]) {
					System.out.println(kor[j]);
					chCount[j] += 1;
					break;
				}
			}
		}
		
		for (int i = 0; i < eng.length; i++) {
			if(chCount[i] != 0) {
				System.out.println(eng[i] + ":" + chCount[i]);
			}
		}
		
	}

}
