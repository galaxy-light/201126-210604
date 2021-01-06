import java.util.Scanner;

public class Scanner2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 조건3
		Scanner sc = new Scanner(System.in); // system.in 이 부분의 뜻이 사용자가 입력하는 값
		System.out.println("국어 점수를 입력하세요.");		
		int kor = sc.nextInt();
		System.out.println("영어 점수를 입력하세요.");
		int eng = sc.nextInt();
		System.out.println("수학 점수를 입력하세요.");
		int mat = sc.nextInt();
		System.out.println("과학 점수를 입력하세요.");
		int sci = sc.nextInt();		
		
		System.out.println("국어 점수 : " + kor);
		System.out.println("영어 점수 : " + eng);
		System.out.println("수학 점수 : " + mat);
		System.out.println("과학 점수 : " + sci);
		
		System.out.println("총점 : " + (kor+eng+mat+sci));
		System.out.println("평균 : " +((kor+eng+mat+sci)/4));
		
		sc.close();		
	}

}
