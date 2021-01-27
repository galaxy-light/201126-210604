package thread0127;

public class Thread_05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		AutoThread th = new AutoThread();
		// 데몬스레드는 메인스레드의 종속적인 부분
		// 데몬스레드가 종료되면 자동으로 종료됨
		th.setDaemon(true); // 작업 스레드를 데몬 스레드(특수한 스레드)로 만들겠다라는 뜻
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


class AutoThread extends Thread {
	public void save () {
		System.out.println("작업 내용 저장");		
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		while (true) {
			try {
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				break;
			}
			save();
		}
		System.out.println("작업 스레드 종료");
	}
}