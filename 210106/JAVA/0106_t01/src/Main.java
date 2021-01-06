
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Car s = new Car(); // 객체/인스턴스 생성
		
		s.setBrand("기아");
		s.setColor("블랙");
		s.setName("K7");
		s.setPrice("사천만원");
		System.out.println("대리점명 - " + Car.place);
		s.showCarInfo();
	}

}
