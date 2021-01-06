package loop1216;

public class Loop_06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = 0;  // 초기값
		int i = 0; // 초기값 
		while (i<10) {
			hap = hap + (i+1); // hap += (i+1) 과 동일함
			i++;
		}
		System.out.println("1~10까지 합 : " + hap);
		
		System.out.println("----------------------------");
		hap = 0;
		i = 0;
		
		do {
			hap += (i+1);
			i++;
		} while (i<10);
		System.out.println("1~10까지 합 : " + hap);
	}

}
