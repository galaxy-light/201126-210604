using Managing_Car_Program.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Managing_Car_Program.Ui
{
    partial class Other_parking_view_Form : MaterialForm
    {
        List<Api_parking> parkinglist = new List<Api_parking>();
                
        public Other_parking_view_Form()
        {
            InitializeComponent();
        }

        private void Other_view_Form_Load(object sender, EventArgs e)
        {
            string apiurl = "http://210.99.248.79/rest/PublicParkingAreaService/getPublicParkingAreaList"; // URL
            apiurl += "?ServiceKey=" + "HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D"; // Service Key
            XElement element = XElement.Load(apiurl);
            foreach (var item in element.Descendants("list"))
            {                
                string tempname = item.Element("name").Value;
                string templocation = item.Element("location").Value;
                string tempcount = item.Element("pcount").Value;

                parkinglist.Add(new Api_parking(tempname, templocation, tempcount));
            }
            dataGridView1.DataSource = parkinglist;
        }
    }
}
