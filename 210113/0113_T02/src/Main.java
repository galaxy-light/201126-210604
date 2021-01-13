
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Car car = new Car(); // new Car(); : 객체 생성 / ()가 있으면 메서드
		
		// 객체 안에 들어와 있는 인스턴스 정보 출력
		car.showCarInfo();
		
		// 객체를 생성할 때만 사용되어지는 메서드, 정보를 초기화하는 역할을 함
		Car car2 = new Car("그랜저", "현대", "흰색", "4천만원");
		// new Car("그랜저", "현대", "흰색", "4천만원"); : 객체 생성
		car2.showCarInfo();
		
		new Car().showCarInfo(); // 한 번만 쓰여지고 재사용 불가(마킹을 하지 않았기 때문)
	}

}
