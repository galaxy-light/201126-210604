
public class Car {
	// class 변수
	// static 변수는 한번만 작성
	public static final String JIJUM = "동대구 영업소"; // 상수 변수는 대문자로 작성
	
	// 인스턴스 변수
	private String model;
	private String company;
	private String color;
	private String price;
			
	// Source-Generate Constructor using Fields-전체 체크 해제-Generate
	// 매개변수를 사용하지 않는 기본 생성자
	// 생성자는 void 사용X -> 객체를 생성할 때 한번만 사용하기 때문
	public Car() {
		super(); // super(); : 부모의 위치값 -> 객체지향의 상속을 살리기 위해서 사용
		// 초기값 : 객체를 생성할 때 초기값으로 고정됨
		model = "K7";
		company = "KIA";
		color = "Black";
		price = "4천만원";
	}
	
	// Source-Generate Constructor using Fields-전체 체크-Generate
	// 매개변수를 사용하는 기본 생성자
	// 생성자는 void 사용X -> 객체를 생성할 때 한번만 사용하기 때문
	public Car(String model, String company, String color, String price) {
		super();
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}
	
	// 변수 정보 출력
	public void showCarInfo() {
		System.out.println("차량 영업소 : " + Car.JIJUM); // Car.JIJUM : class.변수
		System.out.println("제조사 : " + company);
		System.out.println("모델 : " + model);
		System.out.println("가격 : " + price);
		System.out.println("색상 : " + color);
	}	
	
}
