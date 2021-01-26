import java.util.Scanner;

public class Year {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("연도 입력 : ");
		int num = s.nextInt();
		String arr[] = {"쥐", "소", "호랑이", "토끼", "용", "뱀",
				"말", "양", "원숭이", "닭", "개", "돼지"};	
		for (int i = 0; i < arr.length; i++) {
			if (num%12==1) {
				System.out.println(arr[9]);
				break;
			}
			else if (num%12==2) {
				System.out.println(arr[10]);
				break;
			}
			else if (num%12==3) {
				System.out.println(arr[11]);
				break;
			}
			else if (num%12==4) {
				System.out.println(arr[0]);
				break;
			}
			else if (num%12==5) {
				System.out.println(arr[1]);
				break;
			}
			else if (num%12==6) {
				System.out.println(arr[2]);
				break;
			}
			else if (num%12==7) {
				System.out.println(arr[3]);
				break;
			}
			else if (num%12==8) {
				System.out.println(arr[4]);
				break;
			}
			else if (num%12==9) {
				System.out.println(arr[5]);
				break;
			}
			else if (num%12==10) {
				System.out.println(arr[6]);
				break;
			}
			else if (num%12==11) {
				System.out.println(arr[7]);
				break;
			}
			else if (num%12==0) {
				System.out.println(arr[8]);
				break;
			}
		}
		s.close();
	}

}
