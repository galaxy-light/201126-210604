
public class Array_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int arr[][] = new int[4][3];
		int value = 1;
		
		for(int i=0; i<4; i++) {
			for (int j=0; j<3; j++) {
				arr[i][j] = value++;  // value++ = value+1
				System.out.println("디버깅 : " + arr[i][j]);
			}
		} // for문이 끝났기 때문에 for문 안의 i,j와 밑의 i,j는 충돌하지 않음
		
		for(int i=0; i<4; i++) {
			for (int j=0; j<3; j++) {
				System.out.print(arr[i][j]+"\t"); // \t = tab키의 역할과 동일
			}
			System.out.println();
		}
	}

}
