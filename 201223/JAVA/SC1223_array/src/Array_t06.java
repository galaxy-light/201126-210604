
public class Array_t06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int arr[][] = new int [10][10];
		
		for (int i = 1; i <= 9; i++) {
			for (int j = 2; j < 10; j++) {
				int num = i*j;
				System.out.print(j + "*" + i + "=" + num + "\t");
			}
			System.out.println();
		}
		
		System.out.println("--------------------------------------------------------------");
		// 이차원 배열
		int i = 0;
		for (i = 1; i < arr.length; i++) {
			for (int j = 2; j < arr.length; j++) {
				arr[j][i] = i*j;
				System.out.print(j+ "*" + i + "=" + arr[j][i] + "\t");
			}
			System.out.println();
		}
	}

}
