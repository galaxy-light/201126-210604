package algorithm20201228;

import java.util.Arrays;
import java.util.Iterator;
import java.util.Scanner;

public class One {

	public static void main(String[] args) {
		System.out.println("1�� ����");
		Scanner s = new Scanner(System.in);
		System.out.println("�� ��� ���ڸ� �Է¹����ǰ���?");
		int countNum = s.nextInt();
		System.out.println("���� ���ڵ��� �Է¹޾� ����.");
		int[] numberList = new int[countNum];
		for (int i = 0; i < countNum; i++) {
			numberList[i] = s.nextInt();
		}
		
		//Sol1.
		int max = numberList[0];
		int min = numberList[0];

        for (int i = 0; i < countNum; i++)
        {
            if (numberList[i] > max)
            {
                max = numberList[i];
            }

            if (numberList[i] < min)
            {
                min = numberList[i];
            }
        }
        System.out.println("�ּڰ��� " + min + "�̰�, ");
		System.out.println("�ִ��� " + max + "�̴�. ");
		
		//Sol2.
		Arrays.sort(numberList);
		System.out.println("�ּڰ��� " + numberList[0] + "�̰�, ");
		System.out.println("�ִ��� " + numberList[numberList.length-1] + "�̴�. ");
		
	}

}
