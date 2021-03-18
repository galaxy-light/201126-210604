// https://blog.naver.com/hack4ork/221671486484
public class Test07_method_08 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		func();
	}
	
	public static void func() {
		for (int i = 1; i <= 9; i++) {
			for (int j = 2; j <= 9; j++) {
				if (j%2!=0) {
					System.out.print(j +"*"+ i +"="+i*j+"\t");
				}
			}
			System.out.println();
		}
		
	}
}
