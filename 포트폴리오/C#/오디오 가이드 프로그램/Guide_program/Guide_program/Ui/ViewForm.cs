using Guide_program.Model;
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

namespace Guide_program.Ui
{
    public partial class ViewForm : Form
    {
        List<Guidelist> glist = new List<Guidelist>();

        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            string url = "http://api.visitkorea.or.kr/openapi/service/rest/Odii/themeBasedList?ServiceKey=HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D&MobileOS=ETC&MobileApp=AppTest&langCode=ko";
            XElement element = XElement.Load(url);
            foreach (var temp in element.Descendants("item"))
            {
                string temptourid = temp.Element("tid").Value;
                string temptourtlid = temp.Element("tlid").Value;
                string temptourtitle = temp.Element("title").Value;
                string temptouraddr1 = temp.Element("addr1").Value;
                string temptourlangcheck = temp.Element("langCheck").Value;
                string temptourlangcode = temp.Element("langCode").Value;

                glist.Add(new Guidelist(temptourid, temptourtlid, temptourtitle, 
                    temptouraddr1, temptourlangcheck, temptourlangcode));
            }
            dataGridView1.DataSource = glist;
        }
    }
}
