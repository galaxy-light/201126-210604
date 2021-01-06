using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201228T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ab = new int[100]; // 0 ~ 99까지 자리 생성
            // ab[0] = 10; -> 동작함 (0의 자리에 10을 대입)
            // ab[100] = 1; -> 동작안함 (100의 자리가 없기 때문에 동작X)
            ab[0] = 10;
            ab[1] = -1;
            int ex = int.Parse(Console.ReadLine());
            int[] abcd = new int[ex];
            Array.Sort(ab); // 배열에 있는 수를 오름차순으로 정렬
            Array.Reverse(ab); // 배열에 있는 수를 내림차순으로 정렬


            Console.WriteLine("------------------------------------");
            Console.WriteLine("1번 문제");
            // n개의 정수를 입력받고, 그 중에서 최대값과 최소값을 출력하세요.

            Console.WriteLine("숫자 입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = 0;
            int max = 0;

            for (num1=0; num1<num2; num1++) {
                if (max<num2) {
                    max = num2;                    
                }
                Console.WriteLine("최대값 : {0}", max);
            }

            int min = 0;
            for (num1=0; num1<num2; num1++) {
                if (min<num2) {
                    min = num2;
                }
                Console.WriteLine("최소값 : {0}", min);
            }
            
            Console.WriteLine("------------------------------------");
            Console.WriteLine("2번 문제");

        }
    }
}
