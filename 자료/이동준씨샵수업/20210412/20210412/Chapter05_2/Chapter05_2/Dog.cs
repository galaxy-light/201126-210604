using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_2
{
    class Dog
    {
        public string name = "이동준";
        public int age = 33;
        public static int theNumberofDog = 0;
        //생성자
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            theNumberofDog++;
        }
    }
}
