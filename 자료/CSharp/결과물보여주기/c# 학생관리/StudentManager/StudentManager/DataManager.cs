using SendManager;
using SendManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendManager
{
    class DataManager
    {
        public static List<Send> Send = new List<Send>();
        public static List<Major> Majors = new List<Major>();

        public static void Load_Sends()
        {
            try
            {
                Send.Clear();
                string sOutput = File.ReadAllText(@"./SendsList.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("Send"))
                {
                    string name = item.Element("name").Value;
                    string Id = item.Element("id").Value;
                    double Score = 0;
                    double.TryParse(item.Element("score").Value, out Score);
                    int Grade = 0;
                    int.TryParse(item.Element("grade").Value, out Grade);
                    DateTime temp_RegDate = item.Element("regDate").Value == "" ? DateTime.Now : DateTime.Parse(item.Element("regDate").Value); //DateTie.Now 대신 DateTime.Now("yyyy-MM-dd")를 입력하면 프로그램 시작한 시점의 시간이 들어감

                    Send tempSend = new Send()
                    {
                        mName = name,
                        mId = Id,
                        mScore = Score,
                        mGrade = Grade,
                        RegDate = temp_RegDate
                    };
                    Send.Add(tempSend);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_Sends();
                Save_Sends();
                Load_Sends();
            }
        }
        public static void Save_Sends()
        {
            string SendOutput = "";
            SendOutput += "<Sends>" + Environment.NewLine;
            if (Send.Count > 0)
            {
                foreach (var item in Send)
                {
                    SendOutput += "<Send>" + Environment.NewLine;
                    SendOutput += "     <name>" + item.mName + "</name>" + Environment.NewLine;
                    SendOutput += "     <id>" + item.mId + "</id>" + Environment.NewLine;
                    SendOutput += "     <score>" + item.mScore + "</score>" + Environment.NewLine;
                    SendOutput += "     <grade>" + item.mGrade + "</grade>" + Environment.NewLine;
                    SendOutput += "     <regDate>" + item.RegDate + "</regDate>" + Environment.NewLine;
                    SendOutput += "</Send>" + Environment.NewLine;
                }
            }

            SendOutput += "</Send>" + Environment.NewLine;

            File.WriteAllText(@"./SendList.xml", SendOutput);

        }
        public static void CreateFile_Sends()
        {
            string fileName = @"./SendList.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
        public static void Load_Majors()
        {
            try
            {
                Majors.Clear();
                string sOutput = File.ReadAllText(@"./majorsList.xml");
                XElement sXElement = XElement.Parse(sOutput);

                foreach (var item in sXElement.Descendants("major"))
                {
                    string name = item.Element("name").Value;
                    string code = item.Element("code").Value;

                    Major temp = new Major()
                    {
                        mMajorName = name,
                        mMajorCode = code
                    };
                    Majors.Add(temp);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("파일이 누락되었습니다!" + Environment.NewLine + exception.Message);
                PrintLog(exception.StackTrace);
                CreateFile_majors();
                Save_Majors();
                Load_Majors();
            }
        }
        public static void Save_Majors()
        {
            string majorsOutput = "";
            majorsOutput += "<majors>" + Environment.NewLine;
            if (Majors.Count > 0)
            {
                foreach (var item in Majors)
                {
                    majorsOutput += "<major>" + Environment.NewLine;
                    majorsOutput += "     <name>" + item.mMajorName + "</name>" + Environment.NewLine;
                    majorsOutput += "     <code>" + item.mMajorCode + "</code>" + Environment.NewLine;
                    majorsOutput += "</major>" + Environment.NewLine;
                }
            }

            majorsOutput += "</majors>" + Environment.NewLine;

            File.WriteAllText(@"./majorsList.xml", majorsOutput);
        }
        public static void CreateFile_majors()
        {
            string fileName = @"./majorsList.xml";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ProgramHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ProgramHistory" + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")}]" + contents);
            }
        }
    }
}
