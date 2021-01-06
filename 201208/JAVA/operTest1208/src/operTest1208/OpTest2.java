package operTest1208;

public class OpTest2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num1 = 10;
		int num2 = 0;
		
		/* ++, -- : 증감연산자
		 * ++ : 1 증가, -- : 1 감소
		 * 증가, 감소되는 시점에 따라 결과값이 달라짐
		 */
		num2 = num1++;
		// 뒤에 붙어있는 ++은 num1에 영향을 주지 않기 때문에 결과값 10
		System.out.println("num2 : " + num2);
		
		num2 = ++num1;
		// 앞에 붙어있는 ++은 num1이 바로 영향을 주기 때문에 +1, +1이 더해짐, 결과값 12
		System.out.println("num2 : " + num2);
		
		num2 = num1--;
		// 뒤에 붙어있는 --라서 위에서 내려온 12가 그냥 12가 됨
		System.out.println("num2 : " + num2);
		
		num2 = --num1;
		// 위에서 내려온 12에서 -1, -1을 빼주면 10이 됨
		System.out.println("num2 : " + num2);
		
	}

}
