
public class Student {
	// 3-1 문제
	// private 사용X
	String name;
	int number;
	String gender;
	
	
	public Student(String name, int number, String gender) {
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

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}	
	
	
	
	

	
	
}
