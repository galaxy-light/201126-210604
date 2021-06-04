using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write"+Environment.NewLine);
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.Write("Write");
            Console.WriteLine("Write");
            Console.WriteLine("\"Write\""); //escape문자
            Console.WriteLine("\"\\\"Write\\\"\"");
            
            //그렇다면 "\"Write\"" 이거를 그대로 화면에 
            //역 슬래시 대신 달러표시(W표시)로 보여도 됨
            //보이게 하고 싶다면?
        }
    }
}
