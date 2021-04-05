using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0405
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write" + "\n");
            Console.Write("Write" + Environment.NewLine); // Environment.NewLine : 줄바꿈
            Console.WriteLine("WriteWriteWriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteWrite");
            Console.Write("Write");
            Console.WriteLine("Write");
            Console.WriteLine("\"Write\""); // escape문자
            Console.WriteLine("\"\\\"Write\\\"\"");
        }
    }
}
