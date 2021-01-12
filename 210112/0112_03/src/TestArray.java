
public class TestArray {
	private int sum;
	private float avg;
	
	public TestArray() {
		sum = 0;
		avg = 0;
	}
	
	public TestArray(int sum, float avg) {
		super();
		this.sum = sum;
		this.avg = avg;
	}

	public int getSum() {
		return sum;
	}

	public void setSum(int sum) {
		this.sum = sum;
	}

	public float getAvg() {
		return avg;
	}

	public void setAvg(float avg) {
		this.avg = avg;
	}

	public void ShowArrInfo() {
	System.out.println("합 : " + sum);
	avg = sum/10;
	System.out.println("평균 : " + avg);
	}

}
