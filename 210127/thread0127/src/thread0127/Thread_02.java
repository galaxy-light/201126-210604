package thread0127;

import java.awt.Toolkit;

public class Thread_02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BeepThread beep = new BeepThread();		
		beep.start(); // .start(); : 작업 스레드 시작
		
		// 메인 스레드 시작
		for (int i = 0; i < 5; i++) {
			System.out.println("메인 스레드 동작 : " + i);
			try {
				Thread.sleep(500); //InterruptedException / try catch 둘 중에 하나 쓰면 됨
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		System.out.println("메인 스레드 종료");
	}
}


// extends를 쓰려면 부모 스레드가 있어야 됨 -> BeepThread : 자식 클래스 / extends : 상속 / Thread : 부모 클래스
// 부모 클래스인 Thread를 상속 받음
// extends은 오버라이딩을 할 수도 있고 안할 수도 있음
class BeepThread extends Thread {	
	// 스레드를 사용하기 위해서는 run()를 반드시 오버라이딩(재정의) 필요
	@Override
	public void run() {
		// TODO Auto-generated method stub
		// run안에서 동작하는 것이 작업 스레드
		super.run(); // super.run(); : 상속받은 부모 클래스의 run
		Toolkit toolkit = Toolkit.getDefaultToolkit();
		for (int i = 0; i < 5; i++) {
			toolkit.beep(); // "띵"소리가 남
			System.out.println("작업 스레드 : " + i);
			try {
				Thread.sleep(2000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}	
		System.out.println("작업 스레드 종료");
	}	
}