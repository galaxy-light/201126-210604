using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp0415_2
{
    struct Account // struct : int, string 변수의 값을 저장함(깊은 복사) / class : 주소값을 저장함(얕은 복사)
                   // struct / class 참고 : https://qzqz.tistory.com/192
    {
        public int myMoney;
        public string name;

        public Account(int money, string name)
        {
            myMoney = money;
            this.name = name;
        }

        // 입금
        public void deposit(int money)
        {
            myMoney += money;
        }

        // 출금
        public void withdraw(int money)
        {
            myMoney -= money;
        }
    }
}
