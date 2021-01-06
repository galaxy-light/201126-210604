package loop1216;

public class Loop_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = 0;
		for (int i=0; i<10; i++) {
			hap = hap + (i+1); // hap += (i+1); 과 동일함
		}
		System.out.println("1~10까지 합 : " + hap);
	}	
	
}
