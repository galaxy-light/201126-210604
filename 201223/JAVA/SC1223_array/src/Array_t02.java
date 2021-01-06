
public class Array_t02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 비어있는 100개의 연속된 공간
		int arr[] = new int[100];
		System.out.println(arr.length);		
			
		for(int i=1; i<arr.length; i++) {
			arr[i] = i+1;
			System.out.println(arr[i]);	
			
		}
		
		System.out.println("------------------------");
		
		for(int i=1; i<arr.length; i++) {
			arr[i] = i;
			if((i)%5 == 0) {
				System.out.println(arr[i]);
			}
						
		}
		
		System.out.println("-------------------------");
		
		for(int i=1; i<arr.length; i++) {
			arr[i] = i;
			if(i==90) {				
				System.out.println(arr[i]);
				System.exit(0);
			}
			
		}		
		
	}

}
