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
            //1번 문제 12지신

            int birthYear = int.Parse(Console.ReadLine());
            switch (birthYear%12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;
                case 3:
                    Console.WriteLine("돼지띠");
                    break;
                case 4:
                    Console.WriteLine("쥐띠");
                    break;
                case 5:
                    Console.WriteLine("소띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이띠");
                    break;
                case 7:
                    Console.WriteLine("토끼띠");
                    break;
                case 8:
                    Console.WriteLine("용띠");
                    break;
                case 9:
                    Console.WriteLine("뱀띠");
                    break;
                case 10:
                    Console.WriteLine("말띠");
                    break;
                case 11:
                    Console.WriteLine("양띠");
                    break;
                default:
                    break;
            }

            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("winter is comming");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring is comming");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer is comming");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("autumn is comming");
                    break;
                default:
                    Console.WriteLine(month+"는 잘못된 값입니다");
                    break;
            }
        }
    }
}
