using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ApiTest_01
{
    public partial class Form1 : Form
    {
        List<Connect> durs = new List<Connect>();

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList"; // URL
            url += "?ServiceKey=" + "Kbg5ok99gLL7L7nQwR3uRoSjPEYTXU2TceiGRQ59%2F6CO%2BzLEl%2F2GcGh4L8BYBXfhtxbTbuUZmGTjb0%2BabDPX6w%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            foreach (var item in element.Descendants("item"))
            {
                string durName = item.Element("ITEM_NAME").Value;
                string durId = item.Element("ITEM_SEQ").Value;
                string durComp = item.Element("ENTP_NAME").Value;

                durs.Add(new Connect(durName, durId, durComp));
            }
            dataGridView1.DataSource = durs;
        }
    }
}


 

