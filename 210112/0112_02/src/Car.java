
public class Car {
	private String brand;
	private String color;
	private String money;
	private String model;
	
	static String place = "동대구 영업소";
	
	public Car() {
		brand = "기아";
		color = "블랙";
		money = "4천만원";
		model = "K7";		
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

	public String getMoney() {
		return money;
	}

	public void setMoney(String money) {
		this.money = money;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}
	
	public void showCarInfo() {
		System.out.println("제조사 : " + brand);
		System.out.println("색상 : " + color);
		System.out.println("이름 : " + model);
		System.out.println("가격 : " + money);
		System.out.println("대리점명 : " + place);
		
	}
	
	public Car(String brand, String color, String money, String model) {
		super();
		this.brand = brand;
		this.color = color;
		this.money = money;
		this.model = model;
	}
	

}
