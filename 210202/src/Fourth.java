import java.util.Scanner;

public class Fourth {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.nextLine(); 

        char[] test = new char[] 
					{'��', '��', '��','��','��','��','��','��','��','��','��','��','��','��',
					 '��','��','��','��','��','��','��','��','��','��'};
        
        for(int i =0; i<input.length(); i++)
        {
        	//�ٽ�!!!
        	System.out.println(test[input.charAt(i)-(int)'a']);
        }
        System.out.println();
	}

}
