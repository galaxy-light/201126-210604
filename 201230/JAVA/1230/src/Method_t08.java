
public class Method_t08 {
	// 문제 : 2~9단의 구구단 중 홀수단만 출력하는 프로그램
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		func();
	}
	
	public static void func() {
		for (int i = 1; i < 10; i++) {
			for (int j = 2; j < 10; j++) {
				if (j%2==1) {
					System.out.printf("%dx%d=%d\t", j,i,j*i);					
				}				
			}
			System.out.println();
		}
	}
}
