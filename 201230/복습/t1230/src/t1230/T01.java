package t1230;

import java.util.Scanner;

public class T01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("n개 입력 : ");
		int num = s.nextInt();
		System.out.println("숫자 입력 : ");
		
		int [] numberlist = new int[num]; 
		for (int i = 0; i < num; i++) {
			numberlist[i] = s.nextInt();
		}
		int max = numberlist[0];
		int min = numberlist[0];
		
		for (int i = 0; i < numberlist.length; i++) {
			if (numberlist[i]>max) {
				max=numberlist[i];
			}
			else if (numberlist[i]<min) {
				min=numberlist[i];
			}
		}
		System.out.println("최대값 : " + max);
		System.out.println("최소값 : " + min);
	}

}
