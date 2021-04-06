using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0406_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
            // 서기 0년도는 원숭이띠
            int birthyear = int.Parse(Console.ReadLine());
            switch (birthyear%12)
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

            // 사용자에게 현재 월을 입력 받아 계절을 출력하는 프로그램을 작성하시오.
            // 단 12,1,2 겨울 / 3,4,5 봄 / 6,7,8 여름 / 9,10,11 가을이며, 그 외의 값에 대한 예외처리 포함
            int month = int.Parse(Console.ReadLine());
            switch (month)
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
                    Console.WriteLine(month+"는 잘못된 입력값!");
                    break;
            }

            // 맞춰놓은 시간의 45분 전에 미리 한 번 알람이 울리는 시계
            Console.Write("시간 입력 : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("분 입력 : ");
            int m = int.Parse(Console.ReadLine());
            /*if (m < 45)
            {
                h -= 1; // 분이 45보다 적으면 한 시간전으로 돌리기 위해   
                // m이 마이너스가 되지 않도록
                m += 60;
                m -= 45;
                //m += 15; // 위에 두 줄을 한 줄로
                if (h < 0)
                {
                    h += 24; // h 초기화                    
                }
            }           
            else
            {
                m -= 45; // 45 이상을 입력했을 때
            }            
            Console.WriteLine(h + "시" + m + "분 알람 설정 완료");*/

            Console.WriteLine($"사용자가 맞춘 시간 : {h}시 {m}분");
            m -= 45;
            if (m<0)
            {
                m += 60;
                h -= 1;
            }
            if (h<0)
            {
                h += 24;
            }
            /*Console.WriteLine($"알람 설정 완료\n"+
                $"시간 : {h}{Environment.NewLine}"+
                $"분 : {m}\n");*/
            Console.WriteLine($"알람 설정 완료\n" +
                $"{h}시 " + $"{m}분");
        }
    }
}
