
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Car car = new Car();
		
		car.setBrand("기아");
		car.setColor("블랙");
		car.setModel("K7");
		car.setMoney("사천만원");
		System.out.println("대리점명 : " + car.place);
		car.showCarInfo();	
		
		// constructor
		Car car1 = new Car("현대", "드래곤블루", "제네시스", "8천만원");
		car1.showCarInfo();
	}

}