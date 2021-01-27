package thread0127;

import java.awt.Toolkit;

public class Thread_03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BeepTask task = new BeepTask(); // 왼쪽 BeepTask에 Runnable을 넣어도 동작함(다형성 개념)
		Thread th = new Thread(task);
		th.start();
		
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


// Runnable 인터페이스를 사용
// Interface는 반드시 오버라이딩을 해주어야 함
class BeepTask implements Runnable { // implements : 사용자가 특정 기능을 가져와서 사용하는 것 / Runnable : 인터페이스
	@Override
	public void run() {
		// TODO Auto-generated method stub
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