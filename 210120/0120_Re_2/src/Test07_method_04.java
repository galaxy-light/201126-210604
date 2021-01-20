import java.util.Scanner;

public class Test07_method_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		int score [] = new int [3];
		int sum = 0;
//		System.out.println(score.length);
		for (int i = 0; i < score.length; i++) {
			System.out.print("점수 입력 : ");
			int num = s.nextInt();
			if ((0<=num)&&(num<=100)) {
//				System.out.println(num);
				score[i] += num;
				sum += num;
//				System.out.println(sum);
			}					
			else {
				System.out.println("잘못된 입력값!");
				break;
			}
			
		}		
		
//		func(arr);
		s.close();
//	}	
		
//	public static void func(int arr[]) {
//		System.out.println(sum);
//		System.out.println();
	
		


	}	
		
	

}
