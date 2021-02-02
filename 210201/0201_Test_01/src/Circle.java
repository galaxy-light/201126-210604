/*
 * 문제 : 오류 사항을 고치고 입력되는 값이 음수일 때 출력되는 문제를 고치시오.
 * 
 * class Circle {
 * 		double rad = 0;
 * 		final double PI = 3.14;
 * 
 * public Circle (double r) {
 * 		setRad(r);
 * 	}
 * 
 * public double getArea () {
 * 		return(rad*rad)*PI;
 * 	}
 * }
 */
public class Circle {
	// private 추가
	private double rad = 0;
	private final double PI = 3.1415;
		
	public Circle(double r) {
		setRad(r);
	}
		
	public double getArea() {
		return (rad*rad)*PI;
	}
	
	// 함수 추가
	public void setRad(double r) {			
		if(r<0) {
			rad = 0;
			return;
		}
		rad = r;			
	}
	
	// 속성 접근
	public double getRad() {
		return rad;		
	}		
}
