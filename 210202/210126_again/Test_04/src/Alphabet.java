
public class Alphabet {
	public Alphabet (String text[]) {
		String eng [] = new String[24];
		for (int i = 0; i < 24; i++) {
			eng[i] = Character.toString((char)(97+i)); // 형 변환 -> 알파벳이 저장된 배열 생성
		}
	
		String kor [] = {"ㄱ", "ㄴ", "ㄷ", "ㄹ", "ㅁ", "ㅂ", "ㅅ", "ㅇ", "ㅈ"," ㅊ", "ㅋ", "ㅌ", "ㅍ", "ㅎ",
			"ㅏ", "ㅑ", "ㅓ", "ㅕ","ㅗ", "ㅛ", "ㅜ", "ㅠ", "ㅡ", "ㅣ"};
	
		for (int i = 0; i < text.length; i++) { // 입력한 문자 길이만큼
			for (int j = 0; j < 24; j++) { // ㄱ ~ ㅣ까지, 24개만큼
				if (eng[j].equals(text[i])) {
					System.out.print(kor[j]);
					break;
				}
			}
		}
	}
}
