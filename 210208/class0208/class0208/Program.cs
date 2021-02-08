using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0208 // namespace : 공간, 영역 : 같은 네임스페이스에 있느냐 없느냐에 따라 동작이 달라짐 -> 자바의 패키지와 유사함
{
    class Program
    {
        static void Main(string[] args)
        {
            // 범용으로 사용하는 문법
            // Student : 사용자가 만든 타입 / st : 변수, 생성된 객체를 마킹 / new Student(); : 객체(정확히 말하면 인스턴스) 생성
            Student st = new Student(); // 객체(인스턴스) 생성, 생성자가 없음
            // 정의
            st.setName("홍길동"); // 홍길동 : 매개 변수
            st.setTel("010-1234-5678"); // 010-1234-5678 : 매개 변수
            // 출력
            st.printStudentInfo();
            Console.WriteLine("이름 : " + st.getName()); // 메서드 호출

            Console.WriteLine();
            // C# .NET Framework에 특화된 문법
            Student2 st2 = new Student2(); // 매개 변수가 존재하는 기본 생성자를 만들었을 때 오류 발생 -> 기본 생성자를 하나 더 만들어주면 오류 해결 됨
            st2.Name = "이길동"; // Name : 변수X, 특수한 메서드
            st2.Tel = "010-9876-5432"; // Tel : 변수X, 특수한 메서드
            st2.printStudentInfo();
            Console.WriteLine("이름 : " + st2.Name); // 특수한 메서드

            Console.WriteLine();
            Student2 st3 = new Student2("최길동", "010-2222-2222"); // 객체를 생성하면서 값을 정의
            st3.printStudentInfo();

            Console.WriteLine();
            new Student2("김길동", "010-3333-3333").printStudentInfo(); // 객체를 생성하지만 위치 정보(변수)가 없기 때문에 재사용, 접근 불가

            Console.WriteLine();
            string[] nameArr = { "홍길동", "김길동", "박길동" };
            string[] telArr = { "010-5555-5555", "010-6666-6666", "010-7777-7777"};
            Random r = new Random();
            Student2[] stArr = new Student2[10]; // 비어있는 10개의 배열 / Student2 : 타입
            for (int i = 0; i < stArr.Length; i++)
            {
                // r.Next(0, 3) -> 0, 3 : 랜덤 숫자 범위 : 0 ~ 2까지 숫자 발생 -> 배열 안의 정보 개수
                stArr[i] = new Student2(nameArr[r.Next(0, 3)], telArr[r.Next(0, 3)]);
                stArr[i].printStudentInfo();
            }

            // 클래스 변수 사용
            Console.WriteLine("과정명 : " + Student2.CLASS); // 객체를 생성하지 않아도 외부에서 사용 가능
        }
    }
    class Student
    {
        // 캡슐화 : 외부에 변수를 노출X
        // name, tel : 인스턴수 변수
        private string name;
        private string tel;

        // 기본 생성자가 없다면 프로그램에서 자체적으로 생성해줌

        // 캡슐화된 변수에 접근하기 위해 set, get 사용
        // C#은 getter, setter 자동완성 기능X
        // getName, setName, getTel, setTel : 인스턴스 메서드
        public void setName(string name)
        {
            this.name = name; // this : 객체 자신의 위치 정보(위치값)
        }

        public string getName()
        {
            return name;
        }

        public void setTel(string tel)
        {
            this.tel = tel;
        }

        public string getTel()
        {
            return tel;
        }

        public void printStudentInfo()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("전화 : " + tel);
        }
    }
}
