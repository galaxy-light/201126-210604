package test01;

public class T2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// ++, -- : 증감연산자
		int a = 5;
	
		int b = a++;
		System.out.println("B : " + b);
		// 결과값 5 : ++가 a 뒤에 붙었기 때문에 a에 영향을 주지 않음
		
		int c = ++a;
		System.out.println("C : " + c);
		// 결과값 7 : ++가 a 앞에 붙어서 a에 영향을 줌 +1, +1이 되어 +2 = 2+5=7
		
		int d = a--;
		System.out.println("D : " + d);
		// 결과값 7 : 마찬가지로 --가 a 뒤에 붙었기 때문에 내려온 7에 영향을 주지 않음
		
		int e = --a;
		System.out.println("E : " + e);
		// 결과값 5 : --가 a 앞에 붙어서 내려온 7에 -1, -1하여 -2 = 7-2=5

	}

}
