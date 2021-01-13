
public class TestArray {
	private int sum;
	private double avg = 0;
	
	// 메서드
	public int sum(int arr[]) {
		sum = 0;
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		return sum;
	}
	
	// 메서드
	public double avg(int arr[]) {
		avg = (double)sum(arr)/arr.length;
		return avg;
	}
	
	// 생성자
	public TestArray(int arr[]) {		
		super();
		System.out.println("합 : " + sum(arr));
		System.out.println("평균 : " + avg(arr));
	}



		
}