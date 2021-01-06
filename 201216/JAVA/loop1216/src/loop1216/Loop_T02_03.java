package loop1216;

public class Loop_T02_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("----------------------");
		System.out.println("5의 배수 출력 프로그램 v1.0");
		System.out.println("----------------------");
		int i = 0;
		do {
			if((i+1)%5 == 0) {
				System.out.println(i+1);
			}
			i++;			
		}while(i<101);
	}
}
