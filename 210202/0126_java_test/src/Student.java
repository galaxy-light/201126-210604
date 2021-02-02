
public class Student {

	private String name;
	private String hackbun;
	private String gender;
	
	public Student() {
		
	}
	public Student(String name, String hackbun, String gender) {
		super();
		this.name = name;
		this.hackbun = hackbun;
		this.gender = gender;
	}
	
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getHackbun() {
		return hackbun;
	}

	public void setHackbun(String hackbun) {
		this.hackbun = hackbun;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public void showStdInfo() {
		System.out.printf("이름: " + name + ", ");
		System.out.printf("학번 : " + hackbun + ", ");
		System.out.printf("성별 : " + gender + " ");
		System.out.println();
		
	}
	
	
}



