using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Customer
    {
        string cu_nm;
        string cu_ph;
        string cu_addr;
        string cu_em;

        public Customer(string cu_nm, string cu_ph, string cu_addr, string cu_em)
        {
            this.cu_nm = cu_nm;
            this.cu_ph = cu_ph;
            this.cu_addr = cu_addr;
            this.cu_em = cu_em;
        }

        public string Cu_nm { get => cu_nm; set => cu_nm = value; }
        public string Cu_ph { get => cu_ph; set => cu_ph = value; }
        public string Cu_addr { get => cu_addr; set => cu_addr = value; }
        public string Cu_em { get => cu_em; set => cu_em = value; }
    }
}
