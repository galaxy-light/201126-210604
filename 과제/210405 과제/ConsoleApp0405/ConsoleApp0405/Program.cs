using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0405
{
    class Program
    {
        static void Main(string[] args)
        {
            // inch 단위를 입력 받아 cm 단위를 구하는 코드를 작성하시오.
            Console.Write("inch 입력 : ");
            double inch = Convert.ToDouble(Console.ReadLine());
            double cmconv = 2.54;
            double result1 = inch * cmconv;
            Console.WriteLine("cm : " + result1);

            // 킬로그램(kg) 단위를 입력받아 파운드(pound)단위를 구하는 코드를 작성하시오.
            Console.Write("kg 입력 : ");
            double kg = Convert.ToDouble(Console.ReadLine());
            double pou = 2.20462262;
            double reslut2 = kg * pou;
            Console.WriteLine("pound : " + reslut2);

            // 원의 반지름을 입력 받아 원의 둘레와 넓이를 구하는 코드를 작성하시오.
            double pi = 3.14;
            Console.Write("원의 반지름 입력 : ");
            double rad = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("원의 둘레 : " + 2*pi*rad);
            //Console.WriteLine("원의 넓이 : " + pi*rad*rad);
            double result3 = 2 * pi * rad;
            double result4 = pi * rad * rad;
            Console.WriteLine("원의 둘레 : " + result3);
            Console.WriteLine("원의 넓이 : " + result4);

            // 곱셈
            Console.Write("fir 입력 : ");
            int fir = Convert.ToInt32(Console.ReadLine());
            Console.Write("sec 입력 : ");
            int sec = Convert.ToInt32(Console.ReadLine());
            int cal1 = sec % 10;
            //Console.WriteLine(cal1);
            int cal2 = (sec % 100) / 10;
            //Console.WriteLine(cal2);
            int cal3 = sec / 100;
            //Console.WriteLine(cal3);
            int result5 = cal1 * fir;
            Console.WriteLine(result5);
            int result6 = cal2 * fir;
            Console.WriteLine(result6);
            int result7 = cal3 * fir;
            Console.WriteLine(result7);
            int result8 = result5 + (result6*10) + (result7*100);
            Console.WriteLine("결과값 : " + result8);
        }
    }
}
