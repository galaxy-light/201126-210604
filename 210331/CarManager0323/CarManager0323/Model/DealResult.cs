using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0331.Model
{
    class DealResult
    {
        int count;
        string cusName;
        string carmodel;
        string price;
        string sellName;
        string date;

        // 매개 변수를 사용하는 생성자
        public DealResult(int count, string cusName, string carmodel, string price, string sellName, string date)
        {
            this.count = count;
            this.cusName = cusName;
            this.carmodel = carmodel;
            this.price = price;
            this.sellName = sellName;
            this.date = date;
        }

        public int Count { get => count; set => count = value; }
        public string CusName { get => cusName; set => cusName = value; }
        public string Carmodel { get => carmodel; set => carmodel = value; }
        public string Price { get => price; set => price = value; }
        public string SellName { get => sellName; set => sellName = value; }
        public string Date { get => date; set => date = value; }
    }
}
