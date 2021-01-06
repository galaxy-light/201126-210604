import java.util.Scanner;

public class Test1208_4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub		
		Scanner a = new Scanner(System.in);
		System.out.print("화씨 온도 입력 : ");
		float b = a.nextFloat();

	
		// 화씨 온도를 섭씨 온도로 변환 : 섭씨온도 = (화씨 온도-32)/1.8
		float d = (b-32)/1.8f;
		System.out.println("섭씨 온도 : " + d);
	}

}
