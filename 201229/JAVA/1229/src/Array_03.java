
public class Array_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 이차원 배열을 만들면서 사용자가 값을 바로 넣음
		int arr[][] = {
				{1, 2, 3},
				{4, 5, 6}, 
				{7, 8, 9}, 
				{10, 11, 12}};
		for(int i=0; i<4; i++) {
			for (int j=0; j <3; j++) {
				System.out.print(arr[i][j]+"\t");
			}
			System.out.println();
		}
		
		// 불규칙한 이차원 배열일 때 .length를 사용		 
		int[][] arr2 = {
				{1, 2, 3},
				{4, 5},
				{6, 7, 8},
				{9}};
		for(int i=0; i<arr2.length; i++) { // arr2.length : 행
			for (int j=0; j<arr2[i].length; j++) { // arr2[i].length : 행에 대한 열
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}			
	}
}


