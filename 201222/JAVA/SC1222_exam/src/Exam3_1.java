import java.util.Random;

public class Exam3_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// for
		System.out.println("---------------");
		System.out.println("간단한 로또 프로그램");
		System.out.println("---------------");
		for (int i = 0; i < 6; i++) {
			Random rand = new Random();
			// int num = rand.nextInt(5)+1; -> 1~5까지 랜덤 숫자 생성
			// int num = rand.nextInt(10)+1; -> 1~10까지 랜덤 숫자 생성
			int num = rand.nextInt(45) + 1; // 1~45까지 랜덤 숫자 생성
			System.out.print(num + " ");
		}
	}
}
