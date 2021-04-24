using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program
{    
    class VipCust
    {
        public string custnm { get; set; }
        public string custcarnum { get; set; }
        public string custph { get; set; }
        public string custstart { get; set; }
        public string custend { get; set; }               

        public VipCust(string custnm, string custcarnum, string custph, string custstart, string custend)
        {
            this.custnm = custnm;
            this.custcarnum = custcarnum;
            this.custph = custph;
            this.custstart = custstart;
            this.custend = custend;
        }        

        public VipCust()
        {

        }
    }
}
