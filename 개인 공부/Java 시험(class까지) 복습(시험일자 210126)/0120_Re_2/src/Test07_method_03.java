// https://blog.naver.com/hack4ork/221671486484
import java.util.Random;

public class Test07_method_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub		
		Random rand = new Random();
		int arr[] = new int [10];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(10)+1;
//			System.out.println(arr[i]);
		}				
		func(arr);		
	}
	
	public static void func(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			if (arr[i]%2==0) {
				System.out.println(arr[i]+" : 짝수");
			}
			else {
				System.out.println(arr[i]+" : 홀수");
			}
		}
		
	}
}
