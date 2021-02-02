
public class ManageStudent {

	public static void main(String[] args) {
		//문제 3-2
		Student s1 = new Student("장강식", 1999038033, "남");
		Student s2 = new Student("이재용", 2007012034, "여");
		
		//문제 3-3
		Student[] sArray = new Student[2];
		sArray[0] = s1;
		sArray[1] = s2;
		
		int a = 100;
		int b = a;
		b= 1000;
		System.out.println(a); // 100
		System.out.println(b); // 1000
		
		Student temp = new Student("김우진",2020038033,"여");
		Student temp2 = new Student(temp.name, temp.number, temp.gender);
		temp2.name = "이동준";
		
		System.out.println(temp.name); //김우진
		System.out.println(temp2.name); //
		
		//문제 3-4
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			if(student.name.equals("장강식"))
			{
				student.number = 2017038033;
			}
			
		}
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			System.out.println(student);
			
		}
		
	}

}
