using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp0414_2
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        // 생성자 : 상황에 따라 맞춰 사용하면 됨
        
        // 생성자
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 생성자 오버로딩
        public Person(string name)
        {
            this.name = name;
            this.age = age;
        }

        // 생성자 오버로딩 - 빈 생성자는 C#에서 내부적으로 만들어 주기 때문에(디폴트 생성자) 굳이 쓸 필요X
        public Person()
        {
            
        }

    }
}
