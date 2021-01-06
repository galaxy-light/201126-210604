import java.util.Random;

public class Exam_t01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 10개의 랜덤 숫자를 입력 받아 짝수, 홀수를 구분하는 프로그램
//		두 가지 방법으로 쓸 수 있음
//		int a = 10;
//		int arr[] = new int [a]; 
		
		int arr[] = new int[10]; // 빈 배열 10개 생성
		Random rand = new Random();
		for (int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(100);
			System.out.println(arr[i]);
		}
		evenOdd(arr); // 던지고
	}
	
	public static void evenOdd(int arr[]) { // 받고
		for (int i : arr) {
			if (i%2==0) {
				System.out.println(i+" = 짝수");
			}
			else {
				System.out.println(i+" = 홀수");
			}
		}
	}
}
