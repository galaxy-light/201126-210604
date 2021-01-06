import java.util.Scanner;

public class Exam4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("------------------------------");
		System.out.println("입력 받는 수의 합을 구하는 프로그램 v1.0");
		System.out.println("------------------------------");
		System.out.print("num1 입력 : ");
		int num1 = s.nextInt();
		System.out.print("num2 입력 : ");
		int num2 = s.nextInt();
		int hap = 0;
		if (num1 <= num2) {
			while (true) {
				for (int i = num1; i <= num2; i++) {
					hap += i; // hap+=i; 는 hap=hap+i 와 동일함
				}
				System.out.printf("%d ~ %d까지의 합 : %d\n", num1, num2, hap);
				break;
			}

		} else if (num1 > num2) {
			while (true) {
				System.out.println("num1이 num2보다 입력값이 큽니다.");
				System.out.print("num2 다시 입력 : ");
				num2 = 0;
				num2 = s.nextInt();
				for (int i = num1; i < num2; i++) {
					hap += i;
				}
				System.out.printf("%d ~ %d까지의 합 : %d\n", num1, num2, hap);
				break;
			}

		}
	}

}

