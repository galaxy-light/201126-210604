// https://blog.naver.com/hack4ork/221695997117
import java.util.Random;
import java.util.Scanner;

public class Test05_loop {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 1번-for
		/* for(초기값;조건;증가감소){
				실행문;
			} 
		*/
		System.out.println("1번 문제");
		Scanner s = new Scanner(System.in);
		for (int i = 1; i <= 5; i++) {
			int num = s.nextInt();
			System.out.println(i+". Num"+i+"=>"+num);
			if (num%2==0) {
				System.out.println("짝수");
			}
			else {
				System.out.println("홀수");
			}
			
		}
		
		
		// 2번-while
		/* 초기값 
		   while(조건){
				실행문;
				초기값++--;
			} 
		 */
		System.out.println("2번 문제");
		int a = 0;
		while (a<100) {
			if (a%5==0) {
				System.out.println("5의 배수 : " + a);
			}			
			a++;
		}
		
		
		// 3번-do while
		/* do{
		  		실행문;
		  		초기값증가감소;
		  	}while(조건);	  
		*/	
		System.out.println("3번 문제");
		int i = 0;
		do {
			Random r = new Random();
			int num3 = r.nextInt(45)+1;
			System.out.println(num3);
			i++;
		} while (i<6);
	
		
		// 4번-for	
		System.out.println("4번 문제");
		System.out.print("num1 입력 : ");
		int num4 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num5 = s.nextInt();
		int sum = 0;
		if (num4<=num5) {
			for (int j = num4; j <= num5; j++) {
				sum += j;				
			}
			System.out.printf("%d ~ %d까지의 합 : %d\n", num4, num5, sum);
		}
		
		
		// 5번-while
		System.out.println("5번 문제");
		System.out.print("구구단 입력 : ");
		int num6 = 0;
		int num7 = 1;
		num6 = s.nextInt();	
		while (num7<=9) {
			int mul = num6*num7;
			System.out.println(num6+"*"+num7+"="+mul);
			num7++;
		}
		
		
		// 6번-do while
		System.out.println("6번 문제");
		int num8 = 1;	
		do {			
			int num9 = 2;
			do {				
				System.out.print(num9+"*"+num8+"="+num8*num9+"\t");	
				num9++;
			} while (num9<=9);
			System.out.println(" ");
			num8++;
		} while (num8<=9);
		
		
		s.close();
	}
	

}
