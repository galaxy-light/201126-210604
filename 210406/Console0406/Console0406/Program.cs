using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console0406
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            /*if (name == "홍길동")
            {
                Console.WriteLine("전우치");
            }*/
            /*if (true)
            {
                Console.WriteLine("전우치");
            }*/
            /*if (name == "홍길동")
            {
                Console.WriteLine($"{name} 의적");
            }*/
            /*if (name == "홍길동")
            {
                Console.WriteLine("전우치");
            }
            else
            {
                Console.WriteLine("의적");
            }*/

            int a = 100;
            // 한번 체크하는 if문
            if (a > 50)
            {
                Console.WriteLine("크다.");
                a = -100;
            }
            else
            {
                Console.WriteLine("작다.");
            }

            a = 100;
            // 두번 체크하는 if문이기 때문에 a = -100;이 되어 "작다"도 출력됨
            if (a>50)
            {
                Console.WriteLine("크다.");
                a = -100;
            }
            if (a<50)
            {
                Console.WriteLine("작다.");
            }

            //Console.Write("숫자 입력 : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int num = int.Parse(Console.ReadLine());
            /*if (num % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            else
            {
                Console.WriteLine("홀수입니다!");
            }*/

            // 실행문이 한 줄 밖에 없을 때 {} 생략 가능
            /*if (num % 2 == 0)            
                Console.WriteLine("짝수입니다!");            
            else            
                Console.WriteLine("홀수입니다!");*/

            // 조건문은 중첩 가능
            if (a > 0)
            {
                Console.WriteLine("a의 값은 양수");
                if (a > 50)
                {
                    Console.WriteLine("a의 값이 50 초과");
                }
                else
                {
                    Console.WriteLine("a의 값이 50 미만");
                }
            }
            else
            {
                Console.WriteLine("a의 값은 음수");
                if (a > -50)
                {
                    Console.WriteLine("a의 값이 -50보다 큽니다.");
                }
                else
                {
                    Console.WriteLine("a의 값이 -50보다 작습니다.");
                }
            }

            int b = 100;
            if (b < 50)
            {
                Console.WriteLine("b는 50보다 작습니다.");
            }
            else if (b < 70)
            {
                Console.WriteLine("b는 70보다 작습니다.");
            }
            else if (b < 90)
            {
                Console.WriteLine("b는 90보다 작습니다.");
            }
            else
            {
                //Console.WriteLine("b의 값은 "+b+"입니다.");
                Console.WriteLine($"b의 값은 {b}입니다.");
            }

            int dice = 3;
            /*switch (dice)
            {
                case 1:
                    Console.WriteLine("주사위 : 1");
                    break;
                case 2:
                    Console.WriteLine("주사위 : 2");
                    break;
                case 3:
                    Console.WriteLine("주사위 : 3");
                    break;
                case 4:
                    Console.WriteLine("주사위 : 4");
                    break;
                case 5:
                    Console.WriteLine("주사위 : 5");
                    break;
                case 6:
                    Console.WriteLine("주사위 : 6");
                    break;
            }*/
            /*switch (dice)
            {
                case 1:
                    Console.WriteLine("주사위 : 1");
                    break;
                case 2:
                    Console.WriteLine("주사위 : 2");
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("주사위 : 3, 4, 5, 6");
                    break;
                default:
                    Console.WriteLine("1,2,3,4,5,6 중 하나가 아님!");
                    break;
            }*/

            /*if (dice == 1)
            {
                Console.WriteLine("주사위 : 1");
            }
            else if (dice == 2)
            {
                Console.WriteLine("주사위 : 2");
            }
            else if (dice == 3)
            {
                Console.WriteLine("주사위 : 3");
            }
            else if (dice == 4)
            {
                Console.WriteLine("주사위 : 4");
            }
            else if (dice == 5)
            {
                Console.WriteLine("주사위 : 5");
            }
            else
            {
                Console.WriteLine("주사위 : 6");
            }*/

            if (dice == 1)
            {
                Console.WriteLine("주사위 : 1");
            }
            else if (dice == 2)
            {
                Console.WriteLine("주사위 : 2");
            }
            else if (dice == 3)
            {

            }
            else if (dice == 4 || dice == 5 || dice == 6)
            {
                Console.WriteLine("주사위 : 4,5,6");
            }
            else // switch의 default와 같은 동작
            {
                Console.WriteLine("1,2,3,4,5,6 중 하나가 아님!");
            }

            // 범위 지정하기
            int keyCm = 173;
            /*if (keyCm>=170 && keyCm<180) // 논리곱. 하나라도 false면 다 F
            {
                Console.WriteLine("애매한 키");
            }*/

            // 위와 동일한 if문
            if (keyCm >= 170)
            {
                if(keyCm < 180)
                Console.WriteLine("애매한 키");
            }

            if (keyCm<170 || keyCm>200) // 논리합. 하나라도 true면 다 T
            {
                Console.WriteLine("너무 작거나 크다.");
            }

            if (keyCm>=100 ^ keyCm>=200) // XOR
            {
                Console.WriteLine("");
            }

            // 삼항연산자
            int c = a % 2 == 0 ? -1 : 0; // 값이 짝수면 -1을 대입하고 값이 홀수면 0을 대입
            // 윗줄의 삼항연산자와 같은 if문
            if (a % 2 == 0)
            {
                c = -1;
            }
            else
            {
                c = 0;
            }

            // string에 특정한 문장 혹은 글자가 있을 때
            string nm = "홍길동";
            if (nm.Contains("동")) // Contains : 동일한 문자열 체크
            {
                Console.WriteLine("동대문");
            }
            if (nm.Contains("홍길"))
            {
                Console.WriteLine("기리");
            }

            // 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
            // 서기 0년도는 원숭이띠
            Console.Write("연도 입력 : ");
            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0 :
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

            // 사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램을 작성하시오.
            // 단 12,1,2 겨울 / 3,4,5 봄 / 6,7,8 여름 / 9,10,11 가을이며, 그 외의 값에 대한 예외처리 포함
            Console.Write("월 입력 : ");
            int mon = int.Parse(Console.ReadLine());
            switch (mon)
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
                case 21:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine("잘못된 입력값!");
                    break;
            }
        }
    }
}
