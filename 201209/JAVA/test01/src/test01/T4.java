package test01;

public class T4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int a = 50;
		
		
		/* && : 논리 AND 연산자 : 하나라도 false면 false
		 * true && true : true
		 * true && false : false
		 * false && false : false
		 * false && true : false
		 */
		System.out.println(a > 30 && a < 100); // true
		System.out.println(a > 40 && a < 30); // false
		System.out.println(a > 60 && a < 40); // false
		System.out.println(a > 70 && a < 60); // false
		
		/* || : 논리 OR 연산자 : 하나라도 true면 true
		 * true || true : true
		 * true || false : true
		 * false || false : false
		 * false || true : true
		 */
		System.out.println(a > 10 || a < 70); // true
		System.out.println(a > 20 || a < 40); // true
		System.out.println(a > 60 || a < 30); // false
		System.out.println(a > 70 || a < 60); // true

	}

}
