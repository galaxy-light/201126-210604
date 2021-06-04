using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");
            Console.WriteLine("안녕");

            for(int i = 0; i<4; i++)
                Console.WriteLine("안녕");

            Console.WriteLine("안녕"+1);
            Console.WriteLine("안녕"+2);
            Console.WriteLine("안녕"+3);
            Console.WriteLine("안녕"+4);
            //반복문은 실수없이 숫자를 증가시킨다.
            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕"+(i+1));

            Console.WriteLine("안녕하니"[0]);
            Console.WriteLine("안녕하니"[1]);
            Console.WriteLine("안녕하니"[2]);
            Console.WriteLine("안녕하니"[3]);
            //반복문은 실수없이 숫자를 증가시킨다.
            for (int i = 0; i < 4; i++)
                Console.WriteLine("안녕하니"[i]);

            string name = "김동혁";
            string[] names = { "김동혁", "정연우", "임수환" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] handsomeguy = new string[10];

            for(int i = (int)'A'; i<(int)'z'; i++)
                Console.Write((char)i);

            Console.WriteLine("..");

            for (int i = (int)'가'; i <= (int)'힣'; i++)
            {
                Console.Write((char)i);

                if (i == (int)'강')
                    break;
                if (i == (int)'힣')
                    i = (int)'가';
            }


            //무한대로 도는 반복문을 쓰기에 적합한 while
            while (false)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
            }

            //for
            //do while
            //while
            //c#에서는 foreach

            while (false)
            {
                Console.WriteLine("이동준천재");
            }
            do
            {
                Console.WriteLine("이동준천재(dowhile)");
            } while (false);

            int count = 100;
            while(count<100)
            {
                Console.WriteLine("카운트값은 "+count+"입니다.");
            }
            do
            {
                Console.WriteLine("do while count"+count);
            } while (count<100);

            Console.WriteLine("이상한 유머를 너무 많이 했다");
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                //if(i%2==0)
                //sum += i;

                //continue 이용
                if (i % 2 != 0)
                    continue;

                sum += i;
            }
            Console.WriteLine(sum);

            //foreach

            foreach (var abcd in names)
            {
                Console.WriteLine(abcd + " is Good man");
            }

            int countIndex = 0;
            foreach (var abcd in names)
            {
                if (countIndex == 0) //가장 첫번째 사람은 출력 안 하려고 할 때
                {
                    countIndex++;
                    continue;
                }

                Console.WriteLine(abcd + " is Good man");

            }

            //해킹당한 것처럼 보이게 하는 연출 -_-;
            Random[] rs = new Random[10];
            for (int i = 0; i < rs.Length; i++)
            {
                rs[i] = new Random(DateTime.Now.Millisecond);
                Thread.Sleep(100);
            }
            for (int i = 0; i < rs.Length; i++)
            {
                Console.WriteLine(rs[i].Next(int.MaxValue));
            }
            
            for (int i = 0; i < 1; i++)
            {
                Console.Write("" + rs[i % 10].Next(int.MaxValue)+"" +rs[i%10].Next(int.MaxValue)+""+ rs[i % 10].Next(int.MaxValue)+""+rs[i % 10].Next(int.MaxValue));
                Console.WriteLine("" + rs[i % 10].Next(int.MaxValue)+"" +rs[i%10].Next(int.MaxValue)+""+ rs[i % 10].Next(int.MaxValue)+""+rs[i % 10].Next(int.MaxValue));
                Thread.Sleep(20);
            }
            // 더 멋지게 바꾸실 수 있는 분들은 더 멋지게 바꿔주세요 ㅎㅎㅎ

            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                    continue;
                Console.WriteLine(names[i] + " is Good man");
            }


            // |> 이렇게 생긴 거
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // <|
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //피라미드
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //다이아몬드
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
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
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("피라미드");

            //<| 이렇게 생긴 삼각형 코드를 가져오세요.
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2*i+1; j++) //2i + 1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("다이아몬드");
            //피라미드 코드를 가져오세요.
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) //2i - 1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) //2i + 1
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //goto문~~!!!
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    goto Example;
                }
            }

            Example:
                Console.WriteLine("go to");

            string teacher = Console.ReadLine();

            if (teacher == "이동준")
                goto Example;

            //ToUpper, ToLower
            string example = "exAmPle";
            Console.WriteLine(example.ToUpper()); //전부 대문자로
            Console.WriteLine(example.ToLower()); //전부 소문자로
            Console.WriteLine(example);
            example = example.ToUpper(); //이렇게 해야 원본바뀜
            //Split
            string guys = "김동혁,장승민,정연우,임수환";
            string[] guys_array = guys.Split(',');
            foreach (var item in guys_array)
            {
                Console.WriteLine(item+"님 하이");
            }
            //Join - split의 반대(하나의 string변수로 뭉침)
            string guys2 = string.Join(",",guys_array);
            Console.WriteLine(guys2);
            //Trim - 문자열 양 옆의 공백 제거
            string trim = "  안 녕 하 니    워우워우예  ";
            Console.WriteLine("!"+trim+"!");
            Console.WriteLine("!" + trim.Trim() + "!");

        }
    }
}
