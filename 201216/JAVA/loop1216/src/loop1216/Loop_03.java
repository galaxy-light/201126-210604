package loop1216;

public class Loop_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = 0;
		for (int i=0; i<10; i+=2) { // i+=2 : i가 2씩 증가
			hap += (i+1);
		}
		System.out.println("1~10까지 홀수합 : " + hap); // 25
		
		System.out.println("---------------------------");
		
		for (int j=0; j<10; j++) {
			hap += (j+1);
		}
		System.out.println("1~10까지 홀수합2 : " + hap); // 25를 누적시켜서 80
		
		System.out.println("---------------------------");
		
		hap = 0; // 초기값 설정
		for (int j=0; j<10; j++) { // j++ : j에 1을 더함
			hap += (j+1);
		}
		System.out.println("1~10까지 합 : " + hap); // 55
		
		System.out.println("---------------------------");
		
		hap = 0; // j를 2로 나누면 홀수
		for (int j=0; j<10; j++) {
			if ((j+1) % 2 == 1) { // % : 나머지 연산자
				hap += (j+1);
			}
		}
		System.out.println("1~10까지 홀수합3 : " + hap);
	}
}
