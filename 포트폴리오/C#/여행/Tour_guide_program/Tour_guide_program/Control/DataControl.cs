using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tour_guide_program.Control
{
    class DataControl
    {
        private static XElement getElement()
        {
            string url = "http://api.visitkorea.or.kr/openapi/service"; // URL
            url += "?ServiceKey=" + "HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            return element;
        }
    }
}
