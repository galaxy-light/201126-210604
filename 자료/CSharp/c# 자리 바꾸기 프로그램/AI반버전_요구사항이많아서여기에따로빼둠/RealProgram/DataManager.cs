using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RealProgram
{
    class DataManager
    {
        public static List<Student> students = new List<Student>();

        public static void load_Students_List()
        {
            students.Clear();
            string sOutput = File.ReadAllText(@"./students.xml");
            XElement sXElement = XElement.Parse(sOutput);
            foreach (var item in sXElement.Descendants("student"))
            {

                int number = int.Parse(item.Element("number").Value);
                string name = item.Element("name").Value;
                if (name == number.ToString())
                    continue;
                string gender = item.Element("gender").Value;
                bool mustFront = bool.Parse(item.Element("mustFront").Value);
                bool mustBack = bool.Parse(item.Element("mustBack").Value);
                bool isFixed = bool.Parse(item.Element("fixed").Value);
                students.Add(new Student(number, name, gender, mustFront, mustBack, isFixed));
            }
        }


        public static bool shuffleStudentList()
        {
            Random r = new Random();
            List<int> numberList = new List<int>();
            int[] frontSeat = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] backSeat = { 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            int numberOfmustFront = 0;
            int numberOfmustBack = 0;
            foreach (var item in students)
            {
                if (item.mustFront)
                    numberOfmustFront++;
                if (item.isFixed && (item.mustFront || item.mustBack))
                {
                    MessageBox.Show(item.name + "님의 옵션은 서로 상충됩니다! 수정해주세요!");
                    //return;
                    //Dispose();
                    return false;
                }
            }
            if (numberOfmustFront > frontSeat.Length)
            {
                MessageBox.Show("frontSeat 값을 늘리거나 더 이상 앞자리에 앉힐 학생을 추가할 수 없습니다.");
                //return;
                //Dispose();

                return false;

            }
            foreach (var item in students)
            {
                if (item.mustBack)
                    numberOfmustBack++;
            }
            if (numberOfmustBack > backSeat.Length)
            {
                MessageBox.Show("backSeat 값을 늘리거나 더 이상 앞자리에 앉힐 학생을 추가할 수 없습니다.");
                //return;
                //Dispose();
                return false;

            }

            //number 값을 전부 리셋하는 과정에서 fixed가 true인 것들만 남긴다.
            for (int i = 1; i <= students.Count; i++) //리셋
            {
                if (!students[i - 1].isFixed)
                    students[i - 1].number = 0;
                else
                    numberList.Add(students[i - 1].number);
            }
            //mustFront에 대해서 먼저 배치
            for (int i = 1; i <= students.Count; i++)
            {
                if (students[i - 1].mustFront)
                {
                    int newNum = frontSeat[r.Next(frontSeat.Length)];
                    while (numberList.Contains(newNum)) //이미 존재하는 번호일 경우
                    {
                        newNum = frontSeat[r.Next(frontSeat.Length)]; //다시 뽑는다.
                    }
                    numberList.Add(newNum); //중복체크를 위하여 번호를 담는다.
                    students[i - 1].number = newNum; //새로 뽑은 번호로 바꿔줌
                }
            }
            //mustBack에 대해서 그 다음 배치
            for (int i = 1; i <= students.Count; i++)
            {
                if (students[i - 1].mustBack)
                {
                    int newNum = backSeat[r.Next(backSeat.Length)];
                    while (numberList.Contains(newNum)) //이미 존재하는 번호일 경우
                    {
                        newNum = backSeat[r.Next(backSeat.Length)]; //다시 뽑는다.
                    }
                    numberList.Add(newNum); //중복체크를 위하여 번호를 담는다.
                    students[i - 1].number = newNum; //새로 뽑은 번호로 바꿔줌
                }
            }

            //리셋하고 나서 하나하나 값을 넣는데 그게 mustfront면 frontSeat에서 가져오고
            //그게 mustback이면 backSeat에서 가져오고
            //->중복예외처리 ㄱ
            //mustFront나 mustBack가 아니면 그냥 랜덤값을 돌리마.
            //->중복예외처리 ㄱ
            for (int i = 1; i <= students.Count; i++)
            {
                if (students[i - 1].isFixed || students[i - 1].mustFront || students[i - 1].mustBack)
                {
                    continue;
                }
                else
                {
                    int newNum = r.Next(1, students.Count + 1); //1이상 25이하
                    while (numberList.Contains(newNum)) //이미 존재하는 번호일 경우
                    {
                        newNum = r.Next(1, students.Count + 1); //다시 뽑는다.
                    }
                    numberList.Add(newNum); //중복체크를 위하여 번호를 담는다.
                    students[i - 1].number = newNum; //새로 뽑은 번호로 바꿔줌
                }
            }
            return true;
        }


        public static void SaveData()
        {
            /*
               <student>
                <number>12</number>
                <name>김관덕</name>
                <gender>남</gender>
                <mustFront>false</mustFront>
                <mustBack>false</mustBack>
                <fixed>false</fixed>
              </student>
             */
            string contents = "<students>\n";
            students.Sort(); //number를 기준으로 정렬
            foreach (var item in students)
            {
                contents += "<student>\n";
                contents += $"  <number>{item.number}</number>\n";
                contents += $"  <name>{item.name}</name>\n";
                contents += $"  <gender>{item.gender}</gender>\n";
                contents += $"  <mustFront>{item.mustFront}</mustFront>\n";
                contents += $"  <mustBack>{item.mustBack}</mustBack>\n";
                contents += $"  <fixed>{item.isFixed}</fixed>\n";
                contents += "</student>\n";
            }
            contents += "</students>";
            File.WriteAllText(@"./students.xml", contents);
            File.WriteAllText(@"./students"+ DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss_fff")  +".xml", contents);
        }
    }
}
