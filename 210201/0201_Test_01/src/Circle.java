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
		private double rad = 0;
		private final double PI = 3.14;
		
		public Circle(double r) {
			setRad(r);
		}
		
		public double getArea() {
			return (rad*rad)*PI;
		}
		
		public void setRad(double r) {			
			if(r<0) {
				rad = 0;
				return;
			}
			rad = r;			
		}
		
		public double getRad() {
			return rad;		
		}		
}
