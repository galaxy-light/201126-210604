package switch1215;

public class Switch_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Math : 대문자이기 때문에 Class = 수학 Class
		// random 메서드
		// random()*4 : 0~3 사이의 숫자를 랜덤으로 뽑아줌
		int time1 = (int) (Math.random()*4);
		System.out.println("현재 시간 : " + time1);
		// random()*@ 에서 1부터 뽑고 싶을 때는 random()*4+1 해주면 됨
		int time2 = (int) (Math.random()*4)+1;
		System.out.println("현재 시간 : " + time2);
		//
		int time3 = (int) (Math.random()*4)+8;
		System.out.println("현재 시간 : " + time3);
		switch (time3) {
		case 8 :
			System.out.println("출근"); // break;가 없기 때문에 결과값에 출근회의업무출장 다 뜸
		case 9 :
			System.out.println("회의"); // break;가 없기 때문에 결과값에 출근회의업무출장 다 뜸
		case 10 :
			System.out.println("업무"); // break;가 없기 때문에 결과값에 출근회의업무출장 다 뜸
		default :
			System.out.println("출장"); // break;가 없기 때문에 결과값에 출근회의업무출장 다 뜸
		}
	}

}
