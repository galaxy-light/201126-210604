using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managing_Car_Program.Model
{
    class Api_parking
    {
        private string name;        
        private string location;
        private string pcount;

        public Api_parking(string name, string location, string pcount)
        {
            this.name = name;            
            this.location = location;
            this.pcount = pcount;
        }

        public string Name { get => name; set => name = value; }        
        public string Location { get => location; set => location = value; }
        public string Pcount { get => pcount; set => pcount = value; }
    }
}
