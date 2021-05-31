using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface
{
    class SalesMan : Fight // Fight라는 함수를 상속받음 : Fight라는 함수를 구현하도록
    {
        // 인터페이스를 추가했고 그 안의 함수를 무조건 구현해야 됨
        // 인터페이스 : 그 함수를 구현해라는 규칙
        public void fight()
        {
            throw new NotImplementedException(); // throw new NotImplementedException(); : 이 함수가 구현되어 있지 않다는 뜻
        }

        public void lose()
        {
            //throw new NotImplementedException();
        }

        public void win()
        {
            //throw new NotImplementedException();
        }
    }
}
