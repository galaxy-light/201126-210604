
public class ManageStudent {

	public static void main(String[] args) {
		//���� 3-2
		Student s1 = new Student("�尭��", 1999038033, "��");
		Student s2 = new Student("�����", 2007012034, "��");
		
		//���� 3-3
		Student[] sArray = new Student[2];
		sArray[0] = s1;
		sArray[1] = s2;
		
		int a = 100;
		int b = a;
		b= 1000;
		System.out.println(a); // 100
		System.out.println(b); // 1000
		
		Student temp = new Student("�����",2020038033,"��");
		Student temp2 = new Student(temp.name, temp.number, temp.gender);
		temp2.name = "�̵���";
		
		System.out.println(temp.name); //�����
		System.out.println(temp2.name); //
		
		//���� 3-4
		for (int i = 0; i < sArray.length; i++) {
			Student student = sArray[i];
			if(student.name.equals("�尭��"))
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
