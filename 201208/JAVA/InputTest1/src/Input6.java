import java.util.Scanner;

public class Input6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner a = new Scanner(System.in);	
		
		// 알파벳 자음 : 21개, 알파벳 모음 : 5개
		System.out.print("알파벳 자음 개수 입력: ");
		int b = a.nextInt();
		System.out.print("알파벳 모음 개수 입력 : ");
		int c = a.nextInt();
		// 한글 자음 : 19개, 한글 모음 : 21개
		System.out.print("한글 자음 개수 입력 : ");
		int d = a.nextInt();
		System.out.print("한글 모음 개수 입력 : ");	
		int e = a.nextInt();
		
		a.close();	
		
	}

}
