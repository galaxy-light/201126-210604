
public class Exam1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		for (int i=0; i<2; i++) {
			for(int j=0; j<3; j++) {
				// 순서 : i가 한번 돌고 j가 세번 돌고
				// i=0, j=0, 1, 2
				// i=1, j=0, 1, 2
			}
		}
		
		for(int i=0; i<3; i++) {
			for (int j=0; j<4; j++) {
				// i가 한번 돌때 j가 네번 돌고
				// i=0, j=0, 1, 2, 3
				// i=1, j=0, 1, 2, 3
				// i=2, j=0, 1, 2, 3
			}
				
		}
		
		for(int i=0; i<4; i++) {
			for (int j=0; j<2; j++) {
				// i가 한번 돌때 j가 두번 돌고
				// i=0, j=0, 1
				// i=1, j=0, 1
				// i=2, j=0, 1
				// i=3, j=0, 1
				System.out.printf("i:%d, j:%d\n", i, j);
				
			}				
		}
		
	}	
}
