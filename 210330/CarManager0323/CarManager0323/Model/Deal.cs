using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Deal
    {
        string de_dat;
        Customer customer;
        Car car;
        Seller seller;

        public Deal(string de_dat, Customer customer, Car car, Seller seller)
        {
            this.de_dat = de_dat;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string De_dat { get => de_dat; set => de_dat = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
