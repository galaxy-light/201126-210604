// https://blog.naver.com/hack4ork/221671058863 - 3번
package arr;

public class ArrayMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int arr [] = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
		
		Arrayresult re = new Arrayresult(arr);
		System.out.println("배열의 합 : " + re.getSum());
		System.out.println("배열의 평균 : " + re.getAvg());
	}	

}


class Arrayresult {
	private int sum;
	private int avg;
	
	public Arrayresult(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
			System.out.println(arr[i]);
		}
		avg = sum / arr.length;
//		System.out.println("배열의 합 : " + sum);
//		System.out.println("배열의 평균 : " + avg);
	}

	public int getSum() {
		return sum;
	}

	public int getAvg() {
		return avg;
	}
	
}
