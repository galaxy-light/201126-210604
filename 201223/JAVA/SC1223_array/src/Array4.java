
public class Array4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// []의 위치는 두가지 방법으로 쓸 수 있음
		int[] arr1 = new int[100];
		int arr2[] = new int[100];
		
		System.out.println(arr1.length);
		for(int i=0; i<arr1.length; i++) {
			arr1[i] = i*2;
			System.out.println(arr1[i]);
		}
		
		System.out.println("----------------------------");
		
		System.out.println(arr2.length);
		for(int j=0; j<arr2.length; j++) {
			// arr1 = arr1[i]
			// arr1[99-j] : arr1의 99번째 칸에서 j를 빼줌
			arr2[j] = arr1[99-j];
			System.out.println(arr2[j]);
		}
	}

}
