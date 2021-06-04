package answer20201228;

import java.util.Arrays;
import java.util.Iterator;
import java.util.Scanner;

public class One {

	public static void main(String[] args) {
		//숫자 N개를 입력받아서
		//그 중에서 가장 큰 수랑 작은 수 출력
		System.out.println("1번 문제");
		Scanner s = new Scanner(System.in);
		System.out.println("총 몇 개의 숫자 받을래?");
		int countNum = s.nextInt();
		System.out.println("이제 숫자들을 입력받자");
		int[] numberList = new int[countNum];

		//int max = numberList[0];
		//int min = numberList[0];
		
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//최대 최소를 비교해야겠죠?
		//첫번째 방법
		int max = numberList[0];
		int min = numberList[0];
		
		for (int i = 0; i < numberList.length; i++) {
			if(numberList[i] > max)
				max = numberList[i];
			if(numberList[i] < min)
				min = numberList[i];
		}
		System.out.println("최솟값 : " + min);
		System.out.println("최댓값 : " + max);
		//두번째 방법
		Arrays.sort(numberList);
		System.out.println("최솟값 : " + numberList[0]);
		System.out.println("최댓값 : " 
		+ numberList[numberList.length-1]);
		
		
	}

}
