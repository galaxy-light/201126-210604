package algorithm20201228;

import java.util.Scanner;

public class Three {

	public static void main(String[] args) {
		System.out.println("3번 문제");
		Scanner s = new Scanner(System.in);
		System.out.println("A 값 입력");
        int A = s.nextInt();
        System.out.println("B 값 입력");
        int B = s.nextInt();
        System.out.println("C 값 입력");
        int C = s.nextInt();

        int result = A * B * C;
        String sResult = Integer.toString(result);
        int[] numCount = new int[10];
        int a=Integer.parseInt(String.valueOf('1'));
        for (int i = 0; i < sResult.length(); i++)
        {
            //numCount[int.Parse(sResult[i].ToString())]++;
        	int index = Character.getNumericValue(sResult.charAt(i));
            numCount[index]++;
        }
        System.out.println("AxBxC = "+ result);
        for (int i = 0; i < numCount.length; i++)
        {
            if (numCount[i] > 0)
            	System.out.println(i+"은 " + numCount[i] + "번 나옴");
        }

	}

}
