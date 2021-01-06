import java.util.Scanner;

public class Input5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 국어, 영어, 수학, 과학 점수를 입력
		Scanner a = new Scanner(System.in);
		System.out.print("국어 점수 입력 : ");
		int b = a.nextInt();
		System.out.print("영어 점수 입력 : ");
		int c = a.nextInt();
		System.out.print("수학 점수 입력 : ");
		int e = a.nextInt();
		System.out.print("과학 점수 입력 : ");
		int f = a.nextInt();
		
		// 총점, 평균값
		int to = b+c+e+f;
		float av = (b+e+c+f)/4f;
		System.out.println("총점 : " + to);
		System.out.print("평균값 : " + av);
		
		a.close();

	}

}
