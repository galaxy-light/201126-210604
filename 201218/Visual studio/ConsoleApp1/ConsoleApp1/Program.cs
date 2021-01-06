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
            // java : System.out.println("Hello World");
            // c# : Console.WriteLine("Hello World");
            Console.WriteLine("Hello World"); // cw치고 탭탭 : 자동완성

            int a = 100;
            if (a > 50)
            {
                Console.WriteLine("a는 50을 넘어요");
            }
            else
            {
                Console.WriteLine("a는 50을 넘지 않아요");
            }
            // java
            /*
             * Scanner s = new Scanner(System.in); 
             * String ss = s.nextLine();
             * int aa = s.nextInt();
             */
            
            // 실행하는건 ctrl + F5
            string ss = Console.ReadLine();
            string sa = Console.ReadLine();
            int aa = int.Parse(Console.ReadLine());

            switch (aa) { 
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            
            for (int i = 0; i < 10; i++)
            { 
            
            }

            int temp = 10;
            while (temp > 0)
            {
                temp--;
            }

            do
            {
                temp++;
            } while (temp < 0);


            int abc = 100;
            if (abc == 100)
            {

            }
            else if (abc == 50)
            { 

            }
        }   
      
    }
}
