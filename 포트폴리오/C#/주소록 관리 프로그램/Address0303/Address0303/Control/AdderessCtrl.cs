using AddressTest0222.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTest0222.control
{
    class AddressCtrl
    {
        // static는 인스턴스를 부를 수 있지만 인스턴스는 static을 부를 수 없음
        // 기본은 인스턴스임
        // static 삭제 : 인스턴스화
        readonly List<Address_attri> addrList = new List<Address_attri>(); // 모델 클래스를 관리하기 위해 List 사용 / 초기화
        // readonly : 읽기 전용

        /*전통적인 초기화 방식은 기본 생성자를 생성        
        List<Student> addrList = null; // 객체가 생성될 때 작동

        public StudentCtrl()
        {
            addrList = new List<Student>();
        }*/

        // Random r; // 랜덤 객체 생성
        RandData rand; // 객체가 생성되어질 때 같이 생성되도록 / r : 생성될 때 매개변수도 전달

        static AddressCtrl inst; // 클래스 변수

        public static AddressCtrl getInst()
        {
            if (inst == null) // 최초에 null이면
            {
                inst = new AddressCtrl(); // 최초 한번만(inst가 동작할 때 처음은 비어져있음) 객체 생성
            }
            return inst; // 생성된 객체를 리턴
        }

        public List<Address_attri> getList()
        {
            return addrList;
        }

        public AddressCtrl()
        {
            /*r = new Random();
            rand = new RandData(r);*/
            rand = new RandData(new Random()); // 위의 두 줄을 한 줄로 / 객체가 생성되어질 때 정보를 던져줌
        }

        public void addItem() // 기존에 있던 static을 지운 이유 : 메인 메서드에서 메서드를 불러야 하기 때문에 두 개의 설정을 맞춰야 함(인스턴스/인스턴스 || static/static)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("주소록 정보 입력");
            Console.WriteLine("-----------------");
            Console.Write("이름: ");
            string name = Console.ReadLine();
            Console.Write("전화: ");
            string tel = Console.ReadLine();
            Console.Write("주소: ");
            string address = Console.ReadLine();
            Console.Write("이메일: ");
            string email = Console.ReadLine();

            addrList.Add(new Address_attri(name, tel, address, email));
            Console.WriteLine("정보가 정상적으로 입력되었습니다.");
        }

        public void viewItem()
        {
            for (int i = 0; i < addrList.Count; i++)
            {
                Console.WriteLine("번호 : " + (i + 1));
                //Console.WriteLine("ID : " + addrList[i].Id);
                Console.WriteLine("이름 : " + addrList[i].Name);
                Console.WriteLine("전화 번호 : " + addrList[i].Tel);
                Console.WriteLine("주소 : " + addrList[i].Address);
                Console.WriteLine("이메일 : " + addrList[i].Email);
                Console.WriteLine("-------------------------");
            }
        }
        
        public void delItem(string name) // string name : 매개 변수
        {        

            for (int i = 0; i < addrList.Count; i++)
            {
                if (name.Equals(addrList[i].Name))
                {
                    addrList.RemoveAt(i--);
                }
            }
            /*
            int cnt = 0;
            while (cnt < addrList.Count)
            {
                if (name.Equals(addrList[cnt].Name))
                {
                    addrList.RemoveAt(cnt);
                }
                else
                {
                    cnt++;
                }
            }
            */
        }

        public void delItemAll()
        {
            addrList.Clear();
            Console.WriteLine("전체 삭제");
        }

        public void randData(int count) // int count : 매개 변수
        {            
            for (int i = 0; i < count; i++)
            {
                addrList.Add(new Address_attri(rand.getName(), rand.getTel(),
                    rand.getAddress(), rand.getEmail())); // 랜덤 객체를 생성해주면 오류 해결
            }
        }               
        
        public void updateItem(int menu) // int menu : 매개 변수
        {                       
            string fi;           
            string re;
            if (menu == 1)
            {
                Console.Write("수정할 이름 : ");
                fi = Console.ReadLine();
                Console.Write("변경할 이름 : ");
                re = Console.ReadLine();
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Name.Equals(fi))
                    {
                        addrList[i].Name = re;
                    }
                }
                for (int i = 0; i < addrList.Count; i++)
                {
                    addrList[i].showAddress();
                }
            }
            else if (menu == 2)
            {
                Console.Write("수정할 전화 번호 : ");
                fi = Console.ReadLine();
                Console.Write("변경할 전화 번호 : ");
                re = Console.ReadLine();
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Tel.Equals(fi))
                    {
                        addrList[i].Tel = re;
                    }
                }
                for (int i = 0; i < addrList.Count; i++)
                {
                    addrList[i].showAddress();
                }
            }
            else if (menu == 3)
            {
                Console.Write("수정할 주소 : ");
                fi = Console.ReadLine();
                Console.Write("변경할 주소 : ");
                re = Console.ReadLine();
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Address.Equals(fi))
                    {
                        addrList[i].Address = re;
                    }
                }
                for (int i = 0; i < addrList.Count; i++)
                {
                    addrList[i].showAddress();
                }
            }
            else if (menu == 4)
            {
                Console.Write("수정할 이메일 : ");
                fi = Console.ReadLine();
                Console.Write("변경할 이메일 : ");
                re = Console.ReadLine();
                for (int i = 0; i < addrList.Count; i++)
                {
                    if (addrList[i].Email.Equals(fi))
                    {
                        addrList[i].Email = re;
                    }
                }
                for (int i = 0; i < addrList.Count; i++)
                {
                    addrList[i].showAddress();
                }
            }
        }
    }
}
