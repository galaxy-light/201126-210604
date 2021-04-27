using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide_program.Model
{
    class Guidelist
    {
        string tourid;
        string tourtlid;
        string tourtitle;
        string touraddr1;
        string touraddr2;
        string tourlangCheck;
        string tourlangCode;
        string tourimageUrl;

        public Guidelist(string tourid, string tourtlid, string tourtitle, string touraddr1, string touraddr2, string tourlangCheck, string tourlangCode, string tourimageUrl)
        {
            this.tourid = tourid;
            this.tourtlid = tourtlid;
            this.tourtitle = tourtitle;
            this.touraddr1 = touraddr1;
            this.touraddr2 = touraddr2;
            this.tourlangCheck = tourlangCheck;
            this.tourlangCode = tourlangCode;
            this.tourimageUrl = tourimageUrl;
        }

        public string Tourid { get => tourid; set => tourid = value; }
        public string Tourtlid { get => tourtlid; set => tourtlid = value; }
        public string Tourtitle { get => tourtitle; set => tourtitle = value; }
        public string Touraddr1 { get => touraddr1; set => touraddr1 = value; }
        public string Touraddr2 { get => touraddr2; set => touraddr2 = value; }
        public string TourlangCheck { get => tourlangCheck; set => tourlangCheck = value; }
        public string TourlangCode { get => tourlangCode; set => tourlangCode = value; }
        public string TourimageUrl { get => tourimageUrl; set => tourimageUrl = value; }
    }
}
