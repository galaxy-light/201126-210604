using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // https://blog.naver.com/hack4ork/221671058863
    class Program
    {
        static void Main(string[] args)
        {
            // Car : 사용자가 정의한 타입 / car1 : 생성된 객체를 마킹 / new Car(); : 객체 생성 / 생성된 객체의 공간은 가비지 컬렉터가 관리함
            Car car1 = new Car();           
            car1.showCarInfo();
            new Car().showCarInfo(); // 위의 두 줄과 동일한 문법이지만 위치(마킹하는 변수)가 없기 때문에 재사용 불가
            new Car().showCarInfo(); // new Car();로 생성한 객체는 전부 다 다른 객체임

            Console.WriteLine();
            Car c1 = new Car();
            c1.Brand = "현대";
            c1.Color = "그레이";
            c1.Name = "그랜져";
            c1.Price = "오천만원";
            c1.showCarInfo();

            Console.WriteLine();
            Car2 car2 = new Car2();
            car2.setBrand("현대");
            car2.setColor("화이트");
            car2.setName("제네시스");
            car2.setPrice("육천만원");
            car2.showCarInfo2();

            // 위의 Car2를 한 줄로
            // "현대", "블루", "코나", "삼천만원" -> 매개변수
            Car car3 = new Car("현대", "블루", "코나", "삼천만원"); // -> 인스턴수 변수에 정보를 주기 위해 정의
            car3.showCarInfo();

            // 입력 처리
            Console.WriteLine();
            Console.Write("제조사 입력 : ");
            string brand = Console.ReadLine();
            Console.WriteLine("제조사 : " + brand);
            Console.Write("색상 입력 : ");
            string color = Console.ReadLine();
            Console.WriteLine("색상 : " + color);
            Console.Write("이름 입력 :");
            string name = Console.ReadLine();
            Console.WriteLine("이름 : " + name);
            Console.Write("가격 입력 :");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("가격 : " + price);
            Console.Write("대리점명 입력 :");
            string place = Console.ReadLine();
            Console.WriteLine("대리점명 : " + place);
        }
    }
    class Car2
    {
        private string brand;
        private string color;
        private string name;
        private string price;

        public const string place = "서대구 영업소";

        /* public void Car(string barnd, string color, string name, string price)
        {
            this.brand = brand;
            this.color = color;
            this.name = name;
            this.price = price;
        }*/

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public string getBrand()
        {
            return brand;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getPrcie()
        {
            return price;
        }

        public void showCarInfo2()
        {
            Console.WriteLine("제조사 - " + brand);
            Console.WriteLine("색상 - " + color);
            Console.WriteLine("이름 -" + name);
            Console.WriteLine("가격 - " + price);
            Console.WriteLine("대리점명 - " + Car2.place);
        }
    }
}
