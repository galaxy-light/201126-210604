import java.util.Scanner;

public class Method_t10 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 입력받은 수의 팩토리얼을 구하는 프로그램
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 입력 : ");
		int num = s.nextInt();
		
		func(num);
	}
	
	public static void func (int num) {
		int vorxh = 1;
		for (int i = 1; i <= num; i++) {
			vorxh *= i;
			System.out.println(vorxh);
		}
	}

}
