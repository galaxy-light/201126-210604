
public class Method_02 {
	public static int plus(int num1, int num2) {
		int result = 0;
		result = num1 + num2;
		return result; // 타입과 리턴값 일치
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int hap = plus(100, 200); // 100->num1 200->num2에 저장
		System.out.println("hap : " + hap);
		
		System.out.println("hap : " + plus(200, 300)); // 200->num1 300->num2에 저장
	}

}
