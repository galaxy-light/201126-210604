package javabean0319;

public class TestBean {
	private String name;

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
		System.out.println("javabean:name =>" + name);
	}
}
