using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1/2);
            Console.WriteLine(1/2.0); //0.5
            Console.WriteLine(1.0/2); //0.5

            //덧셈 뺄셈 곱셈 나눗셈 나머지
            Console.WriteLine(5+3);
            Console.WriteLine(5-3);
            Console.WriteLine(5*3);
            Console.WriteLine(5/3);
            Console.WriteLine(5%3);

            //연산의 우선 순위를 신경쓰고 싶지 않다면
            //괄호를 넣어줄 것
            Console.WriteLine((5+3)*(5-2));
            //여기서는 원래 곱셈이 먼저이나
            //덧셈과 뺄셈을 괄호로 묶었다.
            //그래서 덧셈과 뺄셈을 각각 먼저하고 곱셈함

            //문자 선택자
            Console.WriteLine("안녕하세요"[0]); //안
            Console.WriteLine("안녕하세요"[4]); //요
            //Console.WriteLine("안녕하세요"[5]); //Error!

            Console.WriteLine((int)"안녕하세요"[0]); //안
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0],16)); //안


            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result = true;
            bool result2 = false;


            Console.WriteLine(!result); //논리 부정 연산자
            Console.WriteLine(!result2); //논리 부정 연산자

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(1+1); //여기서 1은 int로 간주할까? 아님 long?
            //-> 기본적으로 숫자는 int로 인식함

            int a = int.MaxValue; //2147483647
            int b = int.MaxValue; //2147483647
            Console.WriteLine(a+b); //overflow
            Console.WriteLine((long)a+b); //정상적인 값이 나올겁니다.

            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;

            Console.WriteLine(example++); // 100
            Console.WriteLine(++example); // 102

            int exex = 100;
            Console.WriteLine(exex);   //--------
            exex = exex + 1; // --------------

            exex = exex + 1; // --------
            Console.WriteLine(exex); //-------

            int conclusion = 100;
            //++을 무조건 뒤에 붙이고 그냥 두 줄로 나눠서 쓰기
            conclusion++; //1 증가 시킨 뒤
            Console.WriteLine(conclusion); //그 값을 출력   
            conclusion++;
            Console.WriteLine(conclusion);

            Console.WriteLine();

            string input = Console.ReadLine();
            Console.WriteLine("안녕 나는 "+ input+"이야");

            //숫자 입력 받기
            int number = int.Parse(Console.ReadLine());//정수
            double num = double.Parse(Console.ReadLine());//실수
            Console.WriteLine(number/num);
        }
    }
}
