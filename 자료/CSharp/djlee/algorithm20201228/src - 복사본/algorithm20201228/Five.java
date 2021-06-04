package algorithm20201228;

import java.util.Scanner;

public class Five {

	public static void main(String[] args) {

        System.out.println("5¹ø ¹®Á¦");
        String queResult = "";
        System.out.println("¹®Á¦ °³¼ö´Â?");
        Scanner s = new Scanner(System.in);
        int countQue = s.nextInt();
        String[] queList = new String[countQue];
        String[] answerList = new String[countQue];
        
        s.nextLine(); //¹öÆÛ Ã»¼Ò

        for (int i = 0; i < countQue; i++)
        {
            System.out.printf("%d¹øÂ° ¹®Á¦¸¦ Àû¾îÁÖ¼¼¿ä.\n", i+1);
            queList[i] = s.nextLine();
            System.out.println("°´°ü½Ä ¹®Á¦ÀÔ´Ï±î?(Y È¤Àº Yes·Î ÀÔ·Â½Ã¿¡¸¸ °´°ü½Ä)");
            String yesOrNo = s.nextLine();
            if(yesOrNo.toUpperCase().contains("Y"))
            {
            	System.out.println("º¸±âµµ °°ÀÌ Àû¾îÁÖ¼¼¿ä. º¸±â´Â 3°³ÀÔ´Ï´Ù.");
                for (int j = 0; j < 3; j++)
                {
                	System.out.printf("%d¹ø\n", j+1);
                    String selector = s.nextLine();
                    queList[i] += "\n" + (j+1) + "¹ø " + selector;
                }
                System.out.printf("%d¹øÂ° ¹®Á¦ÀÇ Á¤´äÀ» Àû¾îÁÖ¼¼¿ä.\n",i + 1);
                answerList[i] = s.nextLine();
                while (Integer.parseInt(answerList[i]) < 1 || Integer.parseInt(answerList[i]) > 3)
                {
                    System.out.println("º¸±â´Â 1¹øºÎÅÍ 3¹ø±îÁöÀÔ´Ï´Ù. ´Ù½Ã Àû¾îÁÖ¼¼¿ä.");
                    answerList[i] = s.nextLine();
                }
            }
            else
            {
                System.out.printf("%d¹øÂ° ¹®Á¦ÀÇ Á¤´äÀ» Àû¾îÁÖ¼¼¿ä.\n",i + 1);
                answerList[i] = s.nextLine();
            }
        }

        for (int i = 0; i < 100; i++)
        {
            System.out.println();
        }

        do
        {
        	System.out.println("ÀÌÁ¦ºÎÅÍ ¹®Á¦ Ç®°Ì´Ï´Ù.");
            for (int i = 0; i < countQue; i++)
            {
            	System.out.println(queList[i]);
            	System.out.println("Á¤´äÀº?");
                String ans = s.nextLine();

                if (answerList[i].equals(ans)) //java´Â String ºñ±³½Ã equals¸¸ ¾²±â
                {
                    queResult += "O";
                }
                else
                {
                    queResult += "X";
                }
            }
            System.out.println(queResult);

            String resultO = "¸ÂÀº ¹®Á¦´Â\n";
            String resultX = "Æ²¸° ¹®Á¦´Â\n";
            int correctCount = 0;
            for (int i = 0; i < queResult.length(); i++)
            {
                if(queResult.charAt(i) == 'O')
                {
                    resultO += String.format("%d¹ø ¹®Á¦\n", i+1);
                    correctCount++;
                }
                else
                {
                    resultX += String.format("%d¹ø ¹®Á¦\n", i+1);
                }

            }
            if (correctCount == 0)
                resultO = "¸ÂÀº ¹®Á¦´Â ¾ø½À´Ï´Ù.";
            else if(correctCount == countQue)
                resultX = "Æ²¸° ¹®Á¦´Â ¾ø½À´Ï´Ù.";

            System.out.println("ÃÑ " + correctCount + "°³ ¸Â­Ÿ½À´Ï´Ù.");
            System.out.println(resultO);
            System.out.println(resultX);
            queResult = "";
        } while (true);

	}

}
