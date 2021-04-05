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
            // 숫자의 기본값은 정수
            Console.WriteLine(1/2); // 둘 다 정수라서 소수점X

            // 실수로 표기했기 때문에 0.5로 출력
            Console.WriteLine(1 / 2.0); // 0.5
            Console.WriteLine(1.0 / 2); // 0.5

            // 덧셈 뺄셈 곱셈 나눗셈 나머지
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);

            // () : 우선순위
            Console.WriteLine(5+3*5-2); // 18
            Console.WriteLine((5+3)*(5-2)); // 24

            // 음수와 나머지 연산자
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);

            // [] : 문자 선택자
            Console.WriteLine("안녕하세요"[0]); // 안
            Console.WriteLine("안녕하세요"[4]); // 요
            //Console.WriteLine("안녕하세요"[5]); // error

            Console.WriteLine((int)"안녕하세요"[0]); // 안 -> 정수로 표현됨
            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0],16)); // 안 -> 16진수로 표현됨
            Console.WriteLine('가' + '나'); // '' : 문자이기 때문에 숫자로 표현됨

            // bool : true/false 두가지의 값만 존재
            //int a == 10; // == : 조건의 true이기 때문에 에러
            int ab = 10; // = : 값을 할당
            Console.WriteLine(1==1);
            Console.WriteLine(1!=1);
            bool result1 = true;
            bool result2 = false;

            // ! : 논리 부정 연산자
            Console.WriteLine(!result1);
            Console.WriteLine(!result2);

            Console.WriteLine(long.MaxValue); // long : 8바이트
            Console.WriteLine(int.MaxValue); // int : 4바이트

            Console.WriteLine(1+1); // 숫자의 기본값은 int

            int a = int.MaxValue; // 2147483647
            int b = int.MaxValue; // 2147483647
            Console.WriteLine(a+b); // overflow
            Console.WriteLine((long)a+b); // 정상적인 값 출력

            // uint : 양수만 사용
            uint c = uint.MaxValue;
            Console.WriteLine(c);

            int example = 100;
            Console.WriteLine(example++); // 100 : 증가 되기 전의 값을 화면에 출력해주고 내부적으로 변수에 +1을 해줌
            Console.WriteLine(++example); // 102 : 증가된 값을 가져오고 +1을 해줌
            
            // example++ / ++example 풀어서 쓰면
            int exex = 100;
            Console.WriteLine(exex);
            exex = exex + 1;
            exex = exex + 1;
            Console.WriteLine(exex);

            // 이해 안되면 ++을 무조건 뒤에 붙이고 그냥 두 줄로 나눠서 쓰기
            int conclusion = 100;
            conclusion++; // 1을 증가 시킨 뒤
            Console.WriteLine(conclusion); // 그 값을 출력
            conclusion++;
            Console.WriteLine(conclusion);

            // 문자 입력 받기
            //string input = Console.ReadLine();
            //Console.WriteLine("안녕. 나는 " + input + "이야.");

            // 정수 입력 받기
            //int number = int.Parse(Console.ReadLine());
            // 실수 입력 받기
            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine(number/num);

            // Inch 단위를 입력 받아 cm 단위를 구하는 코드를 작성하시오.
            Console.Write("Inch 입력 : ");
            int inch = Convert.ToInt32(Console.ReadLine());
            double cmconv = inch * 2.54;
            Console.WriteLine("cm : " + cmconv);

            // 킬로그램(kg) 단위를 입력받아 파운드(pound)단위를 구하는 코드를 작성하시오.
            Console.Write("kg 입력 : ");
            double kg = double.Parse(Console.ReadLine());
            double pou = kg * 2.20462262;
            Console.WriteLine("pound : " + pou);

            // 원의 반지름을 입력 받아 원의 둘레와 넓이를 구하는 코드를 작성하시오.
            double pi = 3.14;
            Console.Write("원의 반지름 입력 : ");
            double cir = double.Parse(Console.ReadLine());
            double resultcir1 = 2 * pi * cir;
            Console.WriteLine("둘레 : " + resultcir1);
            double resultcir2 = pi * cir * cir;
            Console.WriteLine("넓이 : " + resultcir2);

            // 세자리 수 * 세자리 수
            Console.Write("num1 입력 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2 입력 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultnum1 = num2 % 10;
            Console.WriteLine(resultnum1); // 마지막 자리 수
            int resultnum2 = (num2 % 100) / 10;
            Console.WriteLine(resultnum2);
            int resultnum3 = num2 / 100;
            Console.WriteLine(resultnum3);
            int renum1 = num1 * resultnum1;
            int renum2 = num1 * resultnum2;
            int renum3 = num1 * resultnum3;
            int renum4 = renum1 + (renum2*10) + (renum3*100);
            Console.WriteLine(renum1);
            Console.WriteLine(renum2);
            Console.WriteLine(renum3);
            Console.WriteLine("결과값 : " + renum4);
        }
    }
}
