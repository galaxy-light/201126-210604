using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Seller
    {
        string se_nm;
        string se_ph;
        string se_em;
        string se_ran;
        string se_pla;

        public Seller(string se_nm, string se_ph, string se_em, string se_ran, string se_pla)
        {
            this.se_nm = se_nm;
            this.se_ph = se_ph;
            this.se_em = se_em;
            this.se_ran = se_ran;
            this.se_pla = se_pla;
        }

        public string Se_nm { get => se_nm; set => se_nm = value; }
        public string Se_ph { get => se_ph; set => se_ph = value; }
        public string Se_em { get => se_em; set => se_em = value; }
        public string Se_ran { get => se_ran; set => se_ran = value; }
        public string Se_pla { get => se_pla; set => se_pla = value; }
    }
}
