
public class StudentMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Student[] info = new Student[2];
		info[0] = new Student("장강식" , "1999038033", "남");
		info[1] = new Student("이재용" , "2007012034", "여");
		for (int i = 0; i < info.length; i++) {
			info[i].showStudentInfo();
		}
		
		System.out.println("-------장강식 학번 변경-------");
		for (int i = 0; i < info.length; i++) {
			if (info[i].name.equals("장강식")) {
				info[i].number = "2017038033";
			}
		}
		for (int i = 0; i < info.length; i++) {
			info[i].showStudentInfo();
		}
	}
}
