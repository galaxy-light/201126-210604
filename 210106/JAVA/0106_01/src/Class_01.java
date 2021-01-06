
public class Class_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 여기 쓰여진 것은 객체지향언어로 쓰여진 것이 아님
		// Student S가 대문자이기 때문에 class
		// Student : 타입 / s : 변수명 / Student(); : 생성자 / new Student(); : 객체를 생성하는 직접적인 부분(인스턴스 생성)
		Student s = new Student(); // 객체/인스턴스 생성
		s.name = "홍길동"; // s가 name, tel, email을 가리키고 있어서 인스턴스 변수 안에 홍길동을 넣을 수 있음
		s.email = "hong@naver.com";
		s.tel = "010-1234-5678";
		s.name = "김길동"; // 동일한 객체 사용
		
		System.out.println("이름 : " + s.name);
		System.out.println("이메일 : " + s.email);
		System.out.println("전화 : " + s.tel);
		System.out.println("과정 : " + Student.category);
		
		Student ss = new Student(); // Student s = new Student();와 다른 객체 생성
		ss.name = "이길동";
		ss.email = "lee@naver.com";
		ss.tel = "010-9876-5432";
		System.out.println("이름 : " + ss.name); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("이메일 : " + ss.email); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("전화 : " + ss.tel); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("과정 : " + Student.category);
	}

}

// 주소록 class 정의 : class를 쓰기 위해서는 반드시 객체 생성을 해야 됨
class Student {
	// class 변수 / static이라는 변수는 최초에 한번만 만들어짐
	static String category = "통합응용SW개발"; // static이라는 키워드가 붙은 것은 class명으로 바로 접근이 가능함 // 객체와 아무 상관 없음
	// 인스턴스 변수 : 인스턴스 안에 잡혀있기 때문에 변수를 인스턴스 변수라고 함
	String name; // 추상화 : 특징을 뽑아내는 것
	String tel; // 추상화 : 특징을 뽑아내는 것
	String email; // 추상화 : 특징을 뽑아내는 것
}


