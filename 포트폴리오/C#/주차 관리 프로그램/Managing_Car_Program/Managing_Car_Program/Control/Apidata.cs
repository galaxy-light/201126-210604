using Managing_Car_Program.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program.Control
{
    class Apidata
    {
        public static List<Api_parking> parkinglist = new List<Api_parking>();

        static string emsg;
        const string FORM_NAME = "Api Form";

        static Apidata()
        {
            apiload();
        }

        private static void apiload()
        {
            parkinglist.Clear();
            try
            {
                string dataoutput = File.ReadAllText(@"./parkingplace.xml");
                XElement apielement = XElement.Parse(dataoutput);
                // XElement <속성명>데이터</속성명>
                foreach (var item in apielement.Descendants("parking"))
                {
                    string tempname = item.Element("name").Value;                    
                    string templocation = item.Element("location").Value;
                    string tempcount = item.Element("pcount").Value;

                    parkinglist.Add(new Api_parking(tempname, templocation, tempcount));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                emsg = $"[폼 위치 : {FORM_NAME}] [에러메시지] : {ex.Message}, \n[에러위치] : {ex.StackTrace}\n";
                DataManager.printLog(emsg, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                createfile();
                apisave();
                apiload(); // 단, Load 함수자체가 잘못됐다면 무한루프에 빠짐
                //throw;
            }
        }

        private static void createfile()
        {
            // xml 파일 생성
            string fileName = @"./parkingplace.xml";
            StreamWriter sw = File.CreateText(fileName);
            sw.Dispose();
        }

        private static XElement getelement()
        {
            string apiurl = "http://210.99.248.79/rest/PublicParkingAreaService/getPublicParkingAreaList";
            apiurl += "?authApiKey=" + "HQgKgYZmyYSD59RIxPaVemafErQvF0cQVprgggIgaK7Zznh3nu%2F7FYGPXo9lHIDgaqeZDvJRD93rc9RASG31Jw%3D%3D";
            XElement element = XElement.Load(apiurl);
            return element;
        }

        public static void apisave()
        {
            string dataoutput = "";
            dataoutput += "<parkings>\n";

            if (parkinglist.Count > 0)
            {
                foreach (var item in parkinglist)
                {
                    dataoutput += "<parking>\n";
                    dataoutput += $"  <name>{item.Name}</name>"; // xml 파일과 태그 동일                   
                    dataoutput += $"  <location>{item.Location}</location>";
                    dataoutput += $"  <pcount>{item.Pcount}</pcount>";
                    dataoutput += "</parking>\n";
                }
            }
            else
            {
                XElement element = getelement();
                foreach (var item in element.Descendants("item"))
                {
                    dataoutput += "<parking>\n";
                    dataoutput += $"  <name>{item.Element("ITEM_NAME").Value}</name>"; // xml 파일과 태그 동일                    
                    dataoutput += $"  <location>{item.Element("ITEM_LOCATION").Value}</location>";
                    dataoutput += $"  <pcount>{item.Element("ITEM_PCOUNT").Value}</pcount>";
                    dataoutput += "</parking>\n";
                }
            }
            dataoutput += "</parkings>";
            File.WriteAllText(@"./parkingplace.xml", dataoutput);
        }
    }
}
