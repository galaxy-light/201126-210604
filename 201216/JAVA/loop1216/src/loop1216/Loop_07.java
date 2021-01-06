package loop1216;

public class Loop_07 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = 0;
		for (int i=0; i<10; i++) {
			if ((i+1) % 3 == 0) { // 3의 배수를 구함(3으로 나눈 나머지가 0 : 3의 배수)
				continue; // continue; : 반복문에서 사용자가 원하는 제어를 하도록 함 -> 반복문 처음으로 이동됨 : 3의 배수를 만나는 순간 처음으로
			}			
			System.out.println(i);
			hap += (i+1); // 3의 배수가 아닌 것은 계속 누적됨
		}
			System.out.println("3의 배수를 제외한 1~10까지 값 : " + hap);
			
		System.out.println("-------------------------------------------");
		// 2의 배수 제외
		hap = 0;
		for (int i=0; i<10; i++) {
			if ((i+1) % 2 == 0) { // 2의 배수를 구함(2로 나눈 나머지가 0 : 2의 배수)
				continue; // continue; : 반복문에서 사용자가 원하는 제어를 하도록 함 -> 반복문 처음으로 이동됨 : 3의 배수를 만나는 순간 처음으로
			}
			hap += (i+1); // 2의 배수가 아닌 것은 계속 누적됨
		}	
			System.out.println("2의 배수를 제외한 1~10까지 값 : " + hap);
			
		System.out.println("--------------------------------------------");
		hap = 0;
		for (int i=0; i<10; i++) {
			if ((i+1) % 3 == 0) { 
				continue; 
			}
			System.out.println("i+1 : " +(i+1));
			hap += (i+1);	
		
			if (i==5) { // (i==5) : i가 5까지만 반복 수행
				System.out.println("탈출"); // 디버깅 방법
				break;
			}			
		}
	}
}
