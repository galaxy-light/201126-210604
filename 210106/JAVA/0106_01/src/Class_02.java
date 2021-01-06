
public class Class_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// // 여기 쓰여진 것은 객체지향언어로 쓰여진 것이 아님
		// Student S가 대문자이기 때문에 class / 사용자 정의 타입
		// Student : 타입 / s : 변수명 / Student(); : 생성자 / new Student(); : 객체를 생성하는 직접적인 부분(인스턴스 생성)
		Student2 s = new Student2(); // 객체/인스턴스 생성		
		s.setName("홍길동");
		s.setEmail("hong@naver.com");
		s.setTel("010-1234-5678");		
		System.out.println("이름 : " + s.getName());
		System.out.println("이메일 : " + s.getEmail());
		System.out.println("전화 : " + s.getTel());
		System.out.println("과정 : " + Student.category);	
		
		Student2 ss = new Student2(); // Student s = new Student();와 다른 객체 생성
		ss.setName("최길동");
		ss.setEmail("choi@naver.com");
		ss.setTel("010-9876-5432");
		System.out.println("이름 : " + ss.getName()); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("이메일 : " + ss.getEmail()); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("전화 : " + ss.getTel()); // 값을 입력하지 않으면 결과값으로 null 출력
		System.out.println("과정 : " + Student.category);
		
		// 익명 객체
		// new Student2(); // 객체 생성 / Student2 s = new Student2();와 같이 객체가 생성를 생성하지만 쓸 수가 없음(변수가 없기 때문)
		new Student2().setName("박길동"); // 매개 변수 전달용으로 이렇게 썼지만 객체로 접근할 방법이 없음(재사용 불가)
		System.out.println(new Student2().getName()); // 이렇게 썼지만 객체로 접근할 방법이 없음
	}

}

// 주소록 class 정의 : class를 쓰기 위해서는 반드시 객체 생성을 해야 됨
//class Student2 {
//	// class 변수 / static이라는 변수는 최초에 한번만 만들어짐
//	static String category = "통합응용SW개발"; // static이라는 키워드가 붙은 것은 class명으로 바로 접근이 가능함 // 객체와 아무 상관 없음
//	// 인스턴스 변수 : 인스턴스 안에 잡혀있기 때문에 변수를 인스턴스 변수라고 함
//	// private : 캡슐화(정보은닉) : private를 쓰면 class Student2안에서만 사용이 가능해짐	
//	 private String name; // 추상화 : 특징을 뽑아내는 것
//	 private String tel; // 추상화 : 특징을 뽑아내는 것
//   private String email; // 추상화 : 특징을 뽑아내는 것
//     
//    // 인스턴스 변수 : 인스턴스 안에 잡혀있기 때문에 변수를 인스턴스 변수라고 함
// 	// public : 외부 class에서 접근 가능이 가능하나 좋은 방법이 아님
//  // public String name; // 추상화 : 특징을 뽑아내는 것
// 	// public String tel; // 추상화 : 특징을 뽑아내는 것
// 	// public String email; // 추상화 : 특징을 뽑
//     
//     // 인스턴스 메서드
//     // setter : 값을 설정함
//     public void setName(String name) { // private을 사용하기 위해 메서드를 만듦
//    	 // name = name; // 왼쪽 name은 메서드의 String name; 오른쪽 name은 메서드의 String name이 똑같아서 충돌이 일어남
//    	 // 충돌 방지를 위해 this를 씀 / 인스턴스 변수에서만 this를 쓸 수 있음
//    	 // this : 생성되어진 객체의 위치 정보가 들어있음
//    	 this.name = name; // 왼쪽 name은 private String name; 오른쪽 name은 메서드의 String name
//     }
//     
//     // getter : 값을 가져옴
//     public String getName() {
//    	 return name;
//     }
//    
//    // 자동생성 : 메뉴-Source-Generate getters and setters-선택-Generate
//	public String getTel() {
//		return tel;
//	}
//
//	public void setTel(String tel) {
//		this.tel = tel;
//	}
//
//	public String getEmail() {
//		return email;
//	}
//
//	public void setEmail(String email) {
//		this.email = email;
//	}
//     
//}

