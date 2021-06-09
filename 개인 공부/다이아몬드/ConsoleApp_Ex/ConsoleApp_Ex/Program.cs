using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ex
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int j = 10; j > i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                for (int j = 10; j >= i; j--)
                {

                    Console.Write("*");
                }
                for (int j = 10; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
