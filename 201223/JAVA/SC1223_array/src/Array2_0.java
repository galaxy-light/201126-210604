
public class Array2_0 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int score[] = {10, 20, 30, 40, 50};
		System.out.println("배열 시작 위치 : " + score); // 출력값으로 [I@76ccd017 뜨는데 이게 주소값
		// length : 배열의 크기
		System.out.println("배열 크기 : " + score.length);
				
		for(int i=0; i<score.length; i++) {
			System.out.println(score[i]);
		}
	}
}
