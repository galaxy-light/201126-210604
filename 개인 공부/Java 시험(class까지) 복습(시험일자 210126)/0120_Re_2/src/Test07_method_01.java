// https://blog.naver.com/hack4ork/221671486484
import java.util.Scanner;

public class Test07_method_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		int arr[] = new int [3];
		for (int i = 0; i < 3; i++) {
			System.out.print("숫자 입력 : ");
			arr[i] = s.nextInt();
			System.out.println(arr[i]);			
		}
		
		func(arr);
		s.close();
	}
	
	public static void func(int arr[]) {
		for (int i = 2; i >= 0; i--) {
			System.out.print(arr[i]+"-");			
		}
	}
}
