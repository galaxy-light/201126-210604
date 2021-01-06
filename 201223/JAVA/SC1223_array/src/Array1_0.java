import java.util.Scanner;

public class Array1_0 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		// 4개의 비어있는 연속된 공간
		int[] arr = new int[4];
		int hap = 0;
		
		System.out.print("1번째 숫자 입력 : ");
		arr[0] = s.nextInt();
		System.out.print("2번째 숫자 입력 : ");
		arr[1] = s.nextInt();
		System.out.print("3번째 숫자 입력 : ");
		arr[2] = s.nextInt();
		
		hap = arr[0] + arr[1] + arr[2];
		System.out.println("배열의 합 : " + hap);
		
		s.close();
	}

}
