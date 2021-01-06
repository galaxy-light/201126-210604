
public class Method_t07 {
	// 문제 : 1~100까지의 짝수합, 홀수합을 구하는 프로그램
	public static int [] func(){
		int arr1 [] = new int [2];
		
		for (int i = 1; i <= 100; i++) {
			if (i%2==0) {
				arr1[0] += i;
				
			}
			else if (i%2==1) {
				arr1[1] += i;	
				
			}			
		}
		return arr1;
	}	
						
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		func();
		System.out.println(func());
		
		int a[] = func();
		
		System.out.println("짝수 합 : " +a[0]);
		System.out.println("홀수 합 : " +a[1]);
		
	}

}
