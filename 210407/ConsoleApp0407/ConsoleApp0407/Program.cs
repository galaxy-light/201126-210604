using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0407
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("안녕");
            }

            Console.WriteLine("안녕"+1);
            Console.WriteLine("안녕"+2);
            Console.WriteLine("안녕"+3);
            Console.WriteLine("안녕"+4);
            // 반복문은 실수없이 숫자를 증가시킴
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("안녕" + (i+1));
            }

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            // 반복문은 실수없이 숫자를 증가시킴
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("안녕하세요"[i]);
            }

            string name = "홍길동"; // string은 일종의 문자(char) 배열
            string[] names = { "홍길동", "전우치", "아무개" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] any = new string[10]; // 10개의 빈 배열 생성
            
            for (int i = (int)'A'; i < (int)'z'; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine("..");
            for (int i = (int)'가'; i < (int)'힣'; i++)
            {
                Console.Write((char)i);
                if (i == (int)'강')
                {
                    break;
                }
                if (i == (int)'힣')
                {
                    i = (int)'가';
                }
            }

            // 무한대로 도는 반복문을 쓰기에 적합한 while
            /*while (true)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }*/

            // while / do while 차이는 false
            while (false) // false면 한번도 실행 안함
            {
                Console.WriteLine("안녕안녕(while)");
            }
            do
            {
                Console.WriteLine("안녕안녕(do while)");
            } while (false); // false일지라도 한번은 실행함

            int count = 100;
            while (count < 100)
            {
                Console.WriteLine("카운트 값은 " + count + "입니다."); // 출력안됨
            }
            do
            {
                Console.WriteLine("do while count" + count); // 한번 출력됨
            } while (count < 100);

            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i; // 1 ~ 100까지의 합
            }
            Console.WriteLine(sum); // 출력

            sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%2==0)
                {
                    sum += i; // 짝수의 합
                }
            }
            Console.WriteLine(sum); // 출력

            sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue; // continue; : 홀수인 경우 실행문(sum += i;)을 실행하지 않음
                    sum += i;
                }
            }
            Console.WriteLine(sum); // 출력

            // foreach : 조건 다 필요없이 배열이나 문자열에 있는 것을 하나하나 순차적으로 출력, 실행하고 싶을 때
            foreach (var item in names) // item : 배열에 있는 하나하나의 요소를 나타냄
            {
                Console.WriteLine(item+"is Good man");
            }
            foreach (var abc in names) // item 대신 다른 변수를 써도 됨
            {
                Console.WriteLine(abc + "is Good man");
            }

            // foreach에 조건을 넣고 싶을 때
            int countIndex = 0;
            foreach (var item in names)
            {
                if (countIndex == 0) // 0번째 자리는 출력되지 않음
                {
                    countIndex++;
                    continue;
                }
                Console.WriteLine(item + "is Good man");
            }

            // foreach문을 for문으로
            for (int i = 0; i < names.Length; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(names[i] + "is Good person");
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                    Console.WriteLine(names[i] + "is Good person");
                }
            }

            // 별 찍기1
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 별 찍기2
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 별 찍기3
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
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

            // 별 찍기3 풀이
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) // 2*i+1 : 1,3,5,...
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 별 찍기4
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
            for (int i = 0; i <= 10; i++)
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
            
            // 별 찍기4 풀이
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    //Console.Write("-");
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // goto문
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto Example; // 중첩 반복문 탈출
                }
            }
        Example: Console.WriteLine("go to");

            string teacher = Console.ReadLine();
            if (teacher == "홍길동")
            {
                goto Example;
            }

            // ToUpper, ToLower
            string exam = "exAmPle";
            Console.WriteLine(exam.ToUpper()); // 전부 대문자로
            Console.WriteLine(exam.ToLower()); // 전부 소문자로
            Console.WriteLine(exam);
            exam = exam.ToUpper(); // 이렇게 적어야 원본이 바뀜

            // Split : 제거
            string person = "홍길동,전우치,아무개";
            string[] person_array = person.Split(','); // Split : , 제거
            foreach (var item in person_array)
            {
                Console.WriteLine(item+"님 하이");
            }

            // Join : Split의 반대(하나의 string 변수로 뭉침)
            string person2 = string.Join(",", person_array);
            //string person2 = string.Join(", ", person_array); // 띄어쓰기도 가능
            Console.WriteLine(person2);

            // Trim : 문자열 양 옆의 공백 제거
            string trim = " 안 녕 하 세 요 반갑습니다 ";
            Console.WriteLine("!"+trim+"!");
            Console.WriteLine("!" + trim.Trim() + "!");
        }
    }
}
