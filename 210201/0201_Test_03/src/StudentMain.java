
public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub		
		// 3-2 문제		
		Student student1 = new Student("이동준", 2009038033, "남");
		Student student2 = new Student("이제영", 2007021034, "여");
		
		// 3-3 문제
		Student [] student3 = new Student[2];
		student3[0] = student1;
		student3[1] = student2;
		
		// 3-4 문제
		for (int i = 0; i < student3.length; i++) {
			if (student3[i].name.equals("이동준")) {
				student3[i].number = 2019038033;
			}
		}		
		
		// 3-5 문제
		for (int i = 0; i < student3.length; i++) {
			System.out.println("이름 : " + student3[i].name + " 학번 : " + student3[i].number
					+ " 성별 : " + student3[i].gender);
		}
	}
}
