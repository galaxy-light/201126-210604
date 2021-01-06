
public class Switch_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Math : 첫문자가 대문자면 Class : 수학 Class
		/* random 메서드
		 * 	ex) random()*4 : 0~3 사이의 숫자를 랜덤을 뽑아줌
		 */
		int num1 = (int)(Math.random()*4);
		System.out.println("첫번째 숫자 : " + num1);
		// 만약 1부터 뽑고 싶다면 +1을 붙여주면 됨 : random()*4+1
		int num2 = (int)(Math.random()*4+1);
		System.out.println("두번째 숫자 : " + num2);
		
		//--------------------
		int time = (int)(Math.random()*4)+8; // 8부터 *4면 8,9,10 : 3개의 숫자 중 하나가 뽑힘
		System.out.println("시간 : " + time + "시");
		switch(time) {
		case 8 :
			System.out.println("기상"); 
			break;							// 만약 break;가 없다면 기상출근회의출장 전부 결과값으로 나옴	
		case 9 :
			System.out.println("출근");
			break;							// 만약 break;가 없다면 기상출근회의출장 전부 결과값으로 나옴	
		case 10 :
			System.out.println("회의");
			break;							// 만약 break;가 없다면 기상출근회의출장 전부 결과값으로 나옴
		default : 
			System.out.println("출장");
		}
		
	}

}
