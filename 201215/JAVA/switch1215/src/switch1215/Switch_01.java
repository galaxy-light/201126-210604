package switch1215;

public class Switch_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		char grade = 'A'; // 학점, grade라는 문자변수
		switch (grade) {
		case 'A' :
			System.out.println("A학점");
			break; // char grade = 'A';이니까 결과값 A로 도출하고 빠져나옴 / break 없다면 B학점도 도출
		case 'C' :
			System.out.println("B학점");
			break;
		case 'D' :
			System.out.println("C학점");
			break;
		default : // 위의 case에 동일한 값이 없다면 default 값이 도출 / default가 없다면 아무것도 실행이 안됨
			System.out.println("F학점");
			break;
		}

	}

}

