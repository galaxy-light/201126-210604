// https://blog.naver.com/hack4ork/221671486484
import java.util.Scanner;

public class Test07_method_10 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int num = s.nextInt();
		
		int result = func(num);
		System.out.println(num + "!=" + result);
		s.close();
	}
	
	public static int func(int num) {
		if (num == 1) {
			return 1;
		}
		else {
			return num * func(num-1);
		}
	}

}
