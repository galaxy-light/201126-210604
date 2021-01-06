
public class Student2 {
	// class 변수 / static이라는 변수는 최초에 한번만 만들어짐
		static String category = "통합응용SW개발"; // static이라는 키워드가 붙은 것은 class명으로 바로 접근이 가능함 // 객체와 아무 상관 없음
		// 인스턴스 변수 : 인스턴스 안에 잡혀있기 때문에 변수를 인스턴스 변수라고 함
		// private : 캡슐화(정보은닉) : private를 쓰면 class Student2안에서만 사용이 가능해짐	
		 private String name; // 추상화 : 특징을 뽑아내는 것
		 private String tel; // 추상화 : 특징을 뽑아내는 것
	     private String email; // 추상화 : 특징을 뽑아내는 것
	     
	    // 인스턴스 변수 : 인스턴스 안에 잡혀있기 때문에 변수를 인스턴스 변수라고 함
	 	// public : 외부 class에서 접근 가능이 가능하나 좋은 방법이 아님
	    // public String name; // 추상화 : 특징을 뽑아내는 것
	 	// public String tel; // 추상화 : 특징을 뽑아내는 것
	 	// public String email; // 추상화 : 특징을 뽑
	     
	     // 인스턴스 메서드
	     // setter : 값을 설정함
	     public void setName(String name) { // private을 사용하기 위해 메서드를 만듦
	    	 // name = name; // 왼쪽 name은 메서드의 String name; 오른쪽 name은 메서드의 String name이 똑같아서 충돌이 일어남
	    	 // 충돌 방지를 위해 this를 씀 / 인스턴스 변수에서만 this를 쓸 수 있음
	    	 // this : 생성되어진 객체의 위치 정보가 들어있음
	    	 this.name = name; // 왼쪽 name은 private String name; 오른쪽 name은 메서드의 String name
	     }
	     
	     // getter : 값을 가져옴
	     public String getName() {
	    	 return name;
	     }
	    
	    // 자동생성 : 메뉴-Source-Generate getters and setters-선택-Generate
		public String getTel() {
			return tel;
		}

		public void setTel(String tel) {
			this.tel = tel;
		}

		public String getEmail() {
			return email;
		}

		public void setEmail(String email) {
			this.email = email;
		}
}
