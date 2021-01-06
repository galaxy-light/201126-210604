
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Student s = new Student(); // 객체/인스턴스 생성
		s.setName("홍길동"); // public이라는 키워드를 썼기 때문에 쓸 수 있음
		s.setTel("010-1234-5678"); // public이라는 키워드를 썼기 때문에 쓸 수 있음
		s.setEmail("hong@naver.com"); // public이라는 키워드를 썼기 때문에 쓸 수 있음
		s.showStudentInfo(); // Student class의 인스턴스 변수에서 전달 받아 출력
		
		Student s2 = new Student();
		s.setName("최길동");
		s.setTel("010-9876-5432");
		s.setEmail("choi@naver.com");
		s.showStudentInfo(); // Student class의 인스턴스 변수에서 전달 받아 출력
	}

}
