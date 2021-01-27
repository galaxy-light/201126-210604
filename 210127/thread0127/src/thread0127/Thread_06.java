package thread0127;

import java.io.File;
import java.io.IOException;

public class Thread_06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		FileDir fileDir = new FileDir();
		fileDir.start();
	}

}


class FileDir extends Thread {
	public void run() {
		subDirList("c:\\"); // 경로 설정
		// "c:\\" : \를 사용할거면 \를 두개 사용해야 됨
	}
	
	public void subDirList(String source) { // String source에 파일 경로가 들어옴
		File dir = new File(source);
		File[] fileList = dir.listFiles();
		
		for (int i = 0; i < fileList.length; i++) {
			File file = fileList[i];
			if (file.isFile()) {
				String name = file.getName();
				System.out.println("파일 : " + name);
			}
			else if (file.isDirectory()) {
//				System.out.println("폴더 : " + file.getName());
				try {
					String name = file.getCanonicalPath().toString(); // .getCanonicalPath() : 절대 경로
//					subDirList(file.getCanonicalPath().toString()); // subDirList : 재귀호출 / .getCanonicalPath() : 절대 경로
					subDirList(name);
					Thread.sleep(10); // 오류를 명확하게 보기 위해 catch (IOException e)를 사용
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (InterruptedException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (NullPointerException e) { // 사용자가 접근할 수 없는 폴더
					// TODO Auto-generated catch block
					System.out.println("시스템 폴더 제한");
				}
			}
		}
	}
}