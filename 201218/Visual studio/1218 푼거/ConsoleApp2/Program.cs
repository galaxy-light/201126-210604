using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번--------------------------------");

            int i = 0;
            int hap = 0;
            for (i = 0; i < 101; i++) {
                hap += i;
            }
            Console.WriteLine("1부터 100까지의 합 : " + hap);

            i = 0;
            for (i = 0 + 1; i < 101; i++) {
                if (i % 3 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("2번--------------------------------");
           
            Console.Write("시간 입력 : ");
            int h = int.Parse(Console.ReadLine());
            int m = h / 60; // 몫 : 분
            int n = h % 60; // 나머지 : 초                          
            Console.WriteLine("출력 : " + m + "분" + n + "초");


            Console.WriteLine("3번--------------------------------");

            Console.WriteLine("숫자 입력 : ");
            int ss = int.Parse(Console.ReadLine());
            int abc = 0;
            for (ss = 0; ss < 10; ss++){              
                for (abc = 0; abc < ss; abc++){                   
                    Console.Write("*");                    
                }
                Console.Write("\n");
            }
            
            // 이중은 안배워서 검색했습니다........

            Console.WriteLine("4번--------------------------------");
                        
            Console.Write("숫자 입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            int num2 = 0;
            for (num2=1; num2<10; num2++) {
                int to = num1 * num2;               
                Console.WriteLine(num1 + "*" + num2 + "=" + to);
            }
            Console.WriteLine("\n");

            Console.WriteLine("5번--------------------------------");

            Console.Write("1~12월 중 하나 입력 : ");
            int b = int.Parse(Console.ReadLine());
            switch (b) {
                case 12: case 1: case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6: case 7: case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9: case 10: case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력값");
                    break;
            }
   
    
        }
    }
}
