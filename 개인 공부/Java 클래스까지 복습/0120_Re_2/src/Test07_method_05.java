import java.util.Scanner;

// https://blog.naver.com/hack4ork/221671486484
public class Test07_method_05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int num = s.nextInt();
		
		func(num);
		s.close();
	}
	
	public static void func(int num) {
		int i = 0;
		for (i = 1; i <= 9; i++) {
			System.out.println(num+"*"+i+"="+num*i);
		}
	}
}
