using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        // 인스턴스 변수
        private string brand;
        private string color;
        private string name;
        private string price;

        // 클래스 상수 변수
        public const string place = "동대구 영업소";

        // 기본 생성자
        public Car()
        {
            brand = "기아";
            color = "블랙";
            name = "K7";
            price = "사천만원";
        }

        // 사용자가 정의한 기본 생성자
        public Car(string brand, string color, string name, string price)
        {
            this.brand = brand; // this : 다른 변수와의 충돌 방지를 위해 사용, 객체의 시작 주소값(배열의 이름과 같은 말)
            this.color = color;
            this.name = name;
            this.price = price;
        }  

        public string Brand
        {
            get { return brand; }
            set { brand = value; } // brand = value; : .net framework
        }

        // 람다식 -> 인스턴스 변수 블럭 -> 노란 전구 -> 필드 캡슐화(그러나 여전히 필드를 사용함)
        public string Color { get => color; set => color = value; } // get, set : 메서드 , color : 변수
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }

        public void showCarInfo()
        {
            Console.WriteLine("제조사 - " + brand);
            Console.WriteLine("색상 - " + color);
            Console.WriteLine("이름 - " + name);
            Console.WriteLine("가격 - " + price);
            Console.WriteLine("대리점명 - " + Car.place);
        }
    }
}
