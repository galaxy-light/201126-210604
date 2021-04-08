using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0408
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 5대의 숫자 중에 최댓값, 최솟값 구하기 - 풀이
            Console.WriteLine("1번 문제");
            Console.WriteLine("숫자 입력 : ");
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); // 배열에 입력 값 넣기
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }                
            }
            Console.WriteLine($"최솟값 : {min} 최댓값 : {max}");

            // 2. 읽고 말하기 수열(개미수열) - 풀이
            Console.WriteLine("2번 문제");
            string start = "1"; // start : 시작점
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i+1)+"번째 수열 : " + start);
                char number = start[0]; // 읽을 숫자 : 젤 처음 읽을 숫자가 0번째기 때문에 0을 넣음
                int count = 0; // count : 시작 변수, 읽을 변수 지정 필요, 읽은 변수를 카운트할 변수 필요
                string end = ""; // end :  읽어들이는 숫자가 바뀔 때마다 읽고 말하는 누적 변수 필요
                // 입력한 수열을 읽음
                for (int j = 0; j < start.Length; j++)
                {
                    if (number == start[j]) // 읽을 숫자와 j번째 숫자의 변동이 없다면
                    {
                        count++;
                    }
                    else
                    {
                        // 1121 중 1에서 2로 넘어가는 시점 등
                        end = end + number + count; // 1121이면 1이 2개 2가 1개 1이 1개
                        number = start[j];
                        count = 1; // 리셋
                    }
                }
                end = end + number + count; // 그동안 누적된 end에 number와 count를 더해줌(한 줄을 다 읽었다는 뜻)
                start = end; // 시작점에 end(한 줄이 다 저장되어있는 end)를 넣음
            }

            // 3. 별 찍기 - 풀이
            Console.WriteLine("3번 문제");
            int inpuFloor = int.Parse(Console.ReadLine());
            int Flag = 0; // 처음 시작이 별과 공백 중 뭘로 할지 결정
            if (inpuFloor == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                for (int i = 0; i < inpuFloor*2; i++)
                {
                    for (int j = 0; j < inpuFloor; j++)
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
                    if (inpuFloor % 2 == 0) // 짝수를 입력했을 때 공백을 주기 위해 직전의 값을 유지하고 +1을 더 해줌
                    {
                        Flag++;
                    }
                    Console.WriteLine();
                }
            }

            // 4. 설탕 배달 문제 - 풀이
            Console.Write("설탕 kg 입력 : ");
            int totalSugar = int.Parse(Console.ReadLine());
            int podae = 0;
            while (true)
            {
                if (totalSugar % 5 == 0) // 5로 묶기
                {
                    podae += totalSugar / 5;
                    break;
                }
                totalSugar -= 3; // 5로 못 묶었을 때 3을 빼주고
                podae++; // 묶음이 되었을 때 포대의 수가 +1됨
                if (totalSugar<0) // 입력값이 7일 때는 어느 수로도 못 묶기 때문에 -1로 빼서 그냥 바로 출력
                {
                    podae = -1;
                    break;
                }
            }
            Console.WriteLine(podae);
        }
    }
}
