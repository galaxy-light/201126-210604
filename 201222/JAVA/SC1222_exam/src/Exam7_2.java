import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

public class Exam7_2 {

	public static void main(String[] args) throws FileNotFoundException {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		while(true) {
		System.out.println("----------------------");
		System.out.println("간단한 파일 관리 프로그램 1.0");
		System.out.println("----------------------");
		System.out.println("1. 파일 생성 및 쓰기");
		System.out.println("2. 파일 읽기");
		System.out.println("3. 프로그램 종료");
		System.out.println("--------------------");
		System.out.print("메뉴를 선택하세요 : ");
		int menu = s.nextInt();
		switch(menu){
			case 1:
				System.out.println("파일 생성 및 쓰기 예제입니다.");
				BufferedOutputStream bs = null;
				String str = null;
				String fileName = "d:/test1.txt";
			try {	
				bs = new BufferedOutputStream(new
					FileOutputStream(fileName));
				str = "파일 생성 및 쓰기 예제입니다.";
				bs.write(str.getBytes());
				s.close();				
			} catch(FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {				
				e.printStackTrace();
			}
			System.out.println("파일명 : " + fileName);
			System.out.println("파일내용 : ");
			System.out.println("파일 생성이 성공하였습니다.");
				break;
			case 2:			
				System.out.println("파일에서 내용 읽어오기");
				break;
			case 3:
				System.out.println("프로그램 종료");
				System.exit(0);
				break;
			default:
				System.out.println("잘못된 입력값!");
				break;
		}
		
	}

}
}