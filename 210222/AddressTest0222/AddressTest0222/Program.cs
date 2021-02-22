using AddressTest0222.view;
using AddressTest0222.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressTest0222
{
    // static : 공용의 영역, 객체가 많이 생성되어도 딱 한 번만, 굳이 객체를 생성하지 않더라도 사용 가능
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu(); // static을 안 붙이려면 Main안에서 생성 / Menu 객체 생성 / 메뉴는 딱 한번만 생성하면 되기 때문에 무한 루프 밖에서 생성
            StudentCtrl sc = new StudentCtrl(); // addItem(), viewItem(); randData(100);, delItem();, delItemAll();의 오류 해결을 위해 객체 생성
            while (true)
            {
                switch (m.mainMenu())
                {
                    case Menu.MENU_MAIN_ADD: // Menu.MENU_MAIN_ADD 오류 : Menu 클래스의 const 앞에 public를 붙여주면 오류 해결
                        sc.addItem(); // 오류 해결을 위해 객체 생성 -> sc.메서드();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        sc.viewItem();
                        break;
                    case Menu.MENU_MAIN_RANDOM_ADD:
                        sc.randData(10); // 10 : count : 사용자가 원하는 만큼
                        break;
                    case Menu.MENU_MAIN_DELETE:
                        sc.delItem(m.delMenu()); // m.delMenu()(매개 변수)가 먼저 작동하고 delItem이 작동함
                        break;
                    case Menu.MENU_MAIN_DELETE_ALL:
                        sc.delItemAll();
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        sc.updateItem(m.updataMenu());
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("프로그램 종료");
                        Environment.Exit(0);
                        break;
                    case Menu.MENU_MAIN_FORMAT_ERROR:
                        break;
                    default: // 잘못된 숫자 범위 체크
                        Console.WriteLine("잘못된 메뉴 선택입니다.");
                        Console.WriteLine("다시 선택해주세요.");
                        break;
                }
            }
        }
    }
}

   