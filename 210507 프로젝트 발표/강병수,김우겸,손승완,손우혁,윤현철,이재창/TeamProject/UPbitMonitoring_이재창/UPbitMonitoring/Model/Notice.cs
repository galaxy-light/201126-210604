using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 비트코인정보.Model
{
    public class Notice
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int Time { get; set; }
        public string Format { get; set; }
        public string Mode { get; set; }
        public static readonly string UP = "이상";
        public static readonly string Down = "이하";
    }
}
