import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FilterOutputStream;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Array_t07 {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		// 변하지 않는 변수는 맨 위에 적는 것이 낫다.
		final String last[] = {"김", "박", "이", "최", "장"};
		final String first[] = {"바", "사", "아", "자", "차"};
		final String mid[] = {"가", "나", "다", "라", "마"};
		String fullName[] = new String[50];
		final String fileName = "d:/test1.txt";
		Scanner s = new Scanner(System.in);

		while (true) {
			System.out.println("------------------------");
			System.out.println("파일 제어 프로그램 v1.1");
			System.out.println("------------------------");
			System.out.println("1. 이름 생성하여 파일에 저장하기");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("------------------------");
			System.out.print("메뉴 선택 : ");
			int menu = s.nextInt();
			switch (menu) {
			case 1:
				BufferedOutputStream bs = null;				
				bs = new BufferedOutputStream(new FileOutputStream(fileName));
				for (int i=0; i<fullName.length; i++) {				
					fullName[i] = last[(int) (Math.random() * 5)] + first[(int) (Math.random() * 5)]
							+ mid[(int) (Math.random() * 5)]; 	
					bs.write(fullName[i].getBytes());
					bs.write("/".getBytes());
					/* for문 안에 이렇게도 사용 가능 
					* int rand = (int)(Math.random()*5)
					* fullName[i] = last[rand]+mid[rand]+first[rand];
					*/
					// 디버깅 코드 : System.out.println(fullName[i]);
				}	
				bs.close();
				System.out.println("이름 생성 파일 저장 완료!");
				break;
			case 2:
				String str = "장차마/이차가/김자나";
				StringTokenizer stk = new StringTokenizer(str,"/");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());
				}
				break;
			case 3:
				s.close();
				System.exit(0); // 프로그램(프로세스) 강제 종료 / 프로세스 : 실행중인 프로그램 / 프로세서 : CPU
				break;
			default:
				System.out.println("잘못된 메뉴 선택!");
				break;
			}

		}

	}

}
