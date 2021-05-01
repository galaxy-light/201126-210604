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
        // protected : 상속받은 클래스만 사용 가능
        // public, private, protected의 개념 : https://slaner.tistory.com/69

        public static List<ParkingCar> Cars = new List<ParkingCar>();       

        static DataManager() // static : 프로그램이 실행될 때 바로 메모리에 올라감
        {
            Load();
        }

        public static void Load() // static이 붙은 이유는 호출되는 함수에 static이 붙어있기 때문에
        {
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml"); // exe 파일이 있는 폴더에 Cars.xml이 있는지 확인하고 carsOutput에 넣음
                XElement carsXElement = XElement.Parse(carsOutput); // string carsOutput 데이터를 XElement타입의 carsXElement로 바꿈
                // 위의 두 줄을 정리하면 Cars.xml에 있는 데이터를 XElement타입으로 형변환
                // 형변환을 한 이유는 string에는 Descendants나 Element가 없기 때문에 XElement로 형변환을 해준 것
                foreach (var item in carsXElement.Descendants("car")) // Descendants : 자손
                // 자손들 중에서 태그 이름이 car인 것들을 foreach문으로 불러옴
                {
                    // car의 구성요소 : parkingSpot, carNumber, driverName, phoneNumber, parkingTime
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value); // 각각(parkingSpot)의 값들을 불러와 임시변수인 tempParkingSpot에 저장
                    string tempCarNumber = item.Element("carNumber").Value;
                    /*string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;*/
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ?
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        /*driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,*/
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 만약 파일이 없어서 여기로 진입한 경우라면
                CreateFile(); // 파일을 다시 만들고
                Save(); // 그 파일을 저장한 다음
                Load(); // 다시 불러들여봄
                // 단, Load 함수 자체가 잘못된거라면 이 코드는 무한 루프에 빠짐 - 해결 방법은 있음(오버로딩을 하거나 count 변수를 쓰거나 다양한 방법 있음)
                // 재귀 함수를 무한대로 부르면 스택오버플로우가 발생
                
                //throw;
            }
            //CreateFile(); // 이 함수에는 static이 붙었기 때문에 호출 가능(static은 static이 있어야 됨)
            //example(); // 함수에 static이 없기 때문에 호출 불가능
        }

        /*private void example()
        { 
            
        }*/

        private static void CreateFile() // static은 static이 붙은 함수끼리 호출 가능(메모리에 올라가는 순서때문에)
        {
            // Cars.xml 파일 생성
            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName); // 파일이 없으면 해당 파일 생성
            writer.Dispose(); // 메모리 해제
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<cars>\n"; // \n 대신에 Enviroment.NewLine 써도 됨
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"  <parkingSpot>{item.parkingSpot}</parkingSpot>\n";
                    booksOutput += $"  <carNumber>{item.carNumber}</carNumber>\n";
                    /*booksOutput += $"  <driverName>{item.driverName}</driverName>";
                    booksOutput += $"  <phoneNumber>{item.phoneNumber}</phoneNumber>";*/
                    booksOutput += $"  <parkingTime>{item.parkingTime}</parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            else // xml 파일에 아무것도 없는 경우
            {
                for (int i = 1; i <= 30; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"  <parkingSpot>{i}</parkingSpot>\n";
                    booksOutput += "  <carNumber></carNumber>\n";
                    /*booksOutput += "  <driverName></driverName>";
                    booksOutput += "  <phoneNumber></phoneNumber>";*/
                    booksOutput += "  <parkingTime></parkingTime>\n";
                    booksOutput += "</car>\n";                    
                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        // 두번쨰 파라미터를 넣지 않으면 name에는 parkingHistory가 들어감(값을 안넣어주면 기본값이 들어감)
        public static void printLog(string contents, string name = "parkingHistory")
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            //if (di.Exists == false) // parkingHistory이라는 폴더가 없다면
            if (!di.Exists) // 위의 if문과 동일함
            {
                di.Create(); // 폴더 생성
            }
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt", true)) // true로 적으면 txt파일에 내용이 n개
            using (StreamWriter writer = new StreamWriter(@"parkingHistory\" + name + ".txt", true)) // true가 없으면 txt파일에 내용이 전체 내용 중 한줄만 뜸
            // @ : 이스케이프 문자
            // 앞에 @가 있으면 \를 한개만 적으면 됨
            // @가 없으면 \\ 이렇게 적어야지 한개로 인식함
            {
                writer.WriteLine(contents);
            }
        }        
    }
}
