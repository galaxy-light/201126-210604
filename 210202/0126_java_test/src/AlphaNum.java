
public class AlphaNum {
	public AlphaNum(String str) {
		int cnt[] = new int[26];
		
		for (int i = 0; i < str.length(); i++) {
            char ch = str.toUpperCase().charAt(i);
            if(Character.isLetter(ch))
                cnt[ch - 'A']++;
        }
        for (int i = 0; i < 26; i++) {
        	if(cnt[i] != 0) {
        		System.out.println((char) (97 + i) + " : " + cnt[i] + "글자 입니다.");
        	}
        }
	}
}
