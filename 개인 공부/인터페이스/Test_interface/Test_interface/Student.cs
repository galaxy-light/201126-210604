using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface
{
    class Student : Human
    {
        public override void abc()
        {
           // throw new NotImplementedException();
        }

        public override void def()
        {
            Console.WriteLine("안녕");
           // throw new NotImplementedException();
        }
    }
}
