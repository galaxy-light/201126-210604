using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0208
{
    // https://blog.naver.com/hack4ork/221671058863
    class Program
    {
        static void Main(string[] args)
        {
            Car1 car1 = new Car1();
            car1.showCarInfo();

            Console.WriteLine();
            Car2 car2 = new Car2();
            car2.setBrand("현대");
            car2.setColor("화이트");
            car2.setName("제네시스");
            car2.setPrice("오천만원");           
            car2.showCarInfo2();
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
