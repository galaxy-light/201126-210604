using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program
{
    class DataManager
    {
        public static List<Player> Players = new List<Player>();
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            Players.Clear();
            try
            {
                string PlayersOutput = File.ReadAllText(@"./Players.xml");
                XElement playersXElement = XElement.Parse(PlayersOutput);
                foreach (var item in playersXElement.Descendants("player"))
                {
                    string tempName = item.Element("Name").Value;
                    string tempNumber = item.Element("Number").Value;
                    string tempTeam = item.Element("Team").Value;
                    string tempHeight = item.Element("Height").Value;
                    DateTime tempInsertTime = item.Element("InsertTime").Value == "" ?
                        DateTime.Now : DateTime.Parse(item.Element("InsertTime").Value);

                    Player tempPlayer = new Player()
                    {
                        Name = tempName,
                        Number = tempNumber,
                        Team = tempTeam,
                        Height = tempHeight   
                    };
                    Players.Add(tempPlayer);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 파일이 없어서 여기로 진입했으면
                CreateFile(); // 파일을 다시 만들고
                Save(); // 그 파일을 저장한 다음
                Load(); // 다시 불러들여온다.
            }
        }

        private static void CreateFile()
        {
            // Players.xml 파일 생성

            string fileName = @"./Players.xml";
            StreamWriter writer = File.CreateText(fileName);
            writer.Dispose(); // 메모리 해제
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<players>\n";
            if (Players.Count > 0)
            {
                foreach (var item in Players)
                {
                    booksOutput += "<player>\n";
                    booksOutput += $" <Name>{item.Name}</Name>\n";
                    booksOutput += $" <Number>{item.Number}</Number>\n";
                    booksOutput += $" <Team>{item.Team}</Team>\n";
                    booksOutput += $" <Height>{item.Height}</Height>\n";
                    booksOutput += $" <InsertTime>{item.InsertTime}</InsertTime>\n";
                    booksOutput += "</player>\n";
                }
            }
            else // xml 파일에 아무것도 없는 경우
            {
                for (int i = 1; i <= 5; i++)
                {
                    booksOutput += "<player>\n";
                    booksOutput += " <Name></Name>\n";
                    booksOutput += $" <Number>{i}</Number>\n";
                    booksOutput += " <Team></Team>\n";
                    booksOutput += " <Height></Height>\n";
                    booksOutput += " <InsertTime></InsertTime>\n";
                    booksOutput +=  "</player>\n";
                }
            }
            booksOutput += "</players>";
            File.WriteAllText(@"./players.xml", booksOutput);
        }


        // 두번째 파라미터를 넣지 않으면 name에는 playerProfile가 들어감
        public static void printLog(string contents, string name = "playerProfile")
        {
            DirectoryInfo di = new DirectoryInfo("playerProfile");
            // if (di.Exists == false)
            if(!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }

            // 앞에 @이 있으면 \를 한 개만 적는다.
            // using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true))
            using (StreamWriter writer = new StreamWriter(@"playerProfile\"+name+".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
