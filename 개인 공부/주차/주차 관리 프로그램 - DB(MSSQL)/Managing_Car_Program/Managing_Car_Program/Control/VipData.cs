using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program
{
    class VipData
    {
        public static List<VipCust> vips = new List<VipCust>();

        public VipData()
        {
            Load();
        }

        public static void Load()
        {
            vips.Clear();
            try
            {
                string vipsOutput = File.ReadAllText(@"./Vips.xml");
                XElement vipsxElement = XElement.Parse(vipsOutput);
                foreach (var item in vipsxElement.Descendants("vip"))
                {
                    string vipname = item.Element("vipname").Value;
                    string vipcarnum = item.Element("vipcarnum").Value;
                    string vipphone = item.Element("vipphone").Value;
                    string vipstart = item.Element("vipstart").Value;
                    string vipend = item.Element("vipend").Value;

                    VipCust tempvip = new VipCust()
                    {
                        custnm = vipname,
                        custcarnum = vipcarnum,
                        custph = vipphone,
                        custstart = vipstart,
                        custend = vipend
                    };
                    vips.Add(tempvip);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printlogtxt(ex.Message);
                printlogtxt(ex.StackTrace);

                Createtxt();
                Savetxt();
                Load();
                //throw;
            }
        }

        private static void Createtxt()
        {
            string fileName = @"./Vips.xml"; // 파일 생성
            StreamWriter wr = File.CreateText(fileName); // 파일 없으면 생성
            wr.Dispose(); // 메모리 해제
        }

        public static void Savetxt()
        {
            string txtsOutput = "";
            txtsOutput += "<vips>\n";
            if (vips.Count > 0)
            {
                foreach (var item in vips)
                {
                    txtsOutput += "<vip>\n";
                    txtsOutput += $"  <vipname>{item.custnm}</vipname>\n";
                    txtsOutput += $"  <vipcarnum>{item.custcarnum}</vipcarnum>\n";
                    txtsOutput += $"  <vipphone>{item.custph}</vipphone>\n";
                    txtsOutput += $"  <vipstart>{item.custstart}</vipstart>\n";
                    txtsOutput += $"  <vipend>{item.custend}</vipend>\n";
                    txtsOutput += "</vip>\n";
                }
            }
            txtsOutput += "</vips>";
            File.WriteAllText(@"./Vips.xml", txtsOutput);
        }

        public static void printlogtxt(string contents, string name = "parkingvips")
        {
            DirectoryInfo tx = new DirectoryInfo("parkingvip");
            if (!tx.Exists)
            {
                tx.Create(); // 폴더 생성
            }
            using (StreamWriter wr = new StreamWriter(@"parkingvip\" + name + ".txt", true))
            {
                wr.WriteLine(contents);
            }
        }
    }
}

