using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Car
    {
        string ca_mod;
        int ca_pri;
        string ca_col;
        string ca_com;
        string ca_year;

        public Car(string ca_mod, int ca_pri, string ca_col, string ca_com, string ca_year)
        {
            this.ca_mod = ca_mod;
            this.ca_pri = ca_pri;
            this.ca_col = ca_col;
            this.ca_com = ca_com;
            this.ca_year = ca_year;
        }

        public string Ca_mod { get => ca_mod; set => ca_mod = value; }
        public int Ca_pri { get => ca_pri; set => ca_pri = value; }
        public string Ca_col { get => ca_col; set => ca_col = value; }
        public string Ca_com { get => ca_com; set => ca_com = value; }
        public string Ca_year { get => ca_year; set => ca_year = value; }
    }
}
