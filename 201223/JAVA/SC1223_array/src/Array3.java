
public class Array3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// int형으로 비어있는 10개의 빈칸
		int arr[] = new int[10];
		
		// ()안의 변수는 {}밖의 변수에 영향을 주지 않음
		for(int i=0; i<arr.length; i++) {
			arr[i] = i;
		}
		
		// 위의 i에 영향을 받지 않음
		for(int i=0; i<arr.length; i++) {
			System.out.println(arr[i]);
		}
	}

}
