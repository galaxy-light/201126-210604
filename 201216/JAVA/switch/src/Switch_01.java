
public class Switch_01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// switch - 제어문 : 괄호 안의 값 또는 수식과 동일한 case 판별
		/* switch (값 또는 수식) { 
				case 값 :
				실행문1;
				break;
				case 값 :
				실행문2;
				break;
				...
				default :
				break;
			}		 
		 */
		char grade = 'A'; // 문자 변수
		switch(grade) {
		case 'A' :
			System.out.println("A학점");
			break;
		case 'B' :
			System.out.println("B학점");
			break;
		case 'C' :
			System.out.println("C학점");
			break;
		default :
			System.out.println("F학점");
			break;		
		}

	}

}
