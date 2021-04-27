namespace Guide_program.Model
{
    class Guidelist
    {
        private string tourid;
        private string tourtlid;
        private string tourtitle;
        private string touraddr1;
        private string tourlangcheck;
        private string tourlangcode;
       

        public Guidelist(string tourid, string tourtlid, string tourtitle, string touraddr1, string tourlangcheck, string tourlangcode)
        {
            this.tourid = tourid;
            this.tourtlid = tourtlid;
            this.tourtitle = tourtitle;
            this.touraddr1 = touraddr1;
            this.tourlangcheck = tourlangcheck;
            this.tourlangcode = tourlangcode;
        }

        public string Tourid { get => tourid; set => tourid = value; }
        public string Tourtlid { get => tourtlid; set => tourtlid = value; }
        public string Tourtitle { get => tourtitle; set => tourtitle = value; }
        public string Touraddr1 { get => touraddr1; set => touraddr1 = value; }
        public string Tourlangcheck { get => tourlangcheck; set => tourlangcheck = value; }
        public string Tourlangcode { get => tourlangcode; set => tourlangcode = value; }
    }
}
