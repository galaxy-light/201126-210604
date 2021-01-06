
public class Array_t05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int arr1 [][] = new int [3][3];
		int arr2 [][] = new int [3][3];
		int value = 1; 
		
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1.length; j++) {				
				System.out.print(arr1[i][j]+"\t");
			}
			System.out.println();
		}
		System.out.println("--------------------------");
		value = 1;
		for (int i = 0; i < arr1.length; i++) {
			for (int j = 0; j < arr1.length; j++) {
				arr1[i][j] = value++;
				System.out.print(arr1[i][j]+"\t");
			}
			System.out.println();
		}
		System.out.println("--------------------------");
		value = 1;
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2.length; j++) {
				arr2[i][j] = value++;
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}
		System.out.println("--------------------------");
		value = 1;
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2.length; j++) {
				arr2[i][j] = value++*10;
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}
	}
}
