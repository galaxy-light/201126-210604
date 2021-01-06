import java.util.Scanner;

public class Array1_for2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		// 4개의 비어있는 연속된 공간
		int[] arr = new int[3];
		int hap = 0;
		
		for(int i=0; i<3; i++) {
			System.out.print((i+1) + "번째 숫자 입력 : ");
			arr[i] = s.nextInt();
		}
		
		for(int i=0; i<3; i++) {
			hap += arr[i]; // hap = hap + arr[i]
		}
		System.out.println("배열의 합 : " + hap);
		s.close();
	}

}
