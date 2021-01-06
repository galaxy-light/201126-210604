import java.util.Arrays;
import java.util.Scanner;

public class T01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// n개의 정수를 입력받고, 그 중에서 최대값과 최소값을 출력하시오.
		System.out.println("1번 문제");
		Scanner s = new Scanner(System.in);
		System.out.print("n개 숫자 입력 : ");
		int num = s.nextInt();
		System.out.print("숫자 입력 : ");
		int [] numberlist = new int[num]; // 배열의 크기 조정		
		for (int i = 0; i < num; i++) { // 5를 입력했다면 for문을 5번 돔
			numberlist[i] = s.nextInt(); // 만약에 5를 입력했다면 5번 돌면서 숫자를 5번 입력 받아 numberlist 배열에 넣음
		}
		// 최대 최소 비교
		// 첫번째 방법
		int max = numberlist[0]; // 초기값
		int min = numberlist[0]; // 초기값
		
		for (int i = 0; i < numberlist.length; i++) {
			if(numberlist[i]>max)
				max=numberlist[i];
			if(numberlist[i]<min)
				min=numberlist[i];
		}
		System.out.println("최대값 : " + max);
		System.out.println("최소값 : " + min);
		
		System.out.println("-------------------");
		// 두번째 방법
		Arrays.sort(numberlist);
		System.out.println("최대값 : " + numberlist[numberlist.length-1]);		
		System.out.println("최소값 : " + numberlist[0]);
				
		s.close();
	}

}
