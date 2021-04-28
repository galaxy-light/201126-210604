using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Practice
{
    class Dur
    {
        private string durName;
        private string durComp;
        private string durId;
        
        public string DurName { get => durName; set => durName = value; }
        public string DurId { get => durId; set => durId = value; }
        public string DurComp { get => durComp; set => durComp = value; }

        public Dur(string durName, string durId, string durComp)
        {
            this.durName = durName;
            this.durId = durId;
            this.durComp = durComp;
        }
    }
}
