using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using window = System.Windows.Forms;

namespace 비트코인정보.Util
{
    public static class KeyData
    {
        public static List<window.Keys> Keys { get; set; } = new List<window.Keys>();

        static KeyData()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Keys.Add((window.Keys)i);
            }
            for (int i = (int)window.Keys.F1; i <= (int)window.Keys.F12; i++)
            {
                Keys.Add((window.Keys)i);
            }
        }
    }
}
