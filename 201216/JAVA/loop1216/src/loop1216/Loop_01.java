package loop1216;

public class Loop_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/* for (초기값; 조건; 증가){
			실행문;
		}
		*/
		// 가급적 초기값은 0으로 설정
		for (int i=0; i<5; i++) {
			System.out.println("반복 횟수 : " + i);			
		}
		
		System.out.println();
		
		for (int j=5; j>0; j--) {
			System.out.println("반복 횟수 : " + j);
		}
	}

}
