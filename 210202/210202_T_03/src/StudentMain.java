
public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Student info[] = new Student[2]; 
		info[0] = new Student("이동준", "2009038033", "남");
		info[1] = new Student("이제영", "2007012034", "여");
				
		for (int i = 0; i < info.length; i++) {
			info[i].showStudentInfo();
		}
		
		System.out.println("이동준 학번 변경");
		info[0].setNumber("2019038033");
		for (int i = 0; i < info.length; i++) {
			info[i].showStudentInfo();
		}
	}
}
