using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCar
{
    class Car
    {
        // 클래스 상수 변수
        const string place = "동대구 영업소";

        // 인스턴스 변수
        private string company;
        private string color;
        private string price;
        private string model;

        // 매개 변수가 존재 하지 않는 기본 생성자 -> 값이 고정되어 있음
        public Car()
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "사천만원";
        }

        // 오버로딩
        // 매개 변수가 존재하는 기본 생성자
        public Car(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        // 람다식 캡슐화 -> 자동완성 : 인스턴스 변수 블럭 - 노란 전구 - 캡슐화(그러나 여전히 필드를 사용함)
        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Price { get => price; set => price = value; }
        public string Model { get => model; set => model = value; }

        /* public string Company
         {
             get { return company; }
             set { company = value; }
         }        

         public string Color
         {
             get { return color; }
             set { color = value; }
         }

         public string Model
         {
             get { return model; }
             set { model = value; }
         }

         public string Price
         {
             get { return price; }
             set { price = value; }
         }*/

        public void showCarInfo()
        {
            Console.WriteLine("제조사 - " + company);
            Console.WriteLine("색상 - " + color);
            Console.WriteLine("모델 - " + model);
            Console.WriteLine("가격 - " + price);
            Console.WriteLine("대리점명 - " + Car.place);
            Console.WriteLine("------------------------");
        }
    }
}
