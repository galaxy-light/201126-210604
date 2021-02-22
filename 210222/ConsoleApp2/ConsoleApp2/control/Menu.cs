using ConsoleApp2.model;
using ConsoleApp2.randdata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.control
{      
    class Menu
    {
        List<Student> ListStudent = new List<Student>();       

        Random r;
        RandomData rand;

        public Menu()
        { 
            rand = new RandomData(new Random());
        }

        public const int MENU_INFO_ADD = 1;
        public const int MENU_INFO_SHOW = 2;
        public const int MENU_RANDOM_INFO = 3;
        public const int MENU_DELETE = 4;
        public const int MENU_DELETE_ALL = 5;
        public const int MENU_INFO_FIX = 6;
        public const int MENU_EXIT = 7;

        public int getMenu()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("### 전체 메뉴 ###");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. 주소록 추가");
            Console.WriteLine("2. 주소록 보기");
            Console.WriteLine("3. 랜덤 주소록 추가");
            Console.WriteLine("4. 특정 주소록 삭제");
            Console.WriteLine("5. 주소록 전체 삭제");
            Console.WriteLine("6. 종료");
            Console.Write("메뉴 선택 : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }

        public string getAdd()
        {
            string a;            
            Console.WriteLine("이름 : ");
            a = Console.ReadLine();
            Console.WriteLine("전화 번호 : ");
            a = Console.ReadLine();
            Console.WriteLine("주소 : ");
            a = Console.ReadLine();
            Console.WriteLine("이메일 : ");
            a = Console.ReadLine();
            return a;
        }

        public void viewInfo()
        {
            Console.WriteLine("이름 ");
            Console.WriteLine("이름 ");
            Console.WriteLine("이름 ");
            Console.WriteLine("이름 ");
            
        }
        
    }       
}
