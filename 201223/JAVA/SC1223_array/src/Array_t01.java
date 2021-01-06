
public class Array_t01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub		
		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
		int hap = 0;
		
		for(int i=0; i<10; i++) {
			hap += arr[i];			
		}
		System.out.println("합 : " + hap);
		
		float ave = 0f;
		for(int i=0; i<10; i++) {
			ave = hap/9;
		}
		System.out.println("평균 : " + ave);
	}

}
