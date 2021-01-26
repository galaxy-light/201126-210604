// https://blog.naver.com/hack4ork/221671058863 - 4번
package student;

import java.util.Random;

public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		for (int i = 0; i < 5; i++) {
			new Student();
		}
	}

}


class Student{
	private int ko;
	private int en;
	private int ma;
	private int sum;
	private int avg;
	private char result;
	
	// 초기화
	public Student() {
		makeScore();
		getScore();
		showScoreInFo();
	}
	
	public void makeScore() {
		Random rand = new Random();
		ko = rand.nextInt(101); // 101 : 0 ~ 100
		en = rand.nextInt(101);
		ma = rand.nextInt(101);
		sum = ko+en+ma;
		avg = sum / 3;
	}
	
	public char getScore() {
		if (avg<=100&&avg>=90) {
			result = 'A';
		}
		else if (avg<=89&&avg>=80) {
			result = 'B';
		}
		else if (avg<=79&&avg>=70) {
			result = 'C';
		}
		else if (avg<=69&&avg>=60) {
			result = 'D';
		}
		else if (avg<=59&&avg>=50) {
			result = 'E';
		}
		else {
			result = 'F';
		}
		return result;
	}
	
	public void showScoreInFo() {
		System.out.println("국어 : " + ko);
		System.out.println("영어 : " + en);
		System.out.println("수학 : " + ma);
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + avg);
		System.out.println("등급 : " + result);
		System.out.println("-------------");
		
	}
}