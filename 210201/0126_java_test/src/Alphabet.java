import javax.swing.event.SwingPropertyChangeSupport;

public class Alphabet {
	public Alphabet(String moonja[]) {
		for (int i = 0; i < moonja.length; i++) {
			switch (moonja[i]) {
			case "a": 
				System.out.printf("ㄱ");
				break;
			case "b": 
				System.out.printf("ㄴ");
				break;
			case "c": 
				System.out.printf("ㄷ");
				break;
			case "d": 
				System.out.printf("ㄹ");
				break;
			case "e": 
				System.out.printf("ㅁ");
				break;
			case "f": 
				System.out.printf("ㅂ");
				break;
			case "g": 
				System.out.printf("ㅅ");
				break;
			case "h": 
				System.out.printf("ㅇ");
				break;
			case "i": 
				System.out.printf("ㅈ");
				break;
			case "j": 
				System.out.printf("ㅊ");
				break;
			case "k": 
				System.out.printf("ㅋ");
				break;
			case "l": 
				System.out.printf("ㅌ");
				break;
			case "m": 
				System.out.printf("ㅍ");
				break;
			case "n": 
				System.out.printf("ㅎ");
				break;
			case "o": 
				System.out.printf("ㅏ");
				break;
			case "p": 
				System.out.printf("ㅑ");
				break;
			case "q": 
				System.out.printf("ㅓ");
				break;
			case "r": 
				System.out.printf("ㅕ");
				break;
			case "s": 
				System.out.printf("ㅗ");
				break;
			case "t": 
				System.out.printf("ㅛ");
				break;
			case "u": 
				System.out.printf("ㅜ");
				break;
			case "v": 
				System.out.printf("ㅠ");
				break;
			case "w": 
				System.out.printf("ㅡ");
				break;
			case "x": 
				System.out.printf("ㅣ");
				break;
			default:
				throw new IllegalArgumentException("없는 문자입니다.");
			}
		}
		System.out.println();
	}
	
}
