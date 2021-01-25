// https://blog.naver.com/hack4ork/221671058863
package car;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// 1번 문제
		Car car = new Car();
		car.showCarInfo();		
		
		// 2번 문제
		Car car2 = new Car("제네시스", "현대", "흰색", "오천만원");
		car2.showCarInfo();
		
		car.setBrand("현대");
		car.setColor("블루");
		car.setModel("코나");
		car.setPrice("삼천만원");
		car.showCarInfo();
		
	}

}
