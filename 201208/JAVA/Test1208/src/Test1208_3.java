import java.util.Scanner;

public class Test1208_3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 국어, 영어, 수학, 과학은 입력값
		Scanner a = new Scanner(System.in);
		// 국어 점수
		System.out.print("국어 점수 입력 : ");
		int b = a.nextInt();
	    // 영어 점수
		System.out.print("영어 점수 입력 : ");
		int c = a.nextInt();
		// 수학 점수
		System.out.print("수학 점수 입력 : ");
		int d = a.nextInt();
		// 과학 점수
		System.out.print("과학 점수 입력 : ");
		int e = a.nextInt();
		
		
		// 총점
		int f = b+c+d+e;
		System.out.println("총점 : " + f + "점");
		// 평균
		float g = (b+c+d+e)/4;
		System.out.println("평균 : " + g + "점");
		
		a.close();

	}

}
