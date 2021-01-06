package switch1215;

import java.util.Scanner;

public class Switch_T02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("----------------------");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("----------------------");
		
		System.out.print("num1 입력 => ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 => ");
		int num2 = s.nextInt();
		System.out.print("연산자 입력 => ");
		String str = s.next();	
				
		switch (str){
		case "+" :
			int result1 = num1 + num2;
			System.out.println(num1 + str + num2 + "=" + result1);
		break;
		case "-" :
			int result2 = num1 - num2;
			System.out.println(num1 + str + num2 + "=" + result2);
		break;
		case "*" :
			int result3 = num1 * num2;
			System.out.println(num1 + str + num2 + "=" + result3);
		break;
		case "/" :
			float result4 = num1 / num2;
			System.out.println(num1 + str + num2 + "=" + result4);
		break;
			
		}		
		s.close();
		 
	}

}
