// https://blog.naver.com/hack4ork/221671058863 - 5번
package name;

public class NameMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		for (int i = 0; i < 50; i++) {
			new Randname();
		}
	}
}


class Randname {
	private String first[]; 
	private String mid[]; 
	private String last[];
	private String randname;

	public Randname() {
		fullname();
	}
	
	public Randname(String[] first, String[] mid, String[] last, String randname) {
		super();
		this.first = first;
		this.mid = mid;
		this.last = last;
		this.randname = randname;
	}

	public String fullname() {
		int arr [] = new int [50];
		String first[] = {"김", "박", "이", "최", "장"}; 
		String mid[] = {"가", "나", "다", "라", "마"}; 
		String last[] = {"바", "사", "아", "자", "차"};
		for (int i = 0; i < arr.length; i++) {
			String randname = first[(int)(Math.random()*5)]
					+mid[(int)(Math.random()*5)]
							+last[(int)(Math.random()*5)];
			System.out.println(randname);
		}
		return randname;
	}
}
