using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_test
{
    class DataManager_json
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();
        //DataManager DataManager = new DataManager();

        static DataManager_json()
        {
            LoadJson();
        }
        public static void LoadJson()
        {
            try
            {
                string strBookValueJson = File.ReadAllText(@"./Books.json");
                JObject jsonObjectBook = JObject.Parse(strBookValueJson);
                Books = (from item in jsonObjectBook["books"]["book"]
                         select new Book()
                         {
                             Isbn = item["isbn"].ToString(),
                             Name = item["name"].ToString(),
                             Publisher = item["publisher"].ToString(),
                             Page = int.Parse(item["page"].ToString()),
                             BorrowedAt = DateTime.Parse(item["borrowedat"].ToString()),
                             isBorrowed = item["isborrowed"].ToString() != "0" ? true : false,
                             UserId = int.Parse(item["userid"].ToString()),
                             UserName = item["username"].ToString().Replace("{", "").Replace("}", "")
                         }).ToList<Book>();

                string strUserValueJson = File.ReadAllText(@"./Users.json");
                JObject jsonObjectUser = JObject.Parse(strUserValueJson);
                Users = (from item in jsonObjectUser["users"]["user"]
                         select new User()
                         {
                             Id = int.Parse(item["id"].ToString()),
                             Name = item["name"].ToString()
                         }).ToList<User>();
            }
            catch (Exception e)
            {
                MessageBox.Show("파일이 누락되었습니다!!!");
                CreateFile();
                SaveJson();
                LoadJson(); //다시 불러들이기
            }

        }

        public static void CreateFile()
        {
            //Cars.xml 파일을 만들겁니다.

            string fileName = @"./Books.json";
            StreamWriter writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제
            fileName = @"./Users.json";
            writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제

        }

        public static void SaveJson()
        {
            var jBookArray = new JArray();
            foreach (var item in DataManager.Books)
            {
                var jBookobject = new JObject();
                jBookobject.Add("isbn", item.Isbn);
                jBookobject.Add("name", item.Name);
                jBookobject.Add("publisher", item.Publisher);
                jBookobject.Add("page", item.Page);
                jBookobject.Add("borrowedat", item.BorrowedAt.ToLongDateString());
                jBookobject.Add("isborrowed", item.isBorrowed ? "1" : "0");
                jBookobject.Add("userid", item.UserId);
                jBookobject.Add("username", item.UserName);
                jBookArray.Add(jBookobject);
            }

            var jBookArrayobect = new JObject();
            jBookArrayobect.Add("book", jBookArray);
            var jBooksobect = new JObject();
            jBooksobect.Add("books", jBookArrayobect);

            var jUserArray = new JArray();
            foreach (var item in Users)
            {
                var jUseroject = new JObject();
                jUseroject.Add("id", item.Id);
                jUseroject.Add("name", item.Name);
                jUserArray.Add(jUseroject);
            }

            var jUserArrayobject = new JObject();
            jUserArrayobject.Add("user", jUserArray);
            var jUsersobject = new JObject();
            jUsersobject.Add("users", jUserArrayobject);

            // 저장
            File.WriteAllText(@"./Books.json", jBooksobect.ToString());
            File.WriteAllText(@"./Users.json", jUsersobject.ToString());
        }

        public static void SaveJson(Book book)
        {
            var jBookArray = new JArray();
            foreach (var item in
            DataManager.Books)
            {
                var jBookobject = new JObject();
                jBookobject.Add("isbn", item.Isbn);
                jBookobject.Add("name", item.Name);
                jBookobject.Add("publisher", item.Publisher);
                jBookobject.Add("page", item.Page);
                jBookobject.Add("borrowedat", item.BorrowedAt.ToLongDateString());
                jBookobject.Add("isborrowed", item.isBorrowed ? "1" : "0");
                jBookobject.Add("userid", item.UserId);
                jBookobject.Add("username", item.UserName);
                jBookArray.Add(jBookobject);
            }

            var jBookArrayobect = new JObject();
            jBookArrayobect.Add("book", jBookArray);
            var jBooksobect = new JObject();
            jBooksobect.Add("books", jBookArrayobect);

            var jUserArray = new JArray();
            foreach (var item in Users)
            {
                var jUseroject = new JObject();
                jUseroject.Add("id", item.Id);
                jUseroject.Add("name", item.Name);
                jUserArray.Add(jUseroject);
            }

            var jUserArrayobject = new JObject();
            jUserArrayobject.Add("user", jUserArray);
            var jUsersobject = new JObject();
            jUsersobject.Add("users", jUserArrayobject);

            // 저장
            File.WriteAllText(@"./Books.json", jBooksobect.ToString());
            File.WriteAllText(@"./Users.json", jUsersobject.ToString());
        }
    }
}
