
public class Student {
	String name;
	int number; //2009038033     09038033
	String gender;
	
	public Student(String n, int num, String g)
	{
		name = n;
		number = num;
		gender = g;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		//return super.toString();
		return "�� �̸��� " 
		+ name +","+"�� �й��� " 
		+ number + ", "+ "���� "+gender+"�ھ�";
	}
}







