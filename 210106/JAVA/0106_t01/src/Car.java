
public class Car {
	private String brand;
	private String color;
	private String name;
	private String price;
	
	static String place = "동대구 영업소";
	
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
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPrice() {
		return price;
	}
	public void setPrice(String price) {
		this.price = price;
	}

	
	public void showCarInfo() {
		System.out.println("제조사 - " + brand);
		System.out.println("색상 - " + color);
		System.out.println("이름 - " + name);
		System.out.println("가격 - " + price);
		System.out.println("대리점명 - " + place);
	}
	
}


