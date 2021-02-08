using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCar
{
    // https://blog.naver.com/hack4ork/221671058863
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(); // 객체 생성
            car1.showCarInfo(); // 출력

            Car car2 = new Car("현대", "화이트", "제네시스", "오천만원");
            car2.showCarInfo();

            // 입력 처리
            Console.Write("제조사 입력 : ");
            string brand = Console.ReadLine();
            Console.WriteLine("이름 : " + brand);

            Console.Write("색상 입력 : ");
            string color = Console.ReadLine();
            Console.WriteLine("색상 : " + color);

            Console.Write("이름 입력 : ");
            string model = Console.ReadLine();
            Console.WriteLine("이름 : " + model);

            Console.Write("가격 입력 : ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("가격 : " + price + "만원");
        }
    }
}
