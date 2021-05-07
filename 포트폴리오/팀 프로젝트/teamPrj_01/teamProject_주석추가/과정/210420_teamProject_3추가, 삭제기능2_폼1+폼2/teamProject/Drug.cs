using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject
{
    class Drug
    {

        private string medName;
        private string medCom;
        private string medCode;
        private string medContain;
        private string medListCode;        
        private int countMed;

        public Drug(string medName, string medCom, string medCode, string medContain, string medListCode, int countMed)
        {
            this.medName = medName;
            this.medCom = medCom;
            this.medCode = medCode;
            this.medContain = medContain;
            this.medListCode = medListCode;
            this.countMed = countMed;
        }

        public string MedName { get => medName; set => medName = value; }
        public string MedCom { get => medCom; set => medCom = value; }
        public string MedCode { get => medCode; set => medCode = value; }
        public string MedContain { get => medContain; set => medContain = value; }
        public string MedListCode { get => medListCode; set => medListCode = value; }
        public int CountMed { get => countMed; set => countMed = value; }
    }
}
