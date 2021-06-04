using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facto
{
    class Program
    {
        static void Main(string[] args)
        {
            //이거 java에서 되려나... 해보셈
            //c에선 안 됨 무조건 배열 길이를 숫자로 지정해줘야 함(변수 안 됨)
            //변수로 하려면 동적 할당 코드를 써줘야 함 alloc 혹은 malloc
            int ab = int.Parse(Console.ReadLine());
            int[] abc = new int[ab];
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(factorial(3));
        }
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * factorial(n - 1);
        }
    }
}
