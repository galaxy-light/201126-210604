
public class Exam6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("----------------");
		System.out.println("구구단 프로그램 v1.0");
		System.out.println("----------------");
		
		for(int num1=1; num1<=9; num1++) {
			for(int num2=2; num2<=9; num2++) {
				
				System.out.print(num2 + "X" + num1 + "=" + (num1*num2) + "\t"); // \t : 자동 정렬
			}
			System.out.println("     ");
		}
	}
}
