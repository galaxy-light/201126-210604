
public class Method_03 {
	public static int[] makeArray() {
		int arr[] = new int[3]; // 비어있는 3개의 배열
		for (int i = 0; i < arr.length; i++) {
			arr[i] = 100+i;
		}
		return arr; // 타입 무조건 맞춰줘야 함
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int arr[] = makeArray(); // 이때 arr은 위의 int arr[] = new int[3];와 다름
		
		for (int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}
	}
}
