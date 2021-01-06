
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Array s = new Array();
		
		int arr[] = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
		int hap [] = new int [1];
		int avg [] = new int [1];
		for (int i = 1; i < arr.length; i++) {
			hap[1] += i;
			avg[1] = hap[1]/10;
			System.out.println(hap[1]);			
			System.out.println(avg[1]);
		}
		
		
	}

}
