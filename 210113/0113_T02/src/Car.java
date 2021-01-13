
public class Car {	
	// static 변수는 최초에 한 번만 작성(인스턴스와 다른 영역이기 때문에) : class 변수
	public static final String JIJUM = "동대구 영업소"; // 상수 변수는 대문자로 작성
	
	// 인스턴스 변수
	private String model;
	private String company;
	private String color;
	private String price;
			
	// Source-Generate Constructor using Fields-전체 체크 해제-Generate
	// 매개변수를 사용하지 않는 기본 생성자
	// 객체가 생성되어질 때 생성자
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
	// 객체가 생성되어질 때 생성자
	// 생성자는 void 사용X -> 객체를 생성할 때 한번만 사용하기 때문
	// 오버로딩(중복 정의) : 매개변수가 달라야하고 매개변수의 개수가 같다면 매개변수의 타입이 달라야 함
	public Car(String model, String company, String color, String price) {
		super();
		this.model = model;
		this.company = company;
		this.color = color;
		this.price = price;
	}
	
	// 인스턴스 메서드
	// Source-Generate Getters and Setters
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}

	// 변수 정보 출력
	// showCarInfo : 인스턴스 메서드
	// out : static으로 선언되어 있음
	public void showCarInfo() {	
		System.out.println("-------------------");
		System.out.println("영업소 : " + Car.JIJUM); // Car.JIJUM : class.변수	
		System.out.println("-------------------");
		System.out.println("제조사 : " + company);
		System.out.println("모델 : " + model);
		System.out.println("가격 : " + price);
		System.out.println("색상 : " + color);		
	}	
	
}
