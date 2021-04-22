using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program
{
    class VipData
    {
        readonly List<VipCust> vips = new List<VipCust>();

        static VipData inst;

        public static VipData getInst()
        {
            if (inst == null)
            {
                inst = new VipData();
            }
            return inst;
        }

        public List<VipCust> getVips()
        {
            return vips;
        }
    }
}

