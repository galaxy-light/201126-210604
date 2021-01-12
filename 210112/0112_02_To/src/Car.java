
// 최상위 object에서 상속받아서 사용

public class Car {	
	private String model;
	private int year;
	private String money;
	
	// 상수 클래스 변수
	// 최초에 한 번만 생성되어짐
	public static final String place = "동대구영업소";
	
	// 오버로딩 : 서로 다른 두 개의 메서드
	public Car() {
		
	}
	
	// 객체가 생성될 때 초기화
	// 매개변수가 존재하는 생성자
	public Car(String model, int year, String money) {
		super();
		this.model = model;
		this.year = year;
		this.money = money;
	}

	// getter, setter
	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}

	public String getMoney() {
		return money;
	}

	public void setMoney(String money) {
		this.money = money;
	}
	
	
	// 메서드를 출력할 메서드
	public void showCarInfo() {
		System.out.println("모델 : " + model);
		System.out.println("연식 : " + year);
		System.out.println("가격 : " + money);
		System.out.println("----------------");		
	}
	
	
}
