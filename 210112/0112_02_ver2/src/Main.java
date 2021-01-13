
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Car car = new Car();
		car.setModel("K7");
		car.setYear(2020);
		car.setMoney("4천만원");
		System.out.println("대리점명 : " + car.place);
		car.showCarInfo();		
		
	}

}
