package loop1216;

public class Loop_08 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = 0;
		for (int i=1; i<=10; i++) {
			if (i % 3 == 0) { 
				continue; 
			}
			System.out.println("i : " + i);
			hap += i;	
		
			if (i==5) { // (i==5) : i가 5까지만 반복 수행
				System.out.println("탈출"); // 디버깅 방법
				break;
			}			
		}
		System.out.println("3의 배수를 제외한 1~10까지 값 : " + hap);
	}
}
