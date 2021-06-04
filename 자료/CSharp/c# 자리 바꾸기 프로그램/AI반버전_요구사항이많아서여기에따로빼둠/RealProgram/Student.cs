using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProgram
{
    class Student : IComparable
    {
        public int number;
        public string name;
        public string gender;
        public bool mustFront;
        public bool mustBack; 
        public bool isFixed;
        public Student(Student s)
        {
            number = s.number;
            name = s.name;
            gender = s.gender;
            mustFront = s.mustFront;
            mustBack = s.mustBack;
            isFixed = s.isFixed;
        }
        public Student(int num, string n, string g, bool mf, bool mb, bool fx)
        {
            number = num;
            name = n;
            gender = g;
            mustFront = mf;
            mustBack = mb;
            isFixed = fx;
        }

        public int CompareTo(object obj)
        {
            return number.CompareTo((obj as Student).number);
        }
    }
}
