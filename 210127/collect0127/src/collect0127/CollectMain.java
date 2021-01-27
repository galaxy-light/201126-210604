// 자료 구조
package collect0127;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CollectMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("##### 배열 #####");
		// 배열 : 크기가 한정됨
		// strArr : 배열의 이름 : 주소값
		String strArr[] = new String[3]; // class 배열(비어있음) 생성
		// 배열은 특정 인덱스를 알고 있어야 함
		strArr[0] = "홍길동";
		strArr[1] = "김길동";
		strArr[2] = "박길동";
		
		for (String str : strArr) { // 향상된 for문
			System.out.println(str);
		}
		
		for (int i = 0; i < strArr.length; i++) { // for문
			System.out.println(strArr[i]);
		}
		
		System.out.println("##### ArrayList #####");
		// 제네릭 클래스 : 크기가 무한대
		// <> : 제네릭 클래스 : 모든 타입 사용 가능
		ArrayList<String> list = new ArrayList<>(); // 객체 생성
		// 특정 인덱스를 몰라도 사용 가능
		list.add("홍길동");
		list.add("김길동");
		list.add("박길동");
		
		for (int i = 0; i < list.size(); i++) {
			System.out.println(list.get(i)); // 출력
		}
		
		System.out.println("##### stack #####");
		// <> : 제네릭 클래스
		/* stack : 쌓고 쌓인 순서대로 빼고 ex)ctrl+z
		 * LIFO (Last In First Out)
		 * push : 데이터 추가
		 * pop : 데이터 가져오기
		 */
		Stack<String> st = new Stack<>();
		st.push("홍길동"); // 맨 아래 쌓임
		st.push("김길동"); // 홍길동 위에 쌓임
		st.push("박길동"); // 김길동 위에 쌓임
		
		// isEmpty() : 객체가 비어있는지 확인할 때 사용
		while (!st.isEmpty()) { // !st.isEmpty() : 비어있지 않을 때까지
			System.out.println(st.pop()); // 출력
		}
		
		System.out.println("##### Queue #####");
		// <> : 제네릭 클래스
		/* Queue : 먼저 쌓인 게 먼저 나감 ex)키보드
		 * FIFO (Fist In First Out) 
		 * poll : 데이터 가져오기
		 */
		Queue<String> qu = new LinkedList<>();
		qu.add("홍길동");
		qu.add("김길동");
		qu.add("박길동");
		
		while (qu.isEmpty() == false) { // qu.isEmpty() == false : 비어있지 않을 때까지
			System.out.println(qu.poll());			
		}
		
		System.out.println("##### HashMap #####");
		// 키-값으로 관리되는 자료구조
		// <> : 제네릭 클래스
		// <키, 값>
		HashMap<Integer,String> map = new HashMap<>();
		map.put(1, "홍길동");
	    map.put(2, "김길동");
	    map.put(3, "박길동");
		
		// 해시테이블 위치 정보
	    Iterator<Integer> keySetIt = map.keySet().iterator();
	    while(keySetIt.hasNext()) { // keySetIt.hasNext() : 데이터가 있으면 넘어가고, 향상된 for문과 비슷
	    	Integer key = keySetIt.next();
	         System.out.printf("key=%d, 값=%s\n", key, map.get(key));
		}	
	}
}
