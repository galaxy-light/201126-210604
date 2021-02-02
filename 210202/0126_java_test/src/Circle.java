
public class Circle {
		double rad = 0;
		final double PI = 3.14;
		
		public Circle(double r) { setRad(r); }
		public double getArea() { return (rad*rad) * PI; }
		public double getRad() {
			return rad;
		}
		public void setRad(double rad) {
			if(rad < 0) {
				this.rad = rad*-1;
			}else {
				this.rad = rad;
			}
		}
}
