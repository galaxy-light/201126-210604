package thread0127;

public class Thread_04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Thread th = new MovieThread(); // Thread : 다형성의 개념-객체지향의 특징(MovieThread를 써도 됨)
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
		th.interrupt(); // .interrupt(); : 제어권을 가로챔, 스레드에 특정 신호를 줌
	}
}


// 메인 스레드가 끝나도 독자적으로 무한 루프함
class MovieThread extends Thread {
	@Override
	public void run() {
		while (true) { // while (true) : 무한루프
			System.out.println("동영상 재생");
//			if (isInterrupted()) {
//				System.out.println("interrupt 신호 받음1");
//				break;
//			}
			try { // try catch가 interrupt의 신호를 if문보다 먼저 받음
				Thread.sleep(500);
			} catch (InterruptedException e) { // InterruptedException : 예외 처리 / 우선 순위가 높음
				// TODO Auto-generated catch block
				System.out.println("interrupt 신호 받음2");
//				e.printStackTrace(); // e.printStackTrace(); : 디버깅 용도
				break;
			}			
		}
//		System.out.println("작업 스레드 종료"); // 빨간줄이 그이는데 이것은 죽은 코드를 말함(무한 루프이기 때문)
	}
}
