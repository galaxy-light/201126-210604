using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRe0406
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
            //서기 0년도는 원숭이띠
            Console.Write("연도 입력 : ");
            int y = int.Parse(Console.ReadLine());
            switch (y%12)
            {
                case 0:
                    Console.WriteLine("원숭이띠");
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
            }

            //사용자에게 현재 월을 입력 받아 계절을 출력하는 프로그램을 작성하시오.
            //단 12,1,2 겨울 / 3,4,5 봄 / 6,7,8 여름 / 9,10,11 가을이며, 그 외의 값에 대한 예외처리 포함
            Console.Write("월 입력 : ");
            int mo = int.Parse(Console.ReadLine());
            switch (mo)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("잘못된 입력값!");
                    break;
            }

            // 45분 전 알람
            Console.Write("시간 입력 : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("분 입력 : ");
            int m = int.Parse(Console.ReadLine());
            if (m < 45)
            {
                h -= 1;
                m += 60;
                m -= 45;
                //Console.WriteLine(h);
                //Console.WriteLine(m);
                if (h < 0)
                {
                    h += 24;
                    //Console.WriteLine(h);
                }
            }
            else
            {
                m -= 45;
                //Console.WriteLine(h);
                //Console.WriteLine(m);
            }
            Console.WriteLine($"알람 설정 시간 : {h}시 {m}분");
        }
    }
}
