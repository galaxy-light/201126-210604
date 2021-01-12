
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub	
		TestArray a = new TestArray();
		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
		
		int sum = 0;
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		// System.out.println(sum);
		float avg = 0;
		avg = sum/arr.length;
		// System.out.println(avg);
		
		a.setSum(sum);
		a.setAvg(avg);
		
		a.ShowArrInfo();
	
		
	}


}
