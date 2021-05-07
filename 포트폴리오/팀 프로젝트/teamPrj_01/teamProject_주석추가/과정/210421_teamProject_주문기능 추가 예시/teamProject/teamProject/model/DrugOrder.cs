using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject.model
{
    class DrugOrder
    {
        private Drug drug;
        private Entp entp;
        private int count;

        public DrugOrder(Drug drug, Entp entp, int count)
        {
            this.drug = drug;
            this.entp = entp;
            this.count = count;
        }

        public int Count { get => count; set => count = value; }
        internal Drug Drug { get => drug; set => drug = value; }
        internal Entp Entp { get => entp; set => entp = value; }
    }
}
