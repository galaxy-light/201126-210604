import java.util.Scanner;

public class AlphabetMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("알파벳 입력 : ");
		String a = s.next();
		String moonja[] = a.split("");
		new Alphabet(moonja);		
	}
}
