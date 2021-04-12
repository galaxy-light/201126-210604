using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_2
{
    class Dog
    {
        public string name = "홍길동";
        public int age = 33;
        public static int theNumberofDog = 0; // static : 모든 클래스가 공통으로 갖는 값

        // 생성자 : 객체가 생성될 때 호출되는 인스턴스 초기화 메서드
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            theNumberofDog++; // 생성될 때마다 +1
        }
    }
}
