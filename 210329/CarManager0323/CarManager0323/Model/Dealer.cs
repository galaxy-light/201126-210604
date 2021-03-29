using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Dealer
    {
        string de_dat;
        Customer Customer;
        Car car;
        Seller seller;

        public Dealer(string de_dat, Customer customer, Car car, Seller seller)
        {
            this.de_dat = de_dat;
            Customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string De_dat { get => de_dat; set => de_dat = value; }
        internal Customer Customer1 { get => Customer; set => Customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
