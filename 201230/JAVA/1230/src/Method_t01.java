import java.util.Arrays;
import java.util.Scanner;

public class Method_t01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 3개의 숫자를 입력받아 크기가 큰 순서대로 출력하세요.
		Scanner s = new Scanner(System.in);
		int arr[] = new int[3];
		for (int i = 0; i < 3; i++) {
			System.out.print("숫자 입력 : ");
			arr[i] = s.nextInt();
			System.out.println(arr[i]);
		}
		func(arr);
		
	}
	
	public static void func(int arr[]) {
		
		Arrays.sort(arr);
		
		for (int i = 2; i >= 0; i--) {			
			System.out.print(arr[i]);
			
		}
	
	}

}
