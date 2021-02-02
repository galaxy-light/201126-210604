
public class Circle {
//	double rad = 0;
	private double rad = 0;
	final double PI = 3.1415;
	
	public Circle(double r)
	{
		setRad(r);
	}
	
	public void setRad(double r) {
		if(r<0)
			rad = 0;
		else
			rad = r;
	}
	public double getRad()
	{
		return rad;
	}

	public double getArea()
	{
		return (rad*rad)*PI;
	}

}
