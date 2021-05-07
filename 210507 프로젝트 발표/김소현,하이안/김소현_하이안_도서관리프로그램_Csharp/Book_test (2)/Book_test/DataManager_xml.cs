using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Book_test
{
    class DataManager_xml
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();
        public static void Load()
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page = int.Parse(item.Element("page").Value),
                             BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                             isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();

                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Id = int.Parse(item.Element("id").Value),
                             Name = item.Element("name").Value
                         }).ToList<User>();
            }
            catch (Exception exception)
            {
                // 파일이 없으면 예외 발생: 새로운 파일 생성
                CreateFile();
                Save();
            }
        }

        public static void CreateFile()
        {
            //Cars.xml 파일을 만들겁니다.

            string fileName = @"./Books.xml";
            StreamWriter writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제
            fileName = @"./Users.xml";
            writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제

        }

        public static void Save()
        {
            // 도서 XML 생성
            string booksOutput = "";
            booksOutput += "<books>\n";
            if (Books.Count > 0)
            {
                foreach (var item in Books)
                {
                    booksOutput += "<book>\n";
                    booksOutput += "  <isbn>" + item.Isbn + "</isbn>\n";
                    booksOutput += "  <name>" + item.Name + "</name>\n";
                    booksOutput += "  <publisher>" + item.Publisher + "</publisher>\n";
                    booksOutput += "  <page>" + item.Page + "</page>\n";
                    booksOutput += "  <borrowedAt>" + item.BorrowedAt.ToLongDateString() + "</borrowedAt>\n";
                    booksOutput += "  <isBorrowed>" + (item.isBorrowed ? 1 : 0) + "</isBorrowed>\n";
                    booksOutput += "  <userId>" + item.UserId + "</userId>\n";
                    booksOutput += "  <userName>" + item.UserName + "</userName>\n";
                    booksOutput += "</book>\n";
                }
            }
            else
            {
                booksOutput += "<book>\n";
                booksOutput += "  <isbn>1</isbn>\n";
                booksOutput += "  <name>하이안</name>\n";
                booksOutput += "  <publisher>이안출판사</publisher>\n";
                booksOutput += "  <page>123</page>\n";
                booksOutput += "  <borrowedAt>" + DateTime.Now.ToLongDateString() + "</borrowedAt>\n";
                booksOutput += "  <isBorrowed>0</isBorrowed>\n";
                booksOutput += "  <userId>1</userId>\n";
                booksOutput += "  <userName>하이안</userName>\n";
                booksOutput += "</book>\n";
            }

            booksOutput += "</books>";

            // 사용자 XML 생성
            string usersOutput = "";
            usersOutput += "<users>\n";
            if (Users.Count > 0)
            {

                foreach (var item in Users)
                {
                    usersOutput += "<user>\n";
                    usersOutput += "  <id>" + item.Id + "</id>\n";
                    usersOutput += "  <name>" + item.Name + "</name>\n";
                    usersOutput += "</user>\n";
                }
            }
            else
            {
                usersOutput += "<user>\n";
                usersOutput += "  <id>" + "1" + "</id>\n";
                usersOutput += "  <name>" + "하이안" + "</name>\n";
                usersOutput += "</user>\n";
            }
            usersOutput += "</users>";

            // 저장
            File.WriteAllText(@"./Books.xml", booksOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}
