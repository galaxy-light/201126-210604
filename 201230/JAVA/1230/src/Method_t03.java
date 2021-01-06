
public class Method_t03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 문제 : 10개의 숫자를 랜덤으로 입력받아 짝수, 홀수 구분
		int rand[] = new int[10];
		for (int i = 0; i < rand.length; i++) {				
			rand[i] = (int) (Math.random()*100)+1;
			System.out.println(rand[i]);;
		}
		func(rand);
	}
	
	public static void func(int rand[]) {
		for (int i = 0; i < rand.length; i++) {
			if (rand[i]%2==0) {
				System.out.println("짝수");
			}
			else{
				System.out.println("홀수");
			}
		}
		
	}
}
