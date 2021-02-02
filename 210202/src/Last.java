import java.util.Scanner;

public class Last {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.nextLine();
		int[] alphabet = new int[26];
		for(int i=0;i<input.length();i++)
		{
			int index = input.charAt(i)-(int)'a';
			alphabet[index]++;
		}
		for(int i =0; i<alphabet.length; i++)
		{
			if(alphabet[i]!=0)
			{
				String sentense = 
						"'"+(char)(i+97)+"'는 "+
				alphabet[i]+"글자입니다.";
				System.out.println(sentense);
			}
		}

	}

}
