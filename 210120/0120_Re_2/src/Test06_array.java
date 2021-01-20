// https://blog.naver.com/hack4ork/221671484521
public class Test06_array {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 1번-배열
		int arr[] = {20, 34, 22, 14, 36, 23, 67, 25, 99, 88};
		int sum = 0;
		double avg = 0;
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];			
		}
		System.out.println("배열의 합 : " + sum);
		avg = sum/arr.length;
		System.out.println("배열의 평균 : " + avg);
		

		// 2번-배열
		int arr2[] = new int[101];
		for (int i = 1; i < arr2.length; i++) {
			arr2[i] = i;
//			System.out.println(i);
			if (i%5==0) {
				System.out.println("5의 배수 : " + arr2[i]);
				if (arr2[i]==90) {
					break;
				}
			}
		}
		
		
		// 3번-배열
		int arr3[] = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
		int arr4[] = new int [10];
//		for (int i = 0; i < arr3.length; i++) {
//			System.out.print(arr[i]+" ");
//		}
		for (int j = 0; j < arr4.length; j++) {
			arr4[j] = arr3[9-j];		
			System.out.println(arr4[j]);
		}
	
		
		// 4번-이차원 배열
		int arr5[][] = {
				{1, 2},
				{2, 4, 6},
				{3, 6},
				{4, 8, 10, 12},
				{10}				
		};		
//		System.out.println(arr5.length);
		for (int i = 0; i < arr5.length; i++) {
			for (int j = 0; j < arr5[i].length; j++) {
				System.out.print("arr["+i+"]["+j+"]"+"="+arr5[i][j]+"\t");
			}
			System.out.println();
		}
		
		
		// 5번-이차원 배열
		int arr6[][] = {
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9}
		};
		int arr7[][] = {
				{10, 20, 30},
				{40, 50, 60},
				{70, 80, 90},
		};
		int result[][] = new int[3][3];
		for (int i = 0; i < arr6.length; i++) {
			for (int j = 0; j < arr6[i].length; j++) {
				result[i][j] = arr6[i][j]+arr7[i][j];
				System.out.print(result[i][j]+"\t");
			}
			System.out.println();
		}
		
		
		// 6번-이차원 배열
		int arr8[][] = new int [10][10];
		for (int i = 1; i < arr8.length; i++) {
			for (int j = 2; j < arr8[i].length; j++) {
				arr8[j][i] = i*j;
				System.out.print(j+"X"+i+"="+arr8[j][i]+"\t");
			}
			System.out.println(" ");
		} 
		
	}

}
