using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0208
{
    class Car1
    {
        private string brand;
        private string color;
        private string name;
        private string price;

        public const string place = "동대구 영업소";

        public void Car(string brand, string color, string name, string price)
        {
            this.brand = brand;
            this.color = color;
            this.name = name;
            this.price = price;
        }

        public Car1()
        {
            brand = "기아";
            color = "블랙";
            name = "K7";
            price = "사천만원";
        }

                
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public void showCarInfo()
        {
            Console.WriteLine("제조사 - " + brand);
            Console.WriteLine("색상 - " + color);
            Console.WriteLine("이름 - " + name);
            Console.WriteLine("가격 - " + price);
            Console.WriteLine("대리점명 - " + Car1.place);
        }
    }
}
