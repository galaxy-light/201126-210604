import java.util.Scanner;

public class AlphabetCheckMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String str = s.next();	
		
		int arr [] = new int [26];
		for (int i = 0; i < str.length(); i++) { // 입력한 문자의 길이만큼
			int index = str.charAt(i) - (int)'a';
//			System.out.println((int)'a' - 97);
//			System.out.println((int)'a'); // (int)'a' : 97
			arr[index]++;
//			System.out.println(index);
		}		
		for (int i = 0; i < 26; i++) {
			if (arr[i]!=0) {
				String result = "'" + (char)(i+97) + "'" + "는 " + arr[i] + "글자입니다.";
				System.out.println(result);
			}
		}
	}
}
