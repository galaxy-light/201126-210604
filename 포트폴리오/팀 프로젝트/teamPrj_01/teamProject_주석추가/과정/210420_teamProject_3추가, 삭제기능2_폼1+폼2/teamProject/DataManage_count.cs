using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace teamProject
{
    class DataManager_count
    {
        public static List<Drug> Drugc = new List<Drug>();        
               
        static Random r = new Random();
        
        static DataManager_count()
        {
            Load();
        }
        
        public static void Load()
        {
            Drugc.Clear();
            try
            {
                string drugOutput = File.ReadAllText(@"./drugInfo.xml");
                XElement compElement1 = XElement.Parse(drugOutput);
                // XElement <속성명>데이터1</속성명>
                foreach (var item in compElement1.Descendants("drug"))
                {
                    string tempMedName = item.Element("medName").Value;
                    string tempMedCom = item.Element("medCom").Value;
                    string tempMedCode = item.Element("medCode").Value;
                    string tempMedContain = item.Element("medContain").Value;
                    string tempMedListCode = item.Element("medListCode").Value;
                    int tempMedCount = Convert.ToInt32(item.Element("medCount").Value);

                    Drugc.Add(new Drug(tempMedName, tempMedCom, tempMedCode, tempMedContain, tempMedListCode, tempMedCount));
                }
            }
            catch (Exception ex)
            { 
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                CreateFile(); 
                Save(); 
                Load(); 
                // 단, Load 함수자체가 잘못됐다면 코드는 무한루프
            }
        }

        private static void CreateFile()
        {
            // drugInfo.xml파일 생성
            string fileName = @"./drugInfo.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose();
        }

        private static XElement getElement()
        {
            string url = "http://apis.data.go.kr/1470000/DURPrdlstInfoService/getUsjntTabooInfoList"; // URL
            url += "?ServiceKey=" + "Kbg5ok99gLL7L7nQwR3uRoSjPEYTXU2TceiGRQ59%2F6CO%2BzLEl%2F2GcGh4L8BYBXfhtxbTbuUZmGTjb0%2BabDPX6w%3D%3D"; // Service Key
            XElement element = XElement.Load(url);
            return element;
        }

        public static void Save()
        {
            string drugOutput = "";
            drugOutput += "<drugc>\n";

            if (Drugc.Count > 0)
            {
                foreach (var item in Drugc)
                {
                    drugOutput += "<drug>\n";
                    drugOutput += $"   <medName>{item.MedName}</medName>";
                    drugOutput += $"   <medCom>{item.MedCom}</medCom>";
                    drugOutput += $"   <medCode>{item.MedCode}</medCode>";
                    drugOutput += $"   <medContain>{item.MedContain}</medContain>";
                    drugOutput += $"   <medListCode>{item.MedListCode}</medListCode>";
                    drugOutput += $"   <medCount>{item.CountMed}</medCount>";
                    drugOutput += "</drug>\n";
                }
            }

            else // xml파일에 아무것도 없는 경우
            {
                XElement element = getElement();
                foreach(var item in element.Descendants("item"))
                {
                    drugOutput += "<drug>\n";
                    drugOutput += $"   <medName>{item.Element("ITEM_NAME").Value}</medName>";
                    drugOutput += $"   <medCom>{item.Element("ENTP_NAME").Value}</medCom>";
                    drugOutput += $"   <medCode>{item.Element("ITEM_SEQ").Value}</medCode>";
                    drugOutput += $"   <medContain>{item.Element("MAIN_INGR").Value}</medContain>";
                    drugOutput += $"   <medListCode>{item.Element("CLASS_NAME").Value}</medListCode>";
                    drugOutput += $"   <medCount>{r.Next(1000)}</medCount>";
                    drugOutput += "</drug>\n";
                }
            }
            drugOutput += "</drugc>";
            File.WriteAllText(@"./drugInfo.xml", drugOutput);
        }

        public static void printLog(string contents, string name = "drugCount")
        {
            DirectoryInfo di = new DirectoryInfo("drugCount");
            if (!di.Exists)
            {
                di.Create();
            }
            
            using (StreamWriter writer = new StreamWriter(@"drugCount\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
