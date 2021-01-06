
public class Array_t04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 5*2 배열
		int arr[][] = {
				{1, 2},
				{2, 4},
				{3, 6},
				{4, 8},
				{5, 10}};
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
	}			
}	



	
