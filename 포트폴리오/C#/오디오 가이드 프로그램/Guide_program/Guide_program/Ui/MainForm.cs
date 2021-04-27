using Guide_program.Model;
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

namespace Guide_program
{
    public partial class Form1 : Form
    {
        List<Guidelist> glist = new List<Guidelist>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://api.visitkorea.or.kr/openapi/service/rest/Odii"; // URL
            url += "?ServiceKey=" + "HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            foreach (var item in element.Descendants("item"))
            {                
                string temptourid = item.Element("tid").Value;
                string temptourtlid = item.Element("tlid").Value;
                string temptourtitle = item.Element("title").Value;
                string temptouraddr1 = item.Element("addr1").Value;
                string temptouraddr2 = item.Element("addr2").Value;
                string temptourlangcheck = item.Element("langCheck").Value;
                string temptourlangcode = item.Element("langCode").Value;
                string temptourimageurl = item.Element("imageUrl").Value;

                glist.Add(new Guidelist(temptourid, temptourtlid, temptourtitle, temptouraddr1,
                    temptouraddr2, temptourlangcheck, temptourlangcode, temptourimageurl));
            }
            dataGridView1.DataSource = glist;
        }
    }
}
