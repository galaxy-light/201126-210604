using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tour_guide_program
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://api.visitkorea.or.kr/openapi/service"; // URL
            url += "?ServiceKey=" + "HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            foreach (var item in element.Descendants("item"))
            {
                string durName = item.Element("ITEM_NAME").Value;
                string durId = item.Element("ITEM_SEQ").Value;
                string durComp = item.Element("ENTP_NAME").Value;

                //durs.Add(new Dur(durName, durId, durComp));
            }
            //dataGridView1.DataSource = durs;

        }
    }
}
