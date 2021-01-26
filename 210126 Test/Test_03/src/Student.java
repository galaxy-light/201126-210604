
public class Student {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String name[] = {"이동준", "이제영"};
		int number[] = {2009038033, 2007012034};
		char gender[] = {'남', '여'};
		
		StudentInfo info[] = new StudentInfo[2];
		for (int i = 0; i < info.length; i++) {
			info[i] = new StudentInfo(name[i], number[i], gender[i]);
			info[i].showStudentInfo();
		}
		// 3-4
//		System.out.println("이동준 학번 변경");
//		info[0] = new StudentInfo("이동준", 2019038033, '남');
//		info[0].showStudentInfo();
		
		System.out.println("이동준 학번 변경");
		info[0].setName("이동준");
		info[0].setNumber(2019038033);
		info[0].setGender('남');
		info[0].showStudentInfo();
	}

}

class StudentInfo {
	private static String name;
	private static int number;
	private static char gender;	
		
	public StudentInfo(String name, int number, char gender) {
		super();
		this.name = name;
		this.number = number;
		this.gender = gender;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getNumber() {
		return number;
	}

	public void setNumber(int number) {
		this.number = number;
	}

	public char getGender() {
		return gender;
	}

	public void setGender(char gender) {
		this.gender = gender;
	}
	
	public void showStudentInfo () {
		System.out.print("이름 : " + name +", ");
		System.out.print("학번 : " + number + ", ");
		System.out.print("성별 : " + gender);
		System.out.println();
	}
	
}