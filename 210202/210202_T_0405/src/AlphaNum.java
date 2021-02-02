
public class AlphaNum {
	public AlphaNum(String str) {
		int cnt[] = new int [26];
		
		for (int i = 0; i < str.length(); i++) {
			char ch = str.toUpperCase().charAt(i); // toUpperCase : 대문자 변환
			if (Character.isLetter(ch)) { // isLetter : 명시된 char값이 문자인지 여부를 판단하여 true/false를 리턴함
				cnt[ch - 'A']++;
			}
		}
		for (int i = 0; i < 26; i++) {
			if (cnt[i] != 0) {
				System.out.println((char)(97+i) + " : " + cnt[i] + "글자입니다.");
			}			
		}
	}
}
