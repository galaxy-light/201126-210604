import java.util.Scanner;

public class Scanner1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 조건2
		Scanner sc = new Scanner(System.in); // system.in 이 부분의 뜻이 사용자가 입력하는 값
		
		float num1 = sc.nextFloat();
		float num2 = 3.14f;
		
		System.out.println("원의 면적 : " + num1*num1*num2);
		sc.close();	

		
	}

}
