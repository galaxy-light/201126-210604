import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 생성자 내부에 메서드가 아무것도 없을 때 사용
//		StudentScore sc = new StudentScore();
//		sc.makeRandom();
//		sc.getHakjum();
//		sc.showHakjum();
		
		// 생성자 내부에 메서드가 모두 존재할 때 사용(39~43라인)
		for (int i = 0; i < 5; i++) {
			new StudentScore();
		}
		
		// 생성자 내부에 메서드 2개만 존재할 때(makeRandom();, getHankjum();
		StudentScore sc[] = new StudentScore[5]; 
		for (int i = 0; i < sc.length; i++) {
			// 출력 방법은 두 가지로 쓸 수 있음
			sc[i] = new StudentScore();
			sc[i].showHakjum();
		}
	}
}

//하나의 파일 안에 다른 class를 만들 때 public을 붙이면 안됨
class StudentScore{
	private int kor;
	private int eng;
	private int math;
	private int sum;
	private int avg;
	private char hakjum;
	
	// 초기화
	public StudentScore() {
		makeRandom(); // 여기서도 출력 가능
		getHakjum(); // 여기서도 출력 가능
		showHakjum(); // 여기서도 출력 가능
	}
	
	public void makeRandom() {
		Random r = new Random(); // 랜덤 객체 생성
		kor = r.nextInt(101); // 101 : 0 ~ 100까지
		eng = r.nextInt(101); // 101 : 0 ~ 100까지
		math = r.nextInt(101); // 101 : 0 ~ 100까지
		sum = kor + eng + math;
		avg = sum / 3;
	}
	
	public char getHakjum() {
		if (avg <= 100 && avg >= 90) {
			hakjum = 'A';		
		}
		else if (avg <= 89 && avg >= 90) {
			hakjum = 'B';
		}
		else if (avg <= 79 && avg >= 70) {
			hakjum = 'C';
		}
		else if (avg <= 69 && avg >= 60) {
			hakjum = 'D';
		}
		else {
			hakjum = 'F';
		}
		return hakjum;
	}
	
	public void showHakjum() {
		System.out.println("국어 : " + kor);
		System.out.println("영어 : " + eng);
		System.out.println("수학 : " + math);
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + avg);
		System.out.println("학점 : " + hakjum);
		System.out.println("------------------");		
	}
	
}
