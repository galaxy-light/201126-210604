
public class Circle {
	// private를 안붙이면 디폴트라는 접근자가 됨
	private double rad = 0;
	private double PI = 3.1415;
	
	public Circle (double r) {
		setRad(r);
	}

	public double getArea () {
		return (rad*rad)*PI;
	}

	public double getRad() {
		return rad;
	}

	public void setRad(double r) {
		if (r < 0) {
			rad = 0;
			return;
		}
		rad = r;
	}	
	
}