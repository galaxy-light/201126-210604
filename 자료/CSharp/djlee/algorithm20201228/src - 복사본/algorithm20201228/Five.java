package algorithm20201228;

import java.util.Scanner;

public class Five {

	public static void main(String[] args) {

        System.out.println("5�� ����");
        String queResult = "";
        System.out.println("���� ������?");
        Scanner s = new Scanner(System.in);
        int countQue = s.nextInt();
        String[] queList = new String[countQue];
        String[] answerList = new String[countQue];
        
        s.nextLine(); //���� û��

        for (int i = 0; i < countQue; i++)
        {
            System.out.printf("%d��° ������ �����ּ���.\n", i+1);
            queList[i] = s.nextLine();
            System.out.println("������ �����Դϱ�?(Y Ȥ�� Yes�� �Է½ÿ��� ������)");
            String yesOrNo = s.nextLine();
            if(yesOrNo.toUpperCase().contains("Y"))
            {
            	System.out.println("���⵵ ���� �����ּ���. ����� 3���Դϴ�.");
                for (int j = 0; j < 3; j++)
                {
                	System.out.printf("%d��\n", j+1);
                    String selector = s.nextLine();
                    queList[i] += "\n" + (j+1) + "�� " + selector;
                }
                System.out.printf("%d��° ������ ������ �����ּ���.\n",i + 1);
                answerList[i] = s.nextLine();
                while (Integer.parseInt(answerList[i]) < 1 || Integer.parseInt(answerList[i]) > 3)
                {
                    System.out.println("����� 1������ 3�������Դϴ�. �ٽ� �����ּ���.");
                    answerList[i] = s.nextLine();
                }
            }
            else
            {
                System.out.printf("%d��° ������ ������ �����ּ���.\n",i + 1);
                answerList[i] = s.nextLine();
            }
        }

        for (int i = 0; i < 100; i++)
        {
            System.out.println();
        }

        do
        {
        	System.out.println("�������� ���� Ǯ�̴ϴ�.");
            for (int i = 0; i < countQue; i++)
            {
            	System.out.println(queList[i]);
            	System.out.println("������?");
                String ans = s.nextLine();

                if (answerList[i].equals(ans)) //java�� String �񱳽� equals�� ����
                {
                    queResult += "O";
                }
                else
                {
                    queResult += "X";
                }
            }
            System.out.println(queResult);

            String resultO = "���� ������\n";
            String resultX = "Ʋ�� ������\n";
            int correctCount = 0;
            for (int i = 0; i < queResult.length(); i++)
            {
                if(queResult.charAt(i) == 'O')
                {
                    resultO += String.format("%d�� ����\n", i+1);
                    correctCount++;
                }
                else
                {
                    resultX += String.format("%d�� ����\n", i+1);
                }

            }
            if (correctCount == 0)
                resultO = "���� ������ �����ϴ�.";
            else if(correctCount == countQue)
                resultX = "Ʋ�� ������ �����ϴ�.";

            System.out.println("�� " + correctCount + "�� �­����ϴ�.");
            System.out.println(resultO);
            System.out.println(resultX);
            queResult = "";
        } while (true);

	}

}
