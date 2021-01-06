
public class Array {
	private int arr[] = new int [10];	

	public int[] getArr() {
		return arr;
	}

	public void setArr(int[] arr) {
		this.arr = arr;
	}
	
	public void showArrInfo() {
		
		System.out.println("배열의 합 : " + arr);
		System.out.println("배열의 평균 : " + arr);
	}
	
}
