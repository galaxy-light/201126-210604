import java.util.Scanner;

public class AlphaNumMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String str = s.next();		
		new AlphaNum(str);
	}
}
