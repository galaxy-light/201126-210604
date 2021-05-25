package car;

public class Car {
	private String brand;
	private String color;
	private String model;
	private String price;
	
	public static final String place = "동대구 영업소"; // 상수 변수
	
	public Car() {
		super();
		this.brand = "기아";
		this.color = "블랙";
		this.model = "K7";
		this.price = "사천만원";
	}		

	public Car(String brand, String color, String model, String price) {
		super();
		this.brand = brand;
		this.color = color;
		this.model = model;
		this.price = price;
	}

	public String getBrand() {
		return brand;
	}

	public void setBrand(String brand) {
		this.brand = brand;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

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

	public static String getPlace() {
		return place;
	}
	
	public void showCarInfo() {
		System.out.println("제조사 : " + brand);
		System.out.println("색상 : " + color);
		System.out.println("이름 : " + model);
		System.out.println("가격 : " + price);
		System.out.println("대리점명 : " + Car.place);
		System.out.println("--------------------");
	}
	
}
	
