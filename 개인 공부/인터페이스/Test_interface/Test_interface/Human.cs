using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface
{
    abstract class Human
    {
        public int age { get; set; }
        public string name { get; set; }
        public abstract void abc();
        public abstract void def();
    }
}
