package algorithm20201228;

import java.util.Scanner;

public class Four {

	public static void main(String[] args) {

        int[] answer = new int[] { 5, 4, 1, 2, 3 };
        String[] que = new String[] { "���� �� ����� ����?", "1+1��?", "2+2��?", "3+3��?", "4+4��?" };
        
        String[] bogi = new String[] { "1. ������ 2.������ 3. ����� 4. �ܽ��� 5. �̵���",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]",
                                        "1. [4] 2. [6] 3.[8] 4. [2] 5. [100]"};
        String queResult = "";
        int totalPoint = 0;
        Scanner s = new Scanner(System.in);
        for (int i = 0; i < 5; i++)
        {
            System.out.println(que[i]);
            System.out.println(bogi[i]);
            System.out.println("������?");
            int ans = s.nextInt();

            if (answer[i] == ans)
            {
                queResult += "O";
                if (i == 0 || i == 4)
                    totalPoint += 10;
                else if (i == 1)
                    totalPoint += 20;
                else
                    totalPoint += 30;
            }
            else
            {
                queResult += "X";
            }
        }

        System.out.println("����� " + queResult + "�̰�, " + "�� ���� " + totalPoint + "�Դϴ�.");
	}

}
