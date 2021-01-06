import java.util.Random;

public class Exam_t03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 5명의 국어, 영어, 수학 점수를 입력받아 학점을 출력하는 프로그램
		int hap = 0;
		int avg = 0;
		int arr[][] = getScore();		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + " ");
				hap += arr[i][j];
			}
			System.out.println();
			System.out.println("총점 : " + hap);
			avg = hap / 3;
			System.out.println("평균 : " + avg);
			if (avg <= 100 && avg >= 90) {
				System.out.println("A학점");
			}
			else if (avg <= 89 && avg >= 80) {
				System.out.println("B학점");
			}
			else if (avg <= 79 && avg >= 70) {
				System.out.println("C학점");
			}
			else if (avg <= 69 && avg >= 60) {
				System.out.println("D학점");
			}
			else {
				System.out.println("F학점");
			}			
			hap = avg = 0; // 총점, 평균 초기화
			System.out.println();
		}
	}
	
	public static int[][] getScore(){
		Random r = new Random();
		int arr[][] = new int[5][3]; // 5행 3열
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = r.nextInt(101); // 0에서 100까지
				// System.out.print(arr[i][j] + " ");
			}
			// System.out.println();
		}
		return arr; // 아무것도 리턴하지 않을 때는 return null;을 쓰면 됨
	}
}
