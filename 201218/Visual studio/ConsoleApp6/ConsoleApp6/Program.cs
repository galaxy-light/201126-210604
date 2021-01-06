using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 프로그램 시행법
            // java : ctrl + F11
            // c# : ctrl + F5

            // java : System.out.println("Hello"); // 줄 띄움
            // c# : Console.WriteLine("Hello"); // 줄 띄움
            // cw 입력 tab 키 두번
            Console.WriteLine("Hello");

            // java : System.out.print("Hello"); // 줄 변경X
            Console.Write("Hello World");

            // java : System.out.println(); // 아무것도 안하고 그냥 한 줄 띄우기
            // c# : Console.WriteLine();
            Console.WriteLine();

            // 변수
            // java와 동일
            int example = 100;
            // 단 String 변수는 String이랑 string 둘 다 동일하게 쓸 수 있음
            // c#에서는 보통 s를 소문자로 적는다.
            string ex1 = "하이";
            string ex2 = "헬로";
            string 이런것도됨 = "히히"; // 변수 한글
            Console.WriteLine(이런것도됨); // 변수 한글, 최신 버전에서만 구동하니 웬만하면 사용X

            // 문자열과 숫자 혼합하기
            // 셋 다 결과는 똑같음
            string ex3 = example + " 더하기 " + example + "은 " + (example + example) + "이다.";
            string ex4 = $"{example} 더하기 {example}은 {example+example}이다.";
            string ex5 = string.Format("{0} 더하기 {1}은 {2}이다.", example, example, example + example);

            Console.WriteLine(ex3);
            Console.WriteLine(ex4);
            Console.WriteLine(ex5);

            // 조건문
            // java와 동일함
            // if 입력하고 tab 키 두번
            if (example>50)
            {
                Console.WriteLine("example은 50이상");
            }
            if (example > 30)
            {
                Console.WriteLine("30이상");
            }
            else
            {
                Console.WriteLine("30미만");   
            }

            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if (example == 20)
            {
                Console.WriteLine("20");
            } // 끝에 꼭 else 안 붙여도 됨

            if (example == 10)
            {
                Console.WriteLine("10");
            }
            else if (example == 20)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine("10이랑 20은 아님");
            }

            // switch문도 java와 동일
            // switch 입력하고 tab 키 두번
            switch (example)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;          
                default :
                    Console.WriteLine("10이랑 20은 아님");
                    break;
            }

            // 반목문도 java와 도일
            // 단 foreach라는 특수 문법이 있는데 이건 나중에 배움
            // 근데 몰라도 코드 짜는데는 지장 없음
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("같은 말 10번 반복하기");
            }

            // while : 조건을 보고 거짓이면 실행하지 않음
            int temp = 10;
            while (temp > 0)
            {
                temp--;
            }

            // do while : 한 번은 무조건 실행함
            do
            {
                temp++;
            } while (temp<10);

            // 값을 입력받는 경우
            // java
            /*
             *  Scanner s = new Scanner(System.in);
             *  String test = s.nextInt();
             *  int test2 = s.nextInt();
            */

            // c#
            /*
             *  string test = Console.ReadLine();
             *  int test2 = int.Parse(Console.ReadLine());
             */
            // Console.ReadLine은 단축키 없음

            string test = Console.ReadLine();
            int test2 = int.Parse(Console.ReadLine());


        }   
    }
}
