package test01;

public class T5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 3항 연산자
		int a = 3;
		int b = 10;
		String str = ""; // ""안에 아무것도 없기 때문에 공백
		System.out.println(str);
		/* 물음표 앞에 있는 조건을 먼저 찾음
		 * 참이면 a가 크다, 거짓이면 b가 크다
		 */
		str = (++a >= b) ? "a가 크다" : "b가 크다"; // ++a:5 / 5 >= 10 : 거짓 : b가 크다
		System.out.println(str);

	}

}
