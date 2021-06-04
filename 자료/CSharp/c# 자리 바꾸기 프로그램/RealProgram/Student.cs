using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProgram
{
    class Student
    {
        public int number;
        public string name;
        public string gender;
        public bool mustFront;
        public bool mustBack; 
        public bool isFixed;
        public Student(int num, string n, string g, bool mf, bool mb, bool fx)
        {
            number = num;
            name = n;
            gender = g;
            mustFront = mf;
            mustBack = mb;
            isFixed = fx;
        }
    }
}
