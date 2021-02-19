using AddressTest0219;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTEST0219.control
{
    class StudentHandler
    {
        // 상수 변수        
        const int ADD_ITEM = 1;
        const int VIEW_ITEM = 2;
        const int RAMDOM_ADD = 3;
        const int CLEAR_ITEM = 4;
        const int INFO_CHANGE = 5;
        const int DELETE_ALL = 6;
        const int EXIT = 7;

        // 전역 배열
        // <> : 제네릭 클래스 : 공용의 클래스 / 클래스를 선언하여 객체를 생성할 때, 구체적인 타입을 기재한다. 즉, 타입을 어떤 클래스 종류의 매개변수로 보는 것 
        // <> 안에 타입이 들어감
        static List<Student> addrList = new List<Student>(); // 크기를 정하지 않은(List) 배열 생성

        static Random r = new Random(); // 전역 랜덤


        // Student st = new Student(); // 인스턴스 객체 생성 / 오류 해결을 위해 기본 생성자 추가
        // Student st = null; // 초기값            

        public StudentHandler()
        {
            while (true)
            {
                switch (getMenu())
                {
                    case ADD_ITEM:
                        // Console.WriteLine("정보 추가");
                        // st = addItem(); // 호출
                        addItem(); // F12
                        break;
                    case VIEW_ITEM:
                        // Console.WriteLine("정보 보기");
                        // st.showAddress();
                        viewItem();
                        break;
                    case RAMDOM_ADD:
                        // Console.WriteLine("랜덤 정보 보기");
                        randData();
                        break;
                    case CLEAR_ITEM:
                        //Console.WriteLine("특정 주소록 삭제");
                        clearData();
                        break;
                    case INFO_CHANGE:
                        dataChange();
                        break;
                    case DELETE_ALL:
                        //Console.WriteLine("주소록 전체 삭제");
                        deleteAll();
                        break;
                    case EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0); // 종료(자바의 system.exit(0)와 같음) 
                        break;
                }
            }
        }


        public static int getMenu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("주소록 관리 v1.0");
            Console.WriteLine("------------------");
            Console.WriteLine("1. 주소록 정보 추가");
            Console.WriteLine("2. 주소록 정보 보기");
            Console.WriteLine("3. 랜덤 정보 추가"); // 실행할 때 3을 먼저 누르고 2를 눌러야 랜덤 정보가 출력 됨
            Console.WriteLine("4. 특정 주소록 삭제");
            Console.WriteLine("5. 주소록 수정");
            Console.WriteLine("6. 주소록 전체 삭제");
            Console.WriteLine("7. 종료");
            Console.WriteLine("------------------");
            Console.Write("메뉴 선택 : ");
            int menu = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 : int 타입으로 변환         
            return menu;
        }

        public static void addItem() // Student : 타입
        {
            Console.WriteLine("---------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("---------------");
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("전화 번호 : ");
            string tel = Console.ReadLine();
            Console.Write("주소 : ");
            string address = Console.ReadLine();
            Console.Write("이메일 : ");
            string email = Console.ReadLine();

            /* Student st = new Student(name, tel, address, email); // 객체 생성
            return st;*/
            // return new Student(name, tel, address, email); // 위의 두 줄을 한 줄로

            addrList.Add(new Student(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");

            /* // 싱글톤 객체
            stud.Name = name;
            stud.Tel = tel;
            stud.Address = address;
            stud.Email = email;*/

            //객체생성
            /* Student st = new Student(name, tel, address, email);
            return st;*/
            // return new Student(name, tel, address, email);
        }

        public static void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호 : " + (i + 1));
                Console.WriteLine("ID : " + getId());
                Console.WriteLine("이름 : " + addrList[i].Name);
                Console.WriteLine("전화 번호 : " + addrList[i].Tel);
                Console.WriteLine("주소 : " + addrList[i].Address);
                Console.WriteLine("이메일 : " + addrList[i].Email);
                Console.WriteLine("-----------------------------");
            }
        }

        public static void randData()
        {
            string[] name1 = { "홍길동", "김길동", "이길동", "박길동", "최길동" };
            string[] tel1 = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] address1 = { "대구시 동구", "광주시 동구", "서울시 동구", "대전시 동구", "부산시 동구" };
            string[] email1 = { "hong@gmail.com", "kim@gamil.com", "lee@gmail.com", "park@gmail.com", "choi@gamil.com" };
            // Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                addrList.Add(new Student(getId(), name1[r.Next(0, 5)], tel1[r.Next(0, 5)], address1[r.Next(0, 5)], email1[r.Next(0, 5)]));
                // Thread.sleep(50);
            }
        }

        public static void clearData()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("주소록 정보 삭제");
            Console.WriteLine("---------------");
            Console.Write("삭제할 ID 입력 : ");
            string clear = Console.ReadLine();
            for (int i = 0; i < addrList.Count; i++)
            {
                // 방법 두 가지
                /* if (addrList[i].Name == clear)
                {
                    addrList.RemoveAt(i); // RemoveAt : 인덱스 값을 이용하여 배열의 요소 삭제
                    i--;
                }*/
                if (clear.Equals(addrList[i].Id)) // addrList[i].Name : 배열 안의 이름 정보
                {
                    addrList.RemoveAt(i);
                    i--; // i--; : 특정 배열 요소를 삭제했을 때 연달아 있는 동일한 정보(이름)가 밀려 올라가서 체크가 누락되지 않도록
                    /* ex) i--;가 없다면 : 랜덤으로 출력해서 6번 최길동 7번 최길동 -> 최길동만 삭제했을 때
                    : 6번 최길동만 삭제되고 7번 최길동은 6번으로 밀려 올라감
                    -> 이것을 프로그램에서 잡지 못해 7번이었던 최길동이 6번으로 변경되어 삭제 되지 않고 그대로 출력 됨 -> 오류 발생 */

                    // addrList.RemoveAt(i--); // 위의 두 줄을 한 줄로                    
                }
            }

        }
        public static void deleteAll()
        {
            addrList.Clear();
            Console.WriteLine("주소록 전체 삭제");
        }

        static string getId()
        {
            // Random r = new Random();
            string rdata = "abcdefghijklmnopqrstuvwxyz123456789ABCDEFGHIJKLMLPQRSTUVWZYZ~!@#$%^&*?"; // 0과 O는 구분이 안돼서 제거
            StringBuilder rs = new StringBuilder();
            for (int i = 0; i < 7; i++)
            {
                rs.Append(rdata[(int)(r.NextDouble() * rdata.Length)]); // Append : 생성된 데이터를 계속 붙이는 역할
            }
            // Console.WriteLine("ID : " + rs.ToString());
            return rs.ToString();
        }

        public static void dataChange()
        {
            Console.WriteLine("----------");
            Console.WriteLine("주소록 수정");
            Console.WriteLine("----------");
            Console.WriteLine("1. 이름");
            Console.WriteLine("2. 전화 번호");
            Console.WriteLine("3. 주소");
            Console.WriteLine("4. 이메일");
            Console.WriteLine("----------");
            Console.Write("수정할 항목 : ");
            int change = Convert.ToInt32(Console.ReadLine());
            switch (change)
            {
                case 1:
                    Console.Write("수정할 이름 : ");
                    string name = Console.ReadLine();
                    Console.Write("변경할 이름 : ");
                    string rename = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (addrList[i].Name.Equals(name))
                        {
                            addrList[i].Name = rename;
                        }
                    }
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        addrList[i].showAddress();
                    }
                    break;
                case 2:
                    Console.Write("수정할 전화 번호 : ");
                    string tel = Console.ReadLine();
                    Console.Write("변경할 전화 번호 : ");
                    string retel = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (addrList[i].Tel.Equals(tel))
                        {
                            addrList[i].Tel = retel;
                        }
                    }
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        addrList[i].showAddress();
                    }
                    break;
                case 3:
                    Console.Write("수정할 주소 : ");
                    string address = Console.ReadLine();
                    Console.Write("변경할 주소 : ");
                    string readdress = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (addrList[i].Address.Equals(address))
                        {
                            addrList[i].Address = readdress;
                        }
                    }
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        addrList[i].showAddress();
                    }
                    break;
                case 4:
                    Console.Write("수정할 이메일 : ");
                    string email = Console.ReadLine();
                    Console.Write("변경할 이메일 : ");
                    string reemail = Console.ReadLine();
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        if (addrList[i].Email.Equals(email))
                        {
                            addrList[i].Email = reemail;
                        }
                    }
                    for (int i = 0; i < addrList.Count; i++)
                    {
                        addrList[i].showAddress();
                    }
                    break;
            }
        }
    }
}

