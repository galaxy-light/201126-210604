package algorithm20201228;

import java.util.Scanner;

public class Three {

	public static void main(String[] args) {
		System.out.println("3�� ����");
		Scanner s = new Scanner(System.in);
		System.out.println("A �� �Է�");
        int A = s.nextInt();
        System.out.println("B �� �Է�");
        int B = s.nextInt();
        System.out.println("C �� �Է�");
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
            	System.out.println(i+"�� " + numCount[i] + "�� ����");
        }

	}

}
