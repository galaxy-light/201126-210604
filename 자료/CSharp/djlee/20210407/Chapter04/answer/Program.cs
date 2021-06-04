using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 문제");
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i+1)+"번째 수는? ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i]) //더 작은 수를 만나면
                    min = numbers[i]; //교체

                if (max < numbers[i]) //더 큰 수를 만나면
                    max = numbers[i]; //교체
            }
            Console.WriteLine("최솟값 : " + min + ", 최댓값 : " + max);

            Console.WriteLine("2번 문제");

            string start = "1";

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"번째 수열 : " + start);
                char number = start[0];
                int count = 0;
                string end = "";

                for (int j = 0; j < start.Length; j++)
                {
                    if(number==start[j]) //가리키는 숫자가 변동이 없을 때
                    {
                        count++;
                    }
                    else
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                }
                end = end + number + count;
                start = end;
            }

            Console.WriteLine("3번 문제");
            int starFloor = int.Parse(Console.ReadLine());
            int Flag = 0;
            if (starFloor == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                for (int i = 0; i < starFloor * 2; i++)
                {
                    for (int j = 0; j < starFloor; j++)
                    {
                        if (Flag % 2 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        Flag++;
                    }
                    if(starFloor%2==0)
                        Flag++;
                    Console.WriteLine();
                }
            }

            Console.WriteLine("4번 문제");
            int totalSugar = int.Parse(Console.ReadLine());
            int sugarPackage = 0;
            while(true)
            {
                if(totalSugar % 5 == 0)
                {
                    sugarPackage += totalSugar / 5;
                    break;
                }
                totalSugar -= 3;
                sugarPackage++;
                if (totalSugar < 0)
                {
                    sugarPackage = -1;
                    break;
                }
            }
            if(totalSugar<0)
                Console.WriteLine(-1);
            else
               Console.WriteLine(sugarPackage);
            
        }
    }
}
