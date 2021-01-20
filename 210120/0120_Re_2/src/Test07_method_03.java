import java.util.Random;
import java.util.Scanner;

public class Test07_method_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		Random rand = new Random();
		int arr[] = new int [10];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(10)+1;
//			System.out.println(arr[i]);
		}				
		func(arr);
		s.close();
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
