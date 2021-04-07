using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0407_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 별 찍기(다이아몬드)
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

            // 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.
            Console.Write("num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3 : ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("num4 : ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("num5 : ");
            int num5 = int.Parse(Console.ReadLine());
            int[] sel = { num1, num2, num3, num4, num5 };
            int max = sel[0];
            int min = sel[0];
            for (int i = 0; i < sel.Length; i++)
            {
                //Console.WriteLine(sel[i]);
                if (max < sel[i])
                {
                    max = sel[i];
                }
            }
            for (int i = 0; i < sel.Length; i++)
            {
                //Console.WriteLine(sel[i]);
                if (min > sel[i])
                {
                    min = sel[i];
                }
            }
            Console.WriteLine($"가장 큰 수 : {max}");
            Console.WriteLine($"가장 작은 수 : {min}");

            // 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
            // 구글링을 했지만 코드를 이해하지 못해 못했습니다.....
            int[] numarray1 = new int[20];
            int a = 0;
            int b = 0;
            int count = 1;
            for (int i = 0; i < numarray1.Length; i++)
            {
                for (int j = 0; j < numarray1.Length; j++)
                {

                }
                Console.WriteLine($"{i + 1}번째 수열 : 1은(는) {a}개");
            }

            // 별 찍기 // 문제를 이해 못했습니다.....
            Console.Write("숫자 입력 : ");
            int numst = int.Parse(Console.ReadLine());
            for (int i = 0; i < numst; i++)
            {
                for (int j = 0; j > i; j--)
                {
                    Console.WriteLine(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine("*");
                }
            }            
        }
    }
}
