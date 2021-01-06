
public class Method_06 {
	public static void func(int arr[]) { // 비어있는 배열
		for (int i = 0; i < arr.length; i++) {
			System.out.print(arr[i] + " ");
		}
	}
	
	public static void func2(int arr[][]) { // 비어있는 배열
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j]+" ");
			}
			System.out.println();
		}
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("1차원 배열");
		int arr[] = {1, 2, 3, 4, 5}; // arr : 배열의 주소값
		func(arr);
		
		System.out.println("\n2차원 배열"); // \n : 줄 띄움
		int arr2[][] = {
				{1, 2, 3},
				{4, 5, 6}};
		func2(arr2);
		
	}

}
