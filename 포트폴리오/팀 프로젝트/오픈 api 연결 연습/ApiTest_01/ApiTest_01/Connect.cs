using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest_01
{
    class Connect
    {
        private string durName;
        private string durComp;
        private string durId;

        public string DurName { get => durName; set => durName = value; }
        public string DurId { get => durId; set => durId = value; }
        public string DurComp { get => durComp; set => durComp = value; }

        public Connect(string durName, string durId, string durComp)
        {
            this.durName = durName;
            this.durId = durId;
            this.durComp = durComp;
        }
    }
}
