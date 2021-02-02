
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
		return "내 이름은 " 
		+ name +","+"내 학번은 " 
		+ number + ", "+ "나는 "+gender+"자야";
	}
}







