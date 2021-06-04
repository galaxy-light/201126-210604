package test;

import java.util.Scanner;

public class QueOne {

	public static void main(String[] args) {
		//내가 정한 숫자 만큼의 숫자들을 입력받고
		//그 중에서 최솟값과 최댓값을 출력하는 것
		
		//1. 총 몇 개의 숫자를 입력받을지 정함
		System.out.println("숫자를 입력받으세요.");
		int countNum = 0;
		Scanner s = new Scanner(System.in);
		countNum = s.nextInt();
		
		//2. 내가 입력한 숫자 크기의 배열을 선언
		int[] input = new int[countNum];
		
		//3. 그 배열에다가 숫자를 집어넣음
		for (int i = 0; i < input.length; i++) {
			input[i] = s.nextInt();
		}
		
		//최댓값과 최솟값을 저장할 변수를 만듦
		int max = input[0];
		int min = input[0];
		
		//4. 그 배열 안에서 가장 큰 값과 가장 작은 값을 출력
		for (int i = 0; i < input.length; i++) {
			
			
			//if if와 if else는 결과는 같을 지언정
			//세부 동작은 다름
			if(max < input[i])
				max = input[i];
			//input[i] = max;
			if(min > input[i])
				min = input[i];
			
			if(max < input[i])
				max = input[i];
			//input[i] = max;
			else if(min > input[i])
				min = input[i];
			
			
			//max랑 같은 값이 나오면 min값을 input값으로
			//세팅해버림...
			if(max < input[i])
				max = input[i];
			//input[i] = max;
			else
				min = input[i];
		}
		
		System.out.println(max);
		System.out.println(min);

	}

}



