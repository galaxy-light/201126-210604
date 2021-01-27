package thread0127;

public class Thread_01 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
		MyThread t1 = new MyThread("T1"); // 스레드 객체 생성 / 객체를 생성하려면 무조건 생성자가 있어야 함
		MyThread t2 = new MyThread("T2"); // 스레드 객체 생성
		t1.start(); // t1 스레드 객체 동작(run) 시작
		t2.start(); // t2 스레드 객체 동작(run) 시작
		// 메인에서 돌아가는 동작
		for (int i = 0; i < 10; i++) {
			System.out.println("Main 스레드 동작중");
			Thread.sleep(1000); // InterruptedException / try catch 둘 중에 하나 쓰면 됨
		}
		System.out.println("메인 스레드 종료");		
	}
}

// 스레드는 독자적으로 동작하기 때문에 사용자가 일시정지 시키는 장치는 없음
class MyThread extends Thread { // extends : java 상속 기본 문법 / Thread : 부모 클래스
	String str;
	
	// 매개변수를 가지는 생성자 / 객체를 생성하기 위해선 무조건 생성자가 있어야 됨
	public MyThread(String str) {
		this.str = str;
	}
	
	// 스레드를 사용하기 위해서는 반드시 run이라는 메서드가 있어야 됨
	// Source-Override/Implement Methods-run()체크-OK	
	// 오버라이딩 : 부모의 것을 재정의 / 오버로딩 : 중복정의
	// {}안이 work(작업) 스레드로 동작하는 부분
	@Override
	public void run() {
		// TODO Auto-generated method stub
		super.run(); // super.run(); : 있어도 되고 없어도 됨
		for (int i = 0; i < 10; i++) {
			System.out.println(str);
			// 1000ms = 1sec(=1초)
			try { // try catch : 예외처리
				Thread.sleep(1000); // 기본 단위 : ms / sleep(); : 딜레이
				// 딜레이를 안주면 너무 빨리 돌아가기 때문에 딜레이를 줌
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} 			
		}
		System.out.println("작업 스레드 종료");
	}		
}