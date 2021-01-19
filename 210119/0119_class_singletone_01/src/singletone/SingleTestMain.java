// https://blog.naver.com/hack4ork/221670752134
package singletone;

public class SingleTestMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 인스턴스 객체 사용
		System.out.println("--------------");
		System.out.println("인스턴스 객체 생성");
		System.out.println("--------------");
		for (int i = 0; i < 5; i++) {
			System.out.println(new SingleTest().getData());
		}
		
		// 싱글톤 개념 : 한번 만들어진 객체를 재사용
		// : 인스턴스 값이 null이기 때문에 최초에 만들어진 값을 계속 호출
		// 결과값을 보면 최초의 값을 계속 돌려 출력함
		System.out.println("-------------");
		System.out.println("싱글톤 객체 생성");
		System.out.println("-------------");
		for (int i = 0; i < 5; i++) {
			System.out.println(SingleTest.getInstance().getData());
		}
	}
}
