using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비트코인정보.Model
{
    public class KeyInfo
    {
        public Keys Key { get; set; }
        public bool IsShift { get; set; }
        public bool IsCtrl { get; set; }
        public bool IsAlt { get; set; }
    }
}
