package operTest1208;

public class OpTest4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num = 99;
		
		/* && : 논리 and 연산자 : 참이냐 거짓이냐
		 * true && true : true
		 * true && false : false
		 * false && true : false
		 * false && false : false		
		 */
		// num가 100보다 크거냐 같냐 and num가 200보다 작거나 같냐
		System.out.println("and 연산자 : " + (num >= 100 && num <= 200)); // false && true
		
		// || : 논리 or 연산자
		/* * true || true : true
		 * true || false : true
		 * false || true : true
		 * false || false : false
		*/
		System.out.println("or 연산자 : " + (num >= 100 || num <= 200)); // false || true : true
		
		// ! : 논리 not 연산자
		/* !(true) : false
		 * !(false) : true
		 */
		System.out.println("not 연산자 : " + !(num == 100));

	}

}
