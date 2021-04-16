using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCSharp
{
    class Cat : Animal, IRunnable, IFight
    {
        public override void Eat() // override를 통해 구현
        {
            System.Windows.Forms.MessageBox.Show("집사 배고파 밥 줘");
            //throw new NotImplementedException();
            // throw new NotImplementedException(); : 구현이 안되어있다는 에러를 띄우는 것
        }


    }
}
